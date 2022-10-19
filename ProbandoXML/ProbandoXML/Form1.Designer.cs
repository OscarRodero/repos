namespace ProbandoXML
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CajaTexto = new System.Windows.Forms.RichTextBox();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btnLeerXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // CajaTexto
            // 
            this.CajaTexto.Location = new System.Drawing.Point(8, 232);
            this.CajaTexto.Name = "CajaTexto";
            this.CajaTexto.Size = new System.Drawing.Size(776, 216);
            this.CajaTexto.TabIndex = 0;
            this.CajaTexto.Text = "";
            // 
            // Tabla
            // 
            this.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tabla.Location = new System.Drawing.Point(8, 8);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowTemplate.Height = 25;
            this.Tabla.Size = new System.Drawing.Size(776, 216);
            this.Tabla.TabIndex = 1;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.Location = new System.Drawing.Point(16, 456);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(152, 48);
            this.btnLeerXML.TabIndex = 2;
            this.btnLeerXML.Text = "Leer XML";
            this.btnLeerXML.UseVisualStyleBackColor = true;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnLeerXML);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.CajaTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox CajaTexto;
        private DataGridView Tabla;
        private OpenFileDialog OFD;
        private Button btnLeerXML;
    }
}