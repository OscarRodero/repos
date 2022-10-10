using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    public partial class Form1 : Form
    {
        private const string Patron = @"\A(\d{8})([-]?)([A-Z]{1})\Z";
        public Form1()
        {
            InitializeComponent();
        }

        private void bntComprobar_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtTexto.Text, Patron);
            if (boo_resutlado) {
                MessageBox.Show("Si cumple el patrón");
                PB1.Image = ListaImagenes.Images[0];
            } else {
                PB1.Image = ListaImagenes.Images[1];
                MessageBox.Show("No cumple el patrón");
            }
        }
    }
}