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
    public partial class FormTabla : Form
    {
        public FormTabla()
        {
            InitializeComponent();
        }

        private void sociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDB);

        }

        private void FormTabla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDB.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.dsDB.socios);

        }
    }
}
