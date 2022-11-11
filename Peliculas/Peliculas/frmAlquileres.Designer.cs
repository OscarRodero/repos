namespace Peliculas
{
    partial class frmAlquileres
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label codpeliLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label protagonistaLabel;
            System.Windows.Forms.Label argumentoLabel;
            System.Windows.Forms.Label estiloLabel;
            System.Windows.Forms.Label anioLabel;
            System.Windows.Forms.Label caratulaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label stockLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alqpeliculassociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoclubBinarioDataSet = new Peliculas.videoclubBinarioDataSet();
            this.alq_peliculas_sociosTableAdapter = new Peliculas.videoclubBinarioDataSetTableAdapters.alq_peliculas_sociosTableAdapter();
            this.codAlquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PagAlquilar = new System.Windows.Forms.TabPage();
            this.PagDevolver = new System.Windows.Forms.TabPage();
            this.txtCodCliente = new System.Windows.Forms.Label();
            this.txtBoxCodCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApe1 = new System.Windows.Forms.TextBox();
            this.txtBoxApe2 = new System.Windows.Forms.TextBox();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new Peliculas.videoclubBinarioDataSetTableAdapters.peliculasTableAdapter();
            this.tableAdapterManager = new Peliculas.videoclubBinarioDataSetTableAdapters.TableAdapterManager();
            this.codpeliLabel1 = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.protagonistaTextBox = new System.Windows.Forms.TextBox();
            this.argumentoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.caratulaPictureBox = new System.Windows.Forms.PictureBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            codpeliLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            protagonistaLabel = new System.Windows.Forms.Label();
            argumentoLabel = new System.Windows.Forms.Label();
            estiloLabel = new System.Windows.Forms.Label();
            anioLabel = new System.Windows.Forms.Label();
            caratulaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alqpeliculassociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoclubBinarioDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PagAlquilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAlquiler,
            this.tituloDataGridViewTextBoxColumn,
            this.fechaAlquilerDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alqpeliculassociosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 134);
            this.dataGridView1.TabIndex = 0;
            // 
            // alqpeliculassociosBindingSource
            // 
            this.alqpeliculassociosBindingSource.DataMember = "alq_peliculas_socios";
            this.alqpeliculassociosBindingSource.DataSource = this.videoclubBinarioDataSet;
            // 
            // videoclubBinarioDataSet
            // 
            this.videoclubBinarioDataSet.DataSetName = "videoclubBinarioDataSet";
            this.videoclubBinarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alq_peliculas_sociosTableAdapter
            // 
            this.alq_peliculas_sociosTableAdapter.ClearBeforeFill = true;
            // 
            // codAlquiler
            // 
            this.codAlquiler.DataPropertyName = "codAlquiler";
            this.codAlquiler.HeaderText = "codAlquiler";
            this.codAlquiler.Name = "codAlquiler";
            this.codAlquiler.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // fechaAlquilerDataGridViewTextBoxColumn
            // 
            this.fechaAlquilerDataGridViewTextBoxColumn.DataPropertyName = "FechaAlquiler";
            this.fechaAlquilerDataGridViewTextBoxColumn.HeaderText = "FechaAlquiler";
            this.fechaAlquilerDataGridViewTextBoxColumn.Name = "fechaAlquilerDataGridViewTextBoxColumn";
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagAlquilar);
            this.tabControl1.Controls.Add(this.PagDevolver);
            this.tabControl1.Location = new System.Drawing.Point(0, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 248);
            this.tabControl1.TabIndex = 1;
            // 
            // PagAlquilar
            // 
            this.PagAlquilar.AutoScroll = true;
            this.PagAlquilar.BackColor = System.Drawing.Color.LemonChiffon;
            this.PagAlquilar.Controls.Add(codpeliLabel);
            this.PagAlquilar.Controls.Add(this.codpeliLabel1);
            this.PagAlquilar.Controls.Add(tituloLabel);
            this.PagAlquilar.Controls.Add(this.tituloTextBox);
            this.PagAlquilar.Controls.Add(directorLabel);
            this.PagAlquilar.Controls.Add(this.directorTextBox);
            this.PagAlquilar.Controls.Add(protagonistaLabel);
            this.PagAlquilar.Controls.Add(this.protagonistaTextBox);
            this.PagAlquilar.Controls.Add(argumentoLabel);
            this.PagAlquilar.Controls.Add(this.argumentoRichTextBox);
            this.PagAlquilar.Controls.Add(estiloLabel);
            this.PagAlquilar.Controls.Add(this.estiloComboBox);
            this.PagAlquilar.Controls.Add(anioLabel);
            this.PagAlquilar.Controls.Add(this.anioTextBox);
            this.PagAlquilar.Controls.Add(caratulaLabel);
            this.PagAlquilar.Controls.Add(this.caratulaPictureBox);
            this.PagAlquilar.Controls.Add(categoriaLabel);
            this.PagAlquilar.Controls.Add(this.categoriaComboBox);
            this.PagAlquilar.Controls.Add(stockLabel);
            this.PagAlquilar.Controls.Add(this.stockNumericUpDown);
            this.PagAlquilar.Location = new System.Drawing.Point(4, 22);
            this.PagAlquilar.Name = "PagAlquilar";
            this.PagAlquilar.Padding = new System.Windows.Forms.Padding(3);
            this.PagAlquilar.Size = new System.Drawing.Size(656, 222);
            this.PagAlquilar.TabIndex = 0;
            this.PagAlquilar.Text = "Alquilar";
            // 
            // PagDevolver
            // 
            this.PagDevolver.Location = new System.Drawing.Point(4, 22);
            this.PagDevolver.Name = "PagDevolver";
            this.PagDevolver.Padding = new System.Windows.Forms.Padding(3);
            this.PagDevolver.Size = new System.Drawing.Size(656, 222);
            this.PagDevolver.TabIndex = 1;
            this.PagDevolver.Text = "Devolver";
            this.PagDevolver.UseVisualStyleBackColor = true;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.AutoSize = true;
            this.txtCodCliente.Location = new System.Drawing.Point(8, 16);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(67, 13);
            this.txtCodCliente.TabIndex = 2;
            this.txtCodCliente.Text = "Cod. Cliente:";
            // 
            // txtBoxCodCliente
            // 
            this.txtBoxCodCliente.Location = new System.Drawing.Point(80, 8);
            this.txtBoxCodCliente.Name = "txtBoxCodCliente";
            this.txtBoxCodCliente.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodCliente.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(192, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(240, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(47, 13);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Nombre:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(288, 8);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 6;
            // 
            // txtBoxApe1
            // 
            this.txtBoxApe1.Location = new System.Drawing.Point(288, 40);
            this.txtBoxApe1.Name = "txtBoxApe1";
            this.txtBoxApe1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApe1.TabIndex = 7;
            // 
            // txtBoxApe2
            // 
            this.txtBoxApe2.Location = new System.Drawing.Point(400, 40);
            this.txtBoxApe2.Name = "txtBoxApe2";
            this.txtBoxApe2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApe2.TabIndex = 8;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.videoclubBinarioDataSet;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alquileresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.estilosTableAdapter = null;
            this.tableAdapterManager.peliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Peliculas.videoclubBinarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codpeliLabel
            // 
            codpeliLabel.AutoSize = true;
            codpeliLabel.Location = new System.Drawing.Point(28, 10);
            codpeliLabel.Name = "codpeliLabel";
            codpeliLabel.Size = new System.Drawing.Size(44, 13);
            codpeliLabel.TabIndex = 0;
            codpeliLabel.Text = "codpeli:";
            // 
            // codpeliLabel1
            // 
            this.codpeliLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "codpeli", true));
            this.codpeliLabel1.Location = new System.Drawing.Point(108, 10);
            this.codpeliLabel1.Name = "codpeliLabel1";
            this.codpeliLabel1.Size = new System.Drawing.Size(36, 23);
            this.codpeliLabel1.TabIndex = 1;
            this.codpeliLabel1.Text = "label1";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(28, 39);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(32, 13);
            tituloLabel.TabIndex = 2;
            tituloLabel.Text = "titulo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(108, 36);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(388, 20);
            this.tituloTextBox.TabIndex = 3;
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(28, 65);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(45, 13);
            directorLabel.TabIndex = 4;
            directorLabel.Text = "director:";
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "director", true));
            this.directorTextBox.Location = new System.Drawing.Point(108, 62);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(388, 20);
            this.directorTextBox.TabIndex = 5;
            // 
            // protagonistaLabel
            // 
            protagonistaLabel.AutoSize = true;
            protagonistaLabel.Location = new System.Drawing.Point(28, 91);
            protagonistaLabel.Name = "protagonistaLabel";
            protagonistaLabel.Size = new System.Drawing.Size(68, 13);
            protagonistaLabel.TabIndex = 6;
            protagonistaLabel.Text = "protagonista:";
            // 
            // protagonistaTextBox
            // 
            this.protagonistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "protagonista", true));
            this.protagonistaTextBox.Location = new System.Drawing.Point(108, 88);
            this.protagonistaTextBox.Name = "protagonistaTextBox";
            this.protagonistaTextBox.Size = new System.Drawing.Size(388, 20);
            this.protagonistaTextBox.TabIndex = 7;
            // 
            // argumentoLabel
            // 
            argumentoLabel.AutoSize = true;
            argumentoLabel.Location = new System.Drawing.Point(32, 155);
            argumentoLabel.Name = "argumentoLabel";
            argumentoLabel.Size = new System.Drawing.Size(60, 13);
            argumentoLabel.TabIndex = 8;
            argumentoLabel.Text = "argumento:";
            // 
            // argumentoRichTextBox
            // 
            this.argumentoRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "argumento", true));
            this.argumentoRichTextBox.Location = new System.Drawing.Point(112, 152);
            this.argumentoRichTextBox.Name = "argumentoRichTextBox";
            this.argumentoRichTextBox.Size = new System.Drawing.Size(384, 48);
            this.argumentoRichTextBox.TabIndex = 9;
            this.argumentoRichTextBox.Text = "";
            // 
            // estiloLabel
            // 
            estiloLabel.AutoSize = true;
            estiloLabel.Location = new System.Drawing.Point(128, 128);
            estiloLabel.Name = "estiloLabel";
            estiloLabel.Size = new System.Drawing.Size(34, 13);
            estiloLabel.TabIndex = 10;
            estiloLabel.Text = "estilo:";
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "estilo", true));
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Location = new System.Drawing.Point(176, 120);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(121, 21);
            this.estiloComboBox.TabIndex = 11;
            // 
            // anioLabel
            // 
            anioLabel.AutoSize = true;
            anioLabel.Location = new System.Drawing.Point(280, 8);
            anioLabel.Name = "anioLabel";
            anioLabel.Size = new System.Drawing.Size(30, 13);
            anioLabel.TabIndex = 12;
            anioLabel.Text = "anio:";
            // 
            // anioTextBox
            // 
            this.anioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "anio", true));
            this.anioTextBox.Location = new System.Drawing.Point(320, 8);
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(72, 20);
            this.anioTextBox.TabIndex = 13;
            // 
            // caratulaLabel
            // 
            caratulaLabel.AutoSize = true;
            caratulaLabel.Location = new System.Drawing.Point(512, 8);
            caratulaLabel.Name = "caratulaLabel";
            caratulaLabel.Size = new System.Drawing.Size(48, 13);
            caratulaLabel.TabIndex = 14;
            caratulaLabel.Text = "caratula:";
            // 
            // caratulaPictureBox
            // 
            this.caratulaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.peliculasBindingSource, "caratula", true));
            this.caratulaPictureBox.Location = new System.Drawing.Point(512, 24);
            this.caratulaPictureBox.Name = "caratulaPictureBox";
            this.caratulaPictureBox.Size = new System.Drawing.Size(121, 176);
            this.caratulaPictureBox.TabIndex = 15;
            this.caratulaPictureBox.TabStop = false;
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(312, 128);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(54, 13);
            categoriaLabel.TabIndex = 16;
            categoriaLabel.Text = "categoria:";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "categoria", true));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(376, 120);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriaComboBox.TabIndex = 17;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(400, 8);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(36, 13);
            stockLabel.TabIndex = 18;
            stockLabel.Text = "stock:";
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peliculasBindingSource, "stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(440, 8);
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.stockNumericUpDown.TabIndex = 19;
            // 
            // frmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 448);
            this.Controls.Add(this.txtBoxApe2);
            this.Controls.Add(this.txtBoxApe1);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxCodCliente);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAlquileres";
            this.Text = "frmAlquileres";
            this.Load += new System.EventHandler(this.frmAlquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alqpeliculassociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoclubBinarioDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PagAlquilar.ResumeLayout(false);
            this.PagAlquilar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private videoclubBinarioDataSet videoclubBinarioDataSet;
        private System.Windows.Forms.BindingSource alqpeliculassociosBindingSource;
        private videoclubBinarioDataSetTableAdapters.alq_peliculas_sociosTableAdapter alq_peliculas_sociosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PagAlquilar;
        private System.Windows.Forms.TabPage PagDevolver;
        private System.Windows.Forms.Label txtCodCliente;
        private System.Windows.Forms.TextBox txtBoxCodCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApe1;
        private System.Windows.Forms.TextBox txtBoxApe2;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private videoclubBinarioDataSetTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private videoclubBinarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label codpeliLabel1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox protagonistaTextBox;
        private System.Windows.Forms.RichTextBox argumentoRichTextBox;
        private System.Windows.Forms.ComboBox estiloComboBox;
        private System.Windows.Forms.TextBox anioTextBox;
        private System.Windows.Forms.PictureBox caratulaPictureBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
    }
}