using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaFormulario
{
    public partial class FormContenedor : Form
    {
        public FormContenedor()
        {
            InitializeComponent();
        }

        private void btnTextBox_Click(object sender, EventArgs e){
            if (this.MdiChildren.Length > 0){
                DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK){
                    this.MdiChildren[0].Close();
                    frmTextBox n = new frmTextBox();
                    n.MdiParent = this;
                    n.Dock = DockStyle.Fill;
                    n.Show();
                }
            }else {
                frmTextBox n = new frmTextBox();
                n.MdiParent = this;
                n.Dock = DockStyle.Fill;
                n.Show();
            }
            
        }
    }

        private void btnTriángulos_Click(object sender, EventArgs e)
        {

        }

        private void btnColores_Click(object sender, EventArgs e)
        {

        }

        private void btnListas_Click(object sender, EventArgs e)
        {

        }

        private void btnCajas_Click(object sender, EventArgs e)
        {

        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {

        }

        private void btnCalendarios_Click(object sender, EventArgs e)
        {

        }

        private void btnTemporizador_Click(object sender, EventArgs e)
        {

        }

        private void btnGama_Colores_Click(object sender, EventArgs e)
        {

        }

        private void btnLista_Imagenes_Click(object sender, EventArgs e)
        {

        }
    }
