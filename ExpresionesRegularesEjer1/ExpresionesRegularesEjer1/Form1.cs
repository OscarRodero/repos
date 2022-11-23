using System.Text.RegularExpressions;

namespace ExpresionesRegularesEjer1
{
    public partial class Form1 : Form
    {
        private const string Patron = @"\A\d{3}\.\d{2}\Z";
        private const string Patron2 = @"\A[(]\d{1,3}[,]\d{1,3}[)]\Z";
        private const string Patron3 = @"\A\(d{3}[,]){3}\d{3}";
        private const string Patron4 = @"\A(lunes|martes|miercoles|jueves|viernes|sabado|domingo)\s\d{1,2}\Z";
        private const string Patron5 = @"\A([0-1]\d|2[0-3])[:][0-5]\d([:][0-5]\d)?\Z";
        private const string Patron6 = @"\A(ES)\d{2}[-]\d{4}[-]\d{2}[-]\d{10}\Z";

        private const string Patron7 = @"\A(0|[+-]?[1-9]\d*)\Z";
        private const string Patron8 = @"\A(\d{8}[-][TRWAGMYFPDXBNJZSQVHLCKE])\Z";
        private const string Patron9 = @"\A(([1-9]?\d|1\d{2}|2[0-4]\d|25[0-5])[.]){3}([1-9]?\d|1\d{2}|2[0-4]\d|25[0-5])\Z"; 
        private const string Patron10 = @"\A\d\d\d\d(\s)?[A-Z][A-Z][A-Z]";
        private const string Patron11 = @"\A([-]?\d{1}(.|,)\d)\Z";
        private const string Patron12 = @"\A([0-3]?\d[/][0-1]?\d[/][1-2]\d\d\d)\Z";
        private const string Patron13 = @"\A([A-Z][a-z]+(\s[A-Z][a-z]++)?)\Z";
        private const string Patron14 = @"\A[@]\D+\Z";
        private const string Patron15 = @"\A((987|979)[-]\d[-]\d{2}[-]\d{6}[-]\d)\Z";
        private const string Patron16 = @"\A([A-Z][a-z]\d\w{15})\Z";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar1_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar2_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron2);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar3_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron3);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }
        private void btnValidar4_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron4);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }
        private void btnValidar5_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron5);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar6_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron6);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar7_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron7);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar8_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron8);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar9_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron9);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar10_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron10);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar11_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron11);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar12_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron12);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar13_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron13);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar14_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron14);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar15_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron15);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }

        private void btnValidar16_Click(object sender, EventArgs e)
        {
            bool boo_resutlado = Regex.IsMatch(txtBox1.Text, Patron16);
            if (boo_resutlado)
            {
                PB1.Image = ListaImagenes.Images[0];
            }
            else
            {
                PB1.Image = ListaImagenes.Images[1];
            }
        }
    }
}