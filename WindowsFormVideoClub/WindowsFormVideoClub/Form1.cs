using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormVideoClub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dsDB miDB = new dsDB();
            dsDBTableAdapters.sociosTableAdapter ta = new dsDBTableAdapters.sociosTableAdapter();
            ta.FillByLogin(miDB.socios, txtLogin.Text, txtContraseña.Text);
            if (miDB.socios.Count > 0) {
                MessageBox.Show("Bienvenido " + miDB.socios[0].nombre,"Mensaje de Bienvenida",MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Login y/o contraseña incorrectos", "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
