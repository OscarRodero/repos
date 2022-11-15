namespace CapaDePersistencia
{
    partial class AddPeliculaForm
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtProta = new System.Windows.Forms.TextBox();
            this.rtxtArgumento = new System.Windows.Forms.RichTextBox();
            this.labelCodPeli = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelProta = new System.Windows.Forms.Label();
            this.labelArgumento = new System.Windows.Forms.Label();
            this.labelEstilo = new System.Windows.Forms.Label();
            this.labelAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.pBoxCaratula = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCaratula)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(24, 40);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(24, 96);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(24, 160);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(100, 20);
            this.txtDirector.TabIndex = 2;
            // 
            // txtProta
            // 
            this.txtProta.Location = new System.Drawing.Point(24, 216);
            this.txtProta.Name = "txtProta";
            this.txtProta.Size = new System.Drawing.Size(100, 20);
            this.txtProta.TabIndex = 3;
            // 
            // rtxtArgumento
            // 
            this.rtxtArgumento.Location = new System.Drawing.Point(24, 272);
            this.rtxtArgumento.Name = "rtxtArgumento";
            this.rtxtArgumento.Size = new System.Drawing.Size(408, 96);
            this.rtxtArgumento.TabIndex = 4;
            this.rtxtArgumento.Text = "";
            // 
            // labelCodPeli
            // 
            this.labelCodPeli.AutoSize = true;
            this.labelCodPeli.Location = new System.Drawing.Point(24, 24);
            this.labelCodPeli.Name = "labelCodPeli";
            this.labelCodPeli.Size = new System.Drawing.Size(29, 13);
            this.labelCodPeli.TabIndex = 5;
            this.labelCodPeli.Text = "Cod:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(24, 80);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(24, 144);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(44, 13);
            this.labelDirector.TabIndex = 7;
            this.labelDirector.Text = "Director";
            // 
            // labelProta
            // 
            this.labelProta.AutoSize = true;
            this.labelProta.Location = new System.Drawing.Point(24, 200);
            this.labelProta.Name = "labelProta";
            this.labelProta.Size = new System.Drawing.Size(69, 13);
            this.labelProta.TabIndex = 8;
            this.labelProta.Text = "Protagonista:";
            // 
            // labelArgumento
            // 
            this.labelArgumento.AutoSize = true;
            this.labelArgumento.Location = new System.Drawing.Point(24, 256);
            this.labelArgumento.Name = "labelArgumento";
            this.labelArgumento.Size = new System.Drawing.Size(58, 13);
            this.labelArgumento.TabIndex = 9;
            this.labelArgumento.Text = "Argumento";
            // 
            // labelEstilo
            // 
            this.labelEstilo.AutoSize = true;
            this.labelEstilo.Location = new System.Drawing.Point(152, 24);
            this.labelEstilo.Name = "labelEstilo";
            this.labelEstilo.Size = new System.Drawing.Size(32, 13);
            this.labelEstilo.TabIndex = 10;
            this.labelEstilo.Text = "Estilo";
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Location = new System.Drawing.Point(152, 80);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(28, 13);
            this.labelAnio.TabIndex = 12;
            this.labelAnio.Text = "Anio";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(152, 96);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 13;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(152, 216);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 15;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(152, 144);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 16;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(152, 200);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(35, 13);
            this.labelStock.TabIndex = 17;
            this.labelStock.Text = "Stock";
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(296, 216);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(136, 23);
            this.btnSeleccionarImagen.TabIndex = 18;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // pBoxCaratula
            // 
            this.pBoxCaratula.Location = new System.Drawing.Point(296, 40);
            this.pBoxCaratula.Name = "pBoxCaratula";
            this.pBoxCaratula.Size = new System.Drawing.Size(136, 168);
            this.pBoxCaratula.TabIndex = 19;
            this.pBoxCaratula.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(136, 384);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(192, 24);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbEstilo
            // 
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Location = new System.Drawing.Point(152, 40);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(121, 21);
            this.cbEstilo.TabIndex = 21;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(152, 160);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 22;
            // 
            // AddPeliculaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 428);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pBoxCaratula);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.labelEstilo);
            this.Controls.Add(this.labelArgumento);
            this.Controls.Add(this.labelProta);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelCodPeli);
            this.Controls.Add(this.rtxtArgumento);
            this.Controls.Add(this.txtProta);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCod);
            this.Name = "AddPeliculaForm";
            this.Text = "AddPeliculaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCaratula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtProta;
        private System.Windows.Forms.RichTextBox rtxtArgumento;
        private System.Windows.Forms.Label labelCodPeli;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelProta;
        private System.Windows.Forms.Label labelArgumento;
        private System.Windows.Forms.Label labelEstilo;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.PictureBox pBoxCaratula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbEstilo;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}