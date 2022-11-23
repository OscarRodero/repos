namespace CapaDePersistencia
{
    partial class ConsultasCombinadasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etxtTitulo = new System.Windows.Forms.TextBox();
            this.etxtAnio = new System.Windows.Forms.TextBox();
            this.etxtApellido = new System.Windows.Forms.TextBox();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.etxtNombre = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelAnio = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelEstilo = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // etxtTitulo
            // 
            this.etxtTitulo.Location = new System.Drawing.Point(136, 40);
            this.etxtTitulo.Name = "etxtTitulo";
            this.etxtTitulo.Size = new System.Drawing.Size(120, 20);
            this.etxtTitulo.TabIndex = 0;
            // 
            // etxtAnio
            // 
            this.etxtAnio.Location = new System.Drawing.Point(136, 96);
            this.etxtAnio.Name = "etxtAnio";
            this.etxtAnio.Size = new System.Drawing.Size(120, 20);
            this.etxtAnio.TabIndex = 1;
            // 
            // etxtApellido
            // 
            this.etxtApellido.Location = new System.Drawing.Point(136, 152);
            this.etxtApellido.Name = "etxtApellido";
            this.etxtApellido.Size = new System.Drawing.Size(120, 20);
            this.etxtApellido.TabIndex = 2;
            // 
            // cbEstilo
            // 
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Location = new System.Drawing.Point(392, 40);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(121, 21);
            this.cbEstilo.TabIndex = 3;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(392, 96);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // etxtNombre
            // 
            this.etxtNombre.Location = new System.Drawing.Point(392, 152);
            this.etxtNombre.Name = "etxtNombre";
            this.etxtNombre.Size = new System.Drawing.Size(120, 20);
            this.etxtNombre.TabIndex = 5;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(48, 48);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(76, 13);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Titulo Pelicula:";
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Location = new System.Drawing.Point(48, 104);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(69, 13);
            this.labelAnio.TabIndex = 7;
            this.labelAnio.Text = "Año Pelicula:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(40, 160);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(77, 13);
            this.labelApellido.TabIndex = 8;
            this.labelApellido.Text = "Apellido Socio:";
            // 
            // labelEstilo
            // 
            this.labelEstilo.AutoSize = true;
            this.labelEstilo.Location = new System.Drawing.Point(336, 48);
            this.labelEstilo.Name = "labelEstilo";
            this.labelEstilo.Size = new System.Drawing.Size(32, 13);
            this.labelEstilo.TabIndex = 9;
            this.labelEstilo.Text = "Estilo";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(312, 104);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(54, 13);
            this.labelCategoria.TabIndex = 10;
            this.labelCategoria.Text = "Categoría";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(296, 160);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(74, 13);
            this.labelNombre.TabIndex = 11;
            this.labelNombre.Text = "Nombre Socio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(152, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(408, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(40, 248);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(480, 150);
            this.dgvPeliculas.TabIndex = 14;
            // 
            // ConsultasCombinadasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 426);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelEstilo);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.etxtNombre);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.etxtApellido);
            this.Controls.Add(this.etxtAnio);
            this.Controls.Add(this.etxtTitulo);
            this.Name = "ConsultasCombinadasForm";
            this.Text = "ConsultasCombinadasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox etxtTitulo;
        private System.Windows.Forms.TextBox etxtAnio;
        private System.Windows.Forms.TextBox etxtApellido;
        private System.Windows.Forms.ComboBox cbEstilo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox etxtNombre;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelEstilo;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvPeliculas;
    }
}