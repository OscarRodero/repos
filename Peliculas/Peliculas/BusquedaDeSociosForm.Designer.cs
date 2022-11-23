namespace Peliculas
{
    partial class BusquedaDeSociosForm
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
            this.CodSocioLabel = new System.Windows.Forms.Label();
            this.NombreSocioLabel = new System.Windows.Forms.Label();
            this.ApellidosSocioLabel = new System.Windows.Forms.Label();
            this.txtBoxCodSocio = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtApe1 = new System.Windows.Forms.TextBox();
            this.txtApe2 = new System.Windows.Forms.TextBox();
            this.btnBuscar_Click = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodSocioLabel
            // 
            this.CodSocioLabel.AutoSize = true;
            this.CodSocioLabel.Location = new System.Drawing.Point(80, 32);
            this.CodSocioLabel.Name = "CodSocioLabel";
            this.CodSocioLabel.Size = new System.Drawing.Size(62, 13);
            this.CodSocioLabel.TabIndex = 0;
            this.CodSocioLabel.Text = "Cod. Socio:";
            // 
            // NombreSocioLabel
            // 
            this.NombreSocioLabel.AutoSize = true;
            this.NombreSocioLabel.Location = new System.Drawing.Point(80, 80);
            this.NombreSocioLabel.Name = "NombreSocioLabel";
            this.NombreSocioLabel.Size = new System.Drawing.Size(66, 13);
            this.NombreSocioLabel.TabIndex = 1;
            this.NombreSocioLabel.Text = "Por Nombre:";
            // 
            // ApellidosSocioLabel
            // 
            this.ApellidosSocioLabel.AutoSize = true;
            this.ApellidosSocioLabel.Location = new System.Drawing.Point(80, 120);
            this.ApellidosSocioLabel.Name = "ApellidosSocioLabel";
            this.ApellidosSocioLabel.Size = new System.Drawing.Size(71, 13);
            this.ApellidosSocioLabel.TabIndex = 2;
            this.ApellidosSocioLabel.Text = "Por Apellidos:";
            // 
            // txtBoxCodSocio
            // 
            this.txtBoxCodSocio.Location = new System.Drawing.Point(152, 32);
            this.txtBoxCodSocio.Name = "txtBoxCodSocio";
            this.txtBoxCodSocio.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodSocio.TabIndex = 3;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(152, 72);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(216, 20);
            this.txtBoxNombre.TabIndex = 4;
            // 
            // txtApe1
            // 
            this.txtApe1.Location = new System.Drawing.Point(152, 112);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(100, 20);
            this.txtApe1.TabIndex = 5;
            // 
            // txtApe2
            // 
            this.txtApe2.Location = new System.Drawing.Point(272, 112);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(96, 20);
            this.txtApe2.TabIndex = 6;
            // 
            // btnBuscar_Click
            // 
            this.btnBuscar_Click.Location = new System.Drawing.Point(80, 160);
            this.btnBuscar_Click.Name = "btnBuscar_Click";
            this.btnBuscar_Click.Size = new System.Drawing.Size(88, 32);
            this.btnBuscar_Click.TabIndex = 7;
            this.btnBuscar_Click.Text = "Buscar";
            this.btnBuscar_Click.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(256, 160);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(112, 32);
            this.btnMostrarTodos.TabIndex = 8;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 184);
            this.dataGridView1.TabIndex = 9;
            // 
            // BusquedaDeSociosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnBuscar_Click);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxCodSocio);
            this.Controls.Add(this.ApellidosSocioLabel);
            this.Controls.Add(this.NombreSocioLabel);
            this.Controls.Add(this.CodSocioLabel);
            this.Name = "BusquedaDeSociosForm";
            this.Text = "BusquedaDeSociosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodSocioLabel;
        private System.Windows.Forms.Label NombreSocioLabel;
        private System.Windows.Forms.Label ApellidosSocioLabel;
        private System.Windows.Forms.TextBox txtBoxCodSocio;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtApe1;
        private System.Windows.Forms.TextBox txtApe2;
        private System.Windows.Forms.Button btnBuscar_Click;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}