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
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoclubDataSet);

        }

        private void peliculasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoclubDataSet);

        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'videoclubBinarioDataSet.peliculas' Puede moverla o quitarla según sea necesario.
          //  this.peliculasTableAdapter1.Fill(this.videoclubBinarioDataSet.peliculas);
            // TODO: esta línea de código carga datos en la tabla 'videoclubDataSet.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.videoclubDataSet.peliculas);
            this.MdiChildren[0].Close();
            frmAlquileres n = new frmAlquileres();
            n.MdiParent = this;
            n.Dock = DockStyle.Fill;
            n.Show();
        }
    }
}
