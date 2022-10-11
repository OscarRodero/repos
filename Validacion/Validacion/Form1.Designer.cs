namespace Validacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnArchivar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnVerArchivo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtxtMatricula = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNIF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNombreCuenta = new System.Windows.Forms.MaskedTextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.mtxtMovil = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Móvil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matrícula coche:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "NIF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre de la cuenta:";
            // 
            // btnArchivar
            // 
            this.btnArchivar.Location = new System.Drawing.Point(216, 312);
            this.btnArchivar.Name = "btnArchivar";
            this.btnArchivar.Size = new System.Drawing.Size(176, 40);
            this.btnArchivar.TabIndex = 7;
            this.btnArchivar.Text = "Archivar";
            this.btnArchivar.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(400, 312);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(176, 40);
            this.btnValidar.TabIndex = 8;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Location = new System.Drawing.Point(304, 376);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(184, 39);
            this.btnVerArchivo.TabIndex = 9;
            this.btnVerArchivo.Text = "Ver Datos Archivados";
            this.btnVerArchivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 23);
            this.txtNombre.TabIndex = 10;
            // 
            // mtxtMatricula
            // 
            this.mtxtMatricula.Location = new System.Drawing.Point(168, 216);
            this.mtxtMatricula.Mask = "0000-LLL";
            this.mtxtMatricula.Name = "mtxtMatricula";
            this.mtxtMatricula.Size = new System.Drawing.Size(216, 23);
            this.mtxtMatricula.TabIndex = 12;
            // 
            // mtxtNIF
            // 
            this.mtxtNIF.Location = new System.Drawing.Point(432, 216);
            this.mtxtNIF.Mask = "00000000-L";
            this.mtxtNIF.Name = "mtxtNIF";
            this.mtxtNIF.Size = new System.Drawing.Size(144, 23);
            this.mtxtNIF.TabIndex = 13;
            // 
            // mtxtNombreCuenta
            // 
            this.mtxtNombreCuenta.Location = new System.Drawing.Point(200, 256);
            this.mtxtNombreCuenta.Mask = "ES00-0000.0000.00.0000000000";
            this.mtxtNombreCuenta.Name = "mtxtNombreCuenta";
            this.mtxtNombreCuenta.Size = new System.Drawing.Size(328, 23);
            this.mtxtNombreCuenta.TabIndex = 14;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(136, 96);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(248, 23);
            this.txtApellidos.TabIndex = 15;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(136, 176);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(248, 23);
            this.txtCorreo.TabIndex = 16;
            // 
            // mtxtMovil
            // 
            this.mtxtMovil.Location = new System.Drawing.Point(136, 136);
            this.mtxtMovil.Mask = "000-000-000";
            this.mtxtMovil.Name = "mtxtMovil";
            this.mtxtMovil.Size = new System.Drawing.Size(248, 23);
            this.mtxtMovil.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxtMovil);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.mtxtNombreCuenta);
            this.Controls.Add(this.mtxtNIF);
            this.Controls.Add(this.mtxtMatricula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnVerArchivo);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnArchivar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnArchivar;
        private Button btnValidar;
        private Button btnVerArchivo;
        private TextBox txtNombre;
        private MaskedTextBox mtxtMatricula;
        private MaskedTextBox mtxtNIF;
        private MaskedTextBox mtxtNombreCuenta;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private MaskedTextBox mtxtMovil;
    }
}