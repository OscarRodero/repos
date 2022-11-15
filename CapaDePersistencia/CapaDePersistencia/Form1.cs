using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePersistencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities()) {
                //Creamos el objeto categoría
                categorias objCat = new categorias();
                objCat.categoria = txtCategoria.Text;
                objCat.precio = (decimal?)float.Parse(txtPrecio.Text);
                //Se añade el objeto a la tabla, para incluirlo como nuevo registro
                objDB.categorias.Add(objCat);
                //Se guardan los cambios
                objDB.SaveChanges();
                MessageBox.Show("Categoría insertada correctamente");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                //Creamos el objeto categoría
                categorias objCat = objDB.categorias.Find(txtCategoria.Text);
                if (objCat != null)
                {
                    objCat.precio = (decimal?)float.Parse(txtPrecio.Text);
                    objDB.SaveChanges();
                    MessageBox.Show("Categoría modificada correctamente");
                }
                else {
                    MessageBox.Show("No se ha encontrado la categoría");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                //Creamos el objeto categoría
                categorias objCat = objDB.categorias.Find(txtCategoria.Text);
                if (objCat != null)
                {
                    objDB.categorias.Remove(objCat);
                    objDB.SaveChanges();
                    MessageBox.Show("Categoría eliminada correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la categoría");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities()) {
                var qCategorias = from cat in objDB.categorias
                                  where cat.categoria.ToUpper().StartsWith(txtBusquedaCat.Text.ToUpper())
                                  select new { cat.categoria, cat.precio };
                var listaCat = qCategorias.ToList();
                dataGridView1.DataSource = listaCat;
            }
        }

        private void btnBuscarXPrecio_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                var precioBuscado = Int32.Parse(txtPrecioCat.Text.ToString());  
                var qCategorias = from cat in objDB.categorias
                                  where cat.precio >= precioBuscado
                                  select new { cat.categoria, cat.precio };
                var listaCat = qCategorias.ToList();
                dataGridView1.DataSource = listaCat;
            }
        }

        private void BuscarX_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {               
                var qMultitabla = from cat in objDB.categorias 
                                  join peli in objDB.peliculas 
                                  on cat.categoria equals peli.categoria
                                  where cat.categoria.ToUpper().StartsWith(cajitaTexto.Text.ToUpper())
                                  orderby peli.titulo ascending
                                  select new { peli.titulo, peli.anio, peli.estilo, cat.categoria, cat.precio };

                var listaCat = qMultitabla.ToList();
                listaMultiple.DataSource = listaCat;
            }
        }
    }
}
