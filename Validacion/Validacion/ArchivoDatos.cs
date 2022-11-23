using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Validacion
{
    public partial class ArchivoDatos : Form
    {
        public ArchivoDatos()
        {
            InitializeComponent();
            StreamReader fich = new StreamReader("FichDatos.txt");
            textoArchivo.Text=fich.ReadToEnd();
            fich.Close();
        }
    }
}
