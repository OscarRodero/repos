using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Probando2
{
    public partial class Form1 : Form
    {
        String ruta;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLeerXML_Click(object sender, EventArgs e)
        {
            if (abrir.ShowDialog() == DialogResult.OK) {
                ruta = abrir.FileName;
                LimpiarDatos();
                dsDatos.ReadXml(ruta);
                dgvDatos.DataSource = dsDatos.Tables[0];
            }
        }

        private void LimpiarDatos()
        {
            dsDatos = new DataSet();
            dgvDatos.DataSource = null;
            dgvDatos.Rows.Clear();
            dgvDatos.Refresh();
            rtbEsquema.Text = "";
        }

        private void btnMostrarEsquema_Click(object sender, EventArgs e)
        {
            StringWriter swXML = new StringWriter();
            dsDatos.WriteXmlSchema(swXML);
            rtbEsquema.Text = swXML.ToString();
        }

        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            Form2 telefonos = new Form2(dsDatos);
            telefonos.ShowDialog();
        }

        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            FileStream ficheroXML = new FileStream(ruta, FileMode.Create);
            dsDatos.WriteXml(ficheroXML);
            ficheroXML.Close();
            MessageBox.Show("Se han guardado los datos correctametne", "Datos guardados", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFichGenerado_Click(object sender, EventArgs e)
        {
            XmlDocument XDoc = new XmlDocument();
            XmlElement elementoRaiz = XDoc.CreateElement(string.Empty, "raiz", string.Empty);
            XDoc.AppendChild(elementoRaiz); //Ubica al elemento raíz dentro del documento padre.

            XmlElement xHijo = XDoc.CreateElement(string.Empty, "hijo", string.Empty);
            xHijo.SetAttribute("id", "El valor que quiera"); //Declaración de atributos de xHijo. 
            //El primero es el nombr ey el segundo el valor.
            elementoRaiz.AppendChild(xHijo); //Al elemento raíz le añado el elemento xHijo

            XmlText xTxTUna = XDoc.CreateTextNode("Un valor");//Etiqueta dentro de xHijo, el valor es "Un valor"
            xHijo.AppendChild(xTxTUna); //Lo añadimos al hijo

            //Guardar el documento:
            XmlTextWriter xtw = new XmlTextWriter("prueba.xml", Encoding.UTF8);
            xtw.Formatting = Formatting.Indented;
            XDoc.Save(xtw);
            xtw.Close();
        }
    }
}
