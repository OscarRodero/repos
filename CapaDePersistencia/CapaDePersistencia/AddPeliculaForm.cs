using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePersistencia
{
    public partial class AddPeliculaForm : Form
    {
        private byte[] binData = null;
        public AddPeliculaForm()
        {
            InitializeComponent();
        }
        private void AddPeliculaForm_load(object sender, EventArgs e) {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities()) {
                foreach (var cat in objDB.categorias)
                {
                    cbCategoria.Items.Add(cat);
                }
                foreach (var est in objDB.estilos) { 
                    cbEstilo.Items.Add(est);
                }
            }
                
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                pBoxCaratula.Image = Image.FromFile(openFileDialog.FileName);
                FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

                binData = new byte[stream.Length];
                stream.Read(binData, 0, Convert.ToInt32(stream.Length));
            }            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text.Equals("") || txtTitulo.Text.Equals("") || txtDirector.Text.Equals("") || txtProta.Text.Equals("") || cbEstilo.Text.Equals("") || txtAnio.Text.Equals("") || cbCategoria.Text.Equals("") || txtStock.Text.Equals("") || rtxtArgumento.Text.Equals("") || pBoxCaratula.Image.ToString().Equals(""))
            {
                MessageBox.Show("No puede haber ningún campo vacío.");
            }
            else {
                int a, b, c;
                Boolean AnioPeli = int.TryParse(txtAnio.Text.ToString(), out a);
                Boolean Stock = int.TryParse(txtStock.Text.ToString(), out b);
                Boolean Cod = int.TryParse(txtCod.Text.ToString(), out c);
                if (AnioPeli && Stock) {
                    using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
                    {

                        //Creamos el objeto categoría
                        peliculas objPeli = new peliculas();
                        objPeli.codpeli = c;
                        objPeli.titulo = txtTitulo.Text;
                        objPeli.director = txtDirector.Text;
                        objPeli.protagonista = txtProta.Text;
                        objPeli.estilo = cbEstilo.Text;
                        objPeli.anio = a;
                        objPeli.categoria = cbCategoria.Text;
                        objPeli.stock = b;
                        objPeli.argumento = rtxtArgumento.Text;
                        byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(pBoxCaratula.Image, typeof(byte[]));
                        objPeli.caratula = bytes;
                        //Se añade el objeto a la tabla, para incluirlo como nuevo registro
                        objDB.peliculas.Add(objPeli);
                        //Se guardan los cambios
                        objDB.SaveChanges();
                        MessageBox.Show("Categoría insertada correctamente");
                    }
                }
            }
        }
    }
}
