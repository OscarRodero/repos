namespace Horario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lbModulos = new System.Windows.Forms.ListBox();
            this.lbListaCiclo = new System.Windows.Forms.ListBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.labelModulos = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelCiclo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbHorario.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.cbDia);
            this.gbHorario.Controls.Add(this.cbHora);
            this.gbHorario.Controls.Add(this.labelDia);
            this.gbHorario.Controls.Add(this.labelHora);
            this.gbHorario.Location = new System.Drawing.Point(16, 200);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(200, 100);
            this.gbHorario.TabIndex = 1;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Horario";
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Location = new System.Drawing.Point(64, 56);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 3;
            // 
            // cbHora
            // 
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Location = new System.Drawing.Point(64, 24);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(121, 21);
            this.cbHora.TabIndex = 2;
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(24, 64);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(28, 13);
            this.labelDia.TabIndex = 1;
            this.labelDia.Text = "Día:";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(24, 32);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(33, 13);
            this.labelHora.TabIndex = 0;
            this.labelHora.Text = "Hora:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 40);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Horario";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(16, 360);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(200, 40);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar Horario";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lbModulos);
            this.gbDatos.Controls.Add(this.lbListaCiclo);
            this.gbDatos.Controls.Add(this.cbCurso);
            this.gbDatos.Controls.Add(this.labelModulos);
            this.gbDatos.Controls.Add(this.labelCurso);
            this.gbDatos.Controls.Add(this.labelCiclo);
            this.gbDatos.Location = new System.Drawing.Point(232, 208);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(536, 192);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Curso";
            // 
            // lbModulos
            // 
            this.lbModulos.FormattingEnabled = true;
            this.lbModulos.Location = new System.Drawing.Point(272, 88);
            this.lbModulos.Name = "lbModulos";
            this.lbModulos.Size = new System.Drawing.Size(224, 95);
            this.lbModulos.TabIndex = 5;
            // 
            // lbListaCiclo
            // 
            this.lbListaCiclo.FormattingEnabled = true;
            this.lbListaCiclo.Location = new System.Drawing.Point(56, 48);
            this.lbListaCiclo.Name = "lbListaCiclo";
            this.lbListaCiclo.Size = new System.Drawing.Size(120, 134);
            this.lbListaCiclo.TabIndex = 4;
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(320, 32);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(176, 21);
            this.cbCurso.TabIndex = 3;
            // 
            // labelModulos
            // 
            this.labelModulos.AutoSize = true;
            this.labelModulos.Location = new System.Drawing.Point(272, 64);
            this.labelModulos.Name = "labelModulos";
            this.labelModulos.Size = new System.Drawing.Size(50, 13);
            this.labelModulos.TabIndex = 2;
            this.labelModulos.Text = "Módulos:";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(272, 40);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(37, 13);
            this.labelCurso.TabIndex = 1;
            this.labelCurso.Text = "Curso:";
            // 
            // labelCiclo
            // 
            this.labelCiclo.AutoSize = true;
            this.labelCiclo.Location = new System.Drawing.Point(56, 24);
            this.labelCiclo.Name = "labelCiclo";
            this.labelCiclo.Size = new System.Drawing.Size(33, 13);
            this.labelCiclo.TabIndex = 0;
            this.labelCiclo.Text = "Ciclo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbHorario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ListBox lbModulos;
        private System.Windows.Forms.ListBox lbListaCiclo;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label labelModulos;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelCiclo;
    }
}

