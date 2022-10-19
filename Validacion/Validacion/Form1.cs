using System.Collections;
using System.Runtime.ExceptionServices;
using System.Windows.Forms.VisualStyles;

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
                //if (comprobarEmail(txtCorreo.Text) && comprobarNIF(mtxtNIF.Text) && comprobarCuenta(mtxtNumeroCuenta.Text)) {
                    btnArchivar.Enabled = true;
                //}
            } catch (ExcepcionDeTexto Exc) {
                MessageBox.Show(Exc.Message);
            }
        }

        private Boolean comprobarCuenta(string textoCuenta)
        {
            Boolean CuentaValida = true;
            int codigoCuenta = Int32.Parse(textoCuenta);

            if (!CuentaValida) {
                CuentaValida = false;
                throw new ExcepcionDeTexto("Cuenta no válida.");
            }  
            return CuentaValida;
        }

        private Boolean comprobarNIF(string mtxtNIF)
        {
            Boolean NIFValida=true;
            String soloNumero="";
            char Letra = 'a';
            for (int i = 0; i < mtxtNIF.Length; i++) {
                if (i < 9) { 
                    soloNumero=soloNumero + mtxtNIF[i];
                }
                if (i == 9) { 
                    Letra= mtxtNIF[i];
                }
            }
            int numNif= int.Parse(soloNumero);
            String Letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            if (!Letra.Equals(Letras[numNif % 23])) {
                NIFValida=false;
                throw new ExcepcionDeTexto("NIF incorrecto");
            }
            return NIFValida;
        }

        private Boolean comprobarEmail(String txtCorreo)
        {
            Boolean CorreoValida = false;
            for (int i = 0; i < txtCorreo.Length; i++) {
                if (txtCorreo[i] == '@') {
                    CorreoValida = true; 
                }
            }
            if (!CorreoValida) {
                throw new ExcepcionDeTexto("Correo no válido");
            }
            return CorreoValida;
        }
        class ExcepcionDeTexto : ApplicationException
        {

            string mensaje;
            public ExcepcionDeTexto(string mensaje)
            {
                this.mensaje = mensaje;
            }
            public string Mensaje
            {
                get
                {
                    return this.mensaje;
                }
            }
        }

        private void btnArchivar_Click(object sender, EventArgs e)
        {
            btnArchivar.Enabled = false;
            StreamWriter fich = new StreamWriter("FichDatos.txt", true);
            fich.WriteLine(txtNombre.Text + " " + txtApellidos.Text + " " + mtxtMovil.Text + " " + txtCorreo.Text + " " + mtxtMatricula.Text + " " + mtxtNIF.Text + " " + mtxtNumeroCuenta.Text);
            txtNombre.Text = "";
            txtApellidos.Text = "";
            mtxtMovil.Text = "";
            mtxtMovil.Text = "";
            txtCorreo.Text = "";
            mtxtMatricula.Text = "";
            mtxtNIF.Text = "";
            mtxtNumeroCuenta.Text = "";
            fich.Close();
        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            ArchivoDatos AD = new ArchivoDatos();
            AD.Owner = this;
            AD.ShowDialog();
        }
    }
}