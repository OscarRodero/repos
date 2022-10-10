namespace ExpresionesRegulares
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntComprobar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(440, 120);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(172, 23);
            this.txtTexto.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expresión Regular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto:";
            // 
            // bntComprobar
            // 
            this.bntComprobar.Location = new System.Drawing.Point(464, 240);
            this.bntComprobar.Name = "bntComprobar";
            this.bntComprobar.Size = new System.Drawing.Size(112, 23);
            this.bntComprobar.TabIndex = 4;
            this.bntComprobar.Text = "Comprobar";
            this.bntComprobar.UseVisualStyleBackColor = true;
            this.bntComprobar.Click += new System.EventHandler(this.bntComprobar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRINCIPAL";
            // 
            // PB1
            // 
            this.PB1.Image = global::ExpresionesRegulares.Properties.Resources.png_transparent_red_x_logo_jingjinji_check_mark_error_red_error_angle_color_brush;
            this.PB1.InitialImage = global::ExpresionesRegulares.Properties.Resources.png_transparent_red_x_logo_jingjinji_check_mark_error_red_error_angle_color_brush;
            this.PB1.Location = new System.Drawing.Point(56, 104);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(192, 176);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 6;
            this.PB1.TabStop = false;
            // 
            // ListaImagenes
            // 
            this.ListaImagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
            this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenes.Images.SetKeyName(0, "png-clipart-check-mark-computer-icons-button-angle-leaf.png");
            this.ListaImagenes.Images.SetKeyName(1, "png-transparent-red-x-logo-jingjinji-check-mark-error-red-error-angle-color-brush" +
        ".png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntComprobar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTexto;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button bntComprobar;
        private Label label3;
        private PictureBox PB1;
        private ImageList ListaImagenes;
    }
}