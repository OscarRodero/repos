namespace Probando2
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.rtbEsquema = new System.Windows.Forms.RichTextBox();
            this.btnLeerXML = new System.Windows.Forms.Button();
            this.btnMostrarEsquema = new System.Windows.Forms.Button();
            this.btnTelefonos = new System.Windows.Forms.Button();
            this.btnFichGenerado = new System.Windows.Forms.Button();
            this.btnGuardarXML = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.dsDatos = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(8, 8);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(776, 152);
            this.dgvDatos.TabIndex = 0;
            // 
            // rtbEsquema
            // 
            this.rtbEsquema.Location = new System.Drawing.Point(8, 168);
            this.rtbEsquema.Name = "rtbEsquema";
            this.rtbEsquema.Size = new System.Drawing.Size(776, 152);
            this.rtbEsquema.TabIndex = 1;
            this.rtbEsquema.Text = "";
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.Location = new System.Drawing.Point(8, 392);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(120, 47);
            this.btnLeerXML.TabIndex = 2;
            this.btnLeerXML.Text = "Leer XML";
            this.btnLeerXML.UseVisualStyleBackColor = true;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // btnMostrarEsquema
            // 
            this.btnMostrarEsquema.Location = new System.Drawing.Point(144, 392);
            this.btnMostrarEsquema.Name = "btnMostrarEsquema";
            this.btnMostrarEsquema.Size = new System.Drawing.Size(120, 48);
            this.btnMostrarEsquema.TabIndex = 3;
            this.btnMostrarEsquema.Text = "Mostrar Esquema";
            this.btnMostrarEsquema.UseVisualStyleBackColor = true;
            this.btnMostrarEsquema.Click += new System.EventHandler(this.btnMostrarEsquema_Click);
            // 
            // btnTelefonos
            // 
            this.btnTelefonos.Location = new System.Drawing.Point(272, 392);
            this.btnTelefonos.Name = "btnTelefonos";
            this.btnTelefonos.Size = new System.Drawing.Size(120, 47);
            this.btnTelefonos.TabIndex = 4;
            this.btnTelefonos.Text = "Teléfonos";
            this.btnTelefonos.UseVisualStyleBackColor = true;
            this.btnTelefonos.Click += new System.EventHandler(this.btnTelefonos_Click);
            // 
            // btnFichGenerado
            // 
            this.btnFichGenerado.Location = new System.Drawing.Point(400, 392);
            this.btnFichGenerado.Name = "btnFichGenerado";
            this.btnFichGenerado.Size = new System.Drawing.Size(112, 47);
            this.btnFichGenerado.TabIndex = 5;
            this.btnFichGenerado.Text = "Fichero Generado";
            this.btnFichGenerado.UseVisualStyleBackColor = true;
            this.btnFichGenerado.Click += new System.EventHandler(this.btnFichGenerado_Click);
            // 
            // btnGuardarXML
            // 
            this.btnGuardarXML.Location = new System.Drawing.Point(520, 392);
            this.btnGuardarXML.Name = "btnGuardarXML";
            this.btnGuardarXML.Size = new System.Drawing.Size(112, 47);
            this.btnGuardarXML.TabIndex = 6;
            this.btnGuardarXML.Text = "Guardar XML";
            this.btnGuardarXML.UseVisualStyleBackColor = true;
            this.btnGuardarXML.Click += new System.EventHandler(this.btnGuardarXML_Click);
            // 
            // abrir
            // 
            this.abrir.FileName = "openFileDialog1";
            // 
            // dsDatos
            // 
            this.dsDatos.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarXML);
            this.Controls.Add(this.btnFichGenerado);
            this.Controls.Add(this.btnTelefonos);
            this.Controls.Add(this.btnMostrarEsquema);
            this.Controls.Add(this.btnLeerXML);
            this.Controls.Add(this.rtbEsquema);
            this.Controls.Add(this.dgvDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.RichTextBox rtbEsquema;
        private System.Windows.Forms.Button btnLeerXML;
        private System.Windows.Forms.Button btnMostrarEsquema;
        private System.Windows.Forms.Button btnTelefonos;
        private System.Windows.Forms.Button btnFichGenerado;
        private System.Windows.Forms.Button btnGuardarXML;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Data.DataSet dsDatos;
    }
}

