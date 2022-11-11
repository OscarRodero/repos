using Peliculas.videoclubDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peliculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoclubDataSet);
            cargarComboPeliculas();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'videoclubDataSet.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.videoclubDataSet.categorias);
            this.peliculasTableAdapter.Fill(this.videoclubDataSet.peliculas);
            this.alquileresTableAdapter.Fill(this.videoclubDataSet.alquileres);
            cargarComboPeliculas();
        }

        private void cargarComboPeliculas()
        {
            cmbPelisTitulo.Items.Clear();
            foreach (var peli in this.videoclubDataSet.peliculas){
                cmbPelisTitulo.Items.Add(peli.titulo);
            }
        }

        private void btnCambiaCaratula_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                caratulaPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.peliculasTableAdapter.Fill(this.videoclubDataSet.peliculas);
            cmbPelisTitulo.Text = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres eliminar la película?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                alquileresTableAdapter taAlquileres = new alquileresTableAdapter();
                taAlquileres.FillByPeliculas(this.videoclubDataSet.alquileres, int.Parse(codpeliLabel1.Text));
                if (videoclubDataSet.alquileres.Count > 0)
                {
                    MessageBox.Show("No se puede borrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int registros = this.peliculasTableAdapter.Delete(int.Parse(codpeliLabel1.Text));
                    MessageBox.Show("Película eliminada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.peliculasTableAdapter.Fill(this.videoclubDataSet.peliculas);
                    cargarComboPeliculas();
                }
            }
        }

        private void cmbPelisTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.peliculasTableAdapter.FillByTitulo(this.videoclubDataSet.peliculas, cmbPelisTitulo.Text);
        }
        //private void btnBuscar_Click(object sender, EventArgs e) {
        //    FormBusqueda frmBusqueda = new FormBusqueda();
        //    if (frmBusqueda.ShowDialog() == DialogResult.Cancel) {
        //        if (frmBusqueda.IdSocio != null) {
        //            txtCodCliente.Text = frmBusqueda.IdSocio;
        //            txtNombre.Text = frmBusqueda.Nombre;
        //            txtApellido1.Text = frmBusqueda.Apellido1;
        //            txtApellido2.Text = frmBusqueda.Apellido2;
        //        }
        //    }
        //}
        //private void dgvResutlado_CellDoubleClick(object sender, DataGridViewCellEventArgs) {
        //    IDSocio = dgvResultado.SelectedRows[0].Cells[0].Value.ToString();
        //    Nombre = dgvResultado.SelectedRows[0].Cells[1].Value.ToString();
        //    Apellido1 = dgvResultado.SelectedRows[0].Cells[1].Value.ToString();
        //    Apellido2 = dgvResultado.SelectedRows[0].Cells[1].Value.ToString();
        //    this.Close();
        //}
    }
}
