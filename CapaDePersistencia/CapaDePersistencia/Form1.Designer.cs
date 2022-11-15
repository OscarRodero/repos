namespace CapaDePersistencia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBusquedaCat = new System.Windows.Forms.TextBox();
            this.txtPrecioCat = new System.Windows.Forms.TextBox();
            this.labelCampoCategoria = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarXPrecio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaMultiple = new System.Windows.Forms.DataGridView();
            this.cajitaTexto = new System.Windows.Forms.TextBox();
            this.BuscarX = new System.Windows.Forms.Button();
            this.gbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMultiple)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnDelete);
            this.gbBotones.Controls.Add(this.btnUpdate);
            this.gbBotones.Controls.Add(this.btnInsert);
            this.gbBotones.Location = new System.Drawing.Point(16, 120);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(208, 152);
            this.gbBotones.TabIndex = 0;
            this.gbBotones.TabStop = false;
            this.gbBotones.Text = "Opciones simples";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(72, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(72, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(72, 32);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(80, 16);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(80, 64);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 72);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtBusquedaCat
            // 
            this.txtBusquedaCat.Location = new System.Drawing.Point(136, 288);
            this.txtBusquedaCat.Name = "txtBusquedaCat";
            this.txtBusquedaCat.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaCat.TabIndex = 6;
            // 
            // txtPrecioCat
            // 
            this.txtPrecioCat.Location = new System.Drawing.Point(136, 312);
            this.txtPrecioCat.Name = "txtPrecioCat";
            this.txtPrecioCat.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCat.TabIndex = 7;
            // 
            // labelCampoCategoria
            // 
            this.labelCampoCategoria.AutoSize = true;
            this.labelCampoCategoria.Location = new System.Drawing.Point(40, 296);
            this.labelCampoCategoria.Name = "labelCampoCategoria";
            this.labelCampoCategoria.Size = new System.Drawing.Size(90, 13);
            this.labelCampoCategoria.TabIndex = 8;
            this.labelCampoCategoria.Text = "Campo Categoría";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(40, 320);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "Precio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(256, 288);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarXPrecio
            // 
            this.btnBuscarXPrecio.Location = new System.Drawing.Point(256, 312);
            this.btnBuscarXPrecio.Name = "btnBuscarXPrecio";
            this.btnBuscarXPrecio.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarXPrecio.TabIndex = 11;
            this.btnBuscarXPrecio.Text = "Buscar por precio";
            this.btnBuscarXPrecio.UseVisualStyleBackColor = true;
            this.btnBuscarXPrecio.Click += new System.EventHandler(this.btnBuscarXPrecio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuscarX);
            this.groupBox1.Controls.Add(this.cajitaTexto);
            this.groupBox1.Controls.Add(this.listaMultiple);
            this.groupBox1.Location = new System.Drawing.Point(464, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 384);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas Multitablas";
            // 
            // listaMultiple
            // 
            this.listaMultiple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMultiple.Location = new System.Drawing.Point(16, 80);
            this.listaMultiple.Name = "listaMultiple";
            this.listaMultiple.Size = new System.Drawing.Size(280, 288);
            this.listaMultiple.TabIndex = 0;
            // 
            // cajitaTexto
            // 
            this.cajitaTexto.Location = new System.Drawing.Point(16, 40);
            this.cajitaTexto.Name = "cajitaTexto";
            this.cajitaTexto.Size = new System.Drawing.Size(120, 20);
            this.cajitaTexto.TabIndex = 13;
            // 
            // BuscarX
            // 
            this.BuscarX.Location = new System.Drawing.Point(152, 40);
            this.BuscarX.Name = "BuscarX";
            this.BuscarX.Size = new System.Drawing.Size(144, 23);
            this.BuscarX.TabIndex = 14;
            this.BuscarX.Text = "Buscar por categoría";
            this.BuscarX.UseVisualStyleBackColor = true;
            this.BuscarX.Click += new System.EventHandler(this.BuscarX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarXPrecio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCampoCategoria);
            this.Controls.Add(this.txtPrecioCat);
            this.Controls.Add(this.txtBusquedaCat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.gbBotones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMultiple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBusquedaCat;
        private System.Windows.Forms.TextBox txtPrecioCat;
        private System.Windows.Forms.Label labelCampoCategoria;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarXPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuscarX;
        private System.Windows.Forms.TextBox cajitaTexto;
        private System.Windows.Forms.DataGridView listaMultiple;
    }
}

