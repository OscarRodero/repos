namespace Validacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try {
                comprobarEmail(txtCorreo.Text);
            } catch (ExcepcionCorreo Exc) {
                MessageBox.Show(Exc.Message);
            }
        }

        class ExcepcionCorreo : ApplicationException {

            string mensaje;
            public ExcepcionCorreo(string mensaje) {
                this.mensaje = mensaje;
            }
            public string Mensaje
            {
                get {
                    return this.mensaje;
                }
            }
        }
        private void comprobarEmail(String txtCorreo)
        {
            Boolean CorreoValida = false;
            for (int i = 0; i < txtCorreo.Length; i++) {
                if (txtCorreo[i] == '@') { CorreoValida = true; }
            }
            if (!CorreoValida) { throw new ExcepcionCorreo; }
        }
    }
}