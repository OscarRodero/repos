using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Horario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc;
            XmlTextWriter xtw;
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                xtw = new XmlTextWriter(sfdGuardar.FileName, Encoding.UTF8);
                xtw.Formatting = Formatting.Indented;
                xDoc = new XmlDocument();
                //Construir un nuevo XMLDocument vacío, el cuál se irá rellenando con los datos
                //del Dataset asociado al DataGridView y se le irán añadiendo para cada día
                //una nueva etiqueta con la información del toltiptext
                XmlElement elementoRaiz = xDoc.CreateElement(string.Empty, "horario", string.Empty);
                xDoc.AppendChild(elementoRaiz);
                for (int f = 0; f < dgvHorario.Rows.Count; f++)
                {
                    XmlElement xHora = xDoc.CreateElement(string.Empty, "hora", string.Empty);
                    //El atributo id con la hora se puede sacar de la primera columna del DataGridView
                    xHora.SetAttribute("id", dgvHorario.Rows[f].Cells[0].Value.ToString());
                    for (int c = 1; c < dgvHorario.Columns.Count; c++)
                    {
                        XmlElement xDia = xDoc.CreateElement(string.Empty, "dia", string.Empty);
                        XmlElement xPantalla = xDoc.CreateElement(string.Empty, "pantalla", string.Empty);
                        XmlElement xAyuda = xDoc.CreateElement(string.Empty, "ayuda", string.Empty);
                        XmlText xTxTPantalla = xDoc.CreateTextNode(dgvHorario.Rows[f].Cells[c].Value.ToString());
                        xPantalla.AppendChild(xTxTPantalla);
                        XmlText xTxTAyuda = xDoc.CreateTextNode(dgvHorario.Rows[f].Cells[c].ToolTipText);
                        xAyuda.AppendChild(xTxTAyuda);
                        xDia.AppendChild(xPantalla);
                        xDia.AppendChild(xAyuda);
                        xHora.AppendChild(xDia);
                    }
                    elementoRaiz.AppendChild(xHora);
                }
                //Por último, escribir el contenido del XMLDocument en el archivo y cerrar conexión
                xDoc.Save(xtw);
                xtw.Close();
                MessageBox.Show("Se ha guardado el horario", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Boolean cargado;
            XmlDocument xDoc;
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                var ruta = ofdAbrir.FileName;
                //LimpiarDatos();
                //Se lee el XML con un XMLDocument
                xDoc = new XmlDocument();
                xDoc.Load(ruta);
                //Añadimos la tabla al horario directamente, con las columnas fijas
                dsDatos.Tables.Add(new DataTable("horario"));
                dsDatos.Tables[0].Columns.Add("Hora", typeof(string));
                dsDatos.Tables[0].Columns.Add("Lunes", typeof(string));
                dsDatos.Tables[0].Columns.Add("Martes", typeof(string));
                dsDatos.Tables[0].Columns.Add("Miercoles", typeof(string));
                dsDatos.Tables[0].Columns.Add("Jueves", typeof(string));
                dsDatos.Tables[0].Columns.Add("Viernes", typeof(string));
                //Recorremos el XMLDocument y vamos rellenando el DataSet junto con los tooltiptext
                XmlNodeList horario = xDoc.GetElementsByTagName("horario");
                XmlNodeList horas = ((XmlElement)horario[0]).GetElementsByTagName("hora");
                int cont_hora = 0;
                foreach (XmlElement hora in horas)
                {
                    //Construimos dos arrays de strings, uno para los textos a mostrar y otros con las ayudas
                    string[] fila_pant = new string[6];
                    string[] fila_ayu = new string[6];
                    //La primera columna de cada fila será la hora: primera, segunda, etc.
                    fila_pant[0] = hora.GetAttribute("id").ToString();
                    fila_ayu[0] = "";
                    int col = 1;
                    XmlNodeList dias = hora.GetElementsByTagName("dia");
                    foreach (XmlElement dia in dias)
                    {
                        XmlNodeList entrada_pant = dia.GetElementsByTagName("pantalla");
                        fila_pant[col] = ((XmlElement)entrada_pant[0]).InnerText.ToString();
                        XmlNodeList entrada_ayu = dia.GetElementsByTagName("ayuda");
                        fila_ayu[col] = ((XmlElement)entrada_ayu[0]).InnerText.ToString();
                        col++;
                    }
                    dsDatos.Tables[0].Rows.Add(fila_pant);
                    //Antes de pasar a la siguiente fila, se enlaza el dataGridView y el DataSet
                    //Y así podemos establecer los textos de ayuda
                    dgvHorario.DataSource = dsDatos.Tables[0];
                    for (int c = 1; c < fila_ayu.Length; c++)
                    {
                        dgvHorario.Rows[cont_hora].Cells[c].ToolTipText = fila_ayu[c];
                    }
                    cont_hora++;
                }
                cargado = true;
            }
            else
            {
                cargado = false;
            }
        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHora.SelectedIndex != -1 && cbDia.SelectedIndex != -1)
            {
                seleccionar();
            }
        }
        private void cbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDia.SelectedIndex != -1 && cbHora.SelectedIndex!=-1) { 
                seleccionar();
            }
        }

        private void seleccionar()
        {
            if (dgvHorario.Rows.Count != 0) {
                int hora = cbHora.SelectedIndex;
                int dia = cbDia.SelectedIndex;
                this.dgvHorario.CurrentCell = this.dgvHorario[dia + 1, hora];
                this.dgvHorario.CurrentCell.Selected = true;
            }            
        }

        private void lbListaCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbListaCiclo.SelectedIndex == 0) { 
                cbCurso.Items.Clear();
                cbCurso.Items.Add("2ºDAM");                
            }
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurso.Items.Count != 0) {
                lbModulos.Items.Clear();
                lbModulos.Items.Add("DESARROLLO DE INTERFACES");
                lbModulos.Items.Add("ACCESO A DATOS");
                lbModulos.Items.Add("PROGRAMACIÓN DE SERVICIOS Y PROCESOS");
                lbModulos.Items.Add("PROGRAMACIÓN EN DISPOSITIVOS MÓVILES");
                lbModulos.Items.Add("SISTEMAS DE GESTIÓN EMPRESARIAL");
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (cbHora.SelectedIndex >= 0 && cbHora.SelectedIndex <= 6 && cbDia.SelectedIndex >= 1 && cbDia.SelectedIndex <= 6)
            {
                if (lbModulos.SelectedIndex != -1) {
                    String[] ayudas = { "Jose Alberto", "Joaquín", "Marciano", "Fernando", "Inmaculada" };
                    seleccionar();
                    this.dgvHorario.CurrentCell.Value = lbModulos.SelectedItem;
                    this.dgvHorario.CurrentCell.ToolTipText = lbModulos.SelectedItem + Environment.NewLine + ayudas[lbModulos.SelectedIndex];

                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cbHora.SelectedIndex >= 0 && cbHora.SelectedIndex <= 6 && cbDia.SelectedIndex >= 1 && cbDia.SelectedIndex <= 6)
            {
                seleccionar();
                this.dgvHorario.CurrentCell.Value = null;
                this.dgvHorario.CurrentCell.ToolTipText = null;
            }
        }
    }
}
