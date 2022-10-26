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
    public partial class FormDetalle : Form
    {
        public FormDetalle()
        {
            InitializeComponent();
        }

        private void sociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDB);

        }

        private void sociosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDB);

        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDB.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.dsDB.socios);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int regs;
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("¿Seguro que quieres eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes) {
                dsDBTableAdapters.alquileresTableAdapter taAlquileres = new dsDBTableAdapters.alquileresTableAdapter();
                taAlquileres.FillBySocio(this.dsDB.alquileres, int.Parse(idSocioTextBox.Text));
                if (this.dsDB.alquileres.Count() > 0)
                {
                    DialogResult respuesta = MessageBox.Show("Se ha encontrado alquileres en el socio, ¿desea eliminarlos y continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (respuesta == DialogResult.Yes) {
                        //Se eliminan los alquileres
                        taAlquileres.DeleteQuerySocios(int.Parse(idSocioTextBox.Text));
                        //Se elimina al socio
                        int registros = this.sociosTableAdapter.Delete(int.Parse(idSocioTextBox.Text));
                        if (registros > 0)
                        {
                            MessageBox.Show("Se ha eliminado al socio");
                            this.sociosTableAdapter.Fill(this.dsDB.socios);
                        }
                    }
                }
                else {
                    int registros = this.sociosTableAdapter.Delete(int.Parse(idSocioTextBox.Text));
                    if (registros > 0)
                    {
                        MessageBox.Show("Se ha eliminado al socio");
                        this.sociosTableAdapter.Fill(this.dsDB.socios);
                    }
                }
                
            }
           
        }
    }
}
