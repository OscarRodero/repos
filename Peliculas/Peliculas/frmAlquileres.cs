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
    public partial class frmAlquileres : Form
    {
        public frmAlquileres()
        {
            InitializeComponent();
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'videoclubBinarioDataSet.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.videoclubBinarioDataSet.peliculas);
            // TODO: esta línea de código carga datos en la tabla 'videoclubBinarioDataSet.alq_peliculas_socios' Puede moverla o quitarla según sea necesario.
            //this.alq_peliculas_sociosTableAdapter.Fill(this.videoclubBinarioDataSet.alq_peliculas_socios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaDeSociosForm n = new BusquedaDeSociosForm();
            n.ShowDialog();
        }
    }
}
