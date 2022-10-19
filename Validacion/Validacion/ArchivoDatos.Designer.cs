namespace Validacion
{
    partial class ArchivoDatos
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
            this.textoArchivo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textoArchivo
            // 
            this.textoArchivo.Location = new System.Drawing.Point(0, 0);
            this.textoArchivo.Name = "textoArchivo";
            this.textoArchivo.ReadOnly = true;
            this.textoArchivo.Size = new System.Drawing.Size(544, 280);
            this.textoArchivo.TabIndex = 0;
            this.textoArchivo.Text = "";
            // 
            // ArchivoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 281);
            this.Controls.Add(this.textoArchivo);
            this.Name = "ArchivoDatos";
            this.Text = "ArchivoDatos";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textoArchivo;
    }
}