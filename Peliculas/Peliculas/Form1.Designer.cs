namespace Peliculas
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
            this.components = new System.ComponentModel.Container();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.videoclubDataSet = new Peliculas.videoclubDataSet();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new Peliculas.videoclubDataSetTableAdapters.peliculasTableAdapter();
            this.tableAdapterManager = new Peliculas.videoclubDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.peliculasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.peliculasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.cmbPelisTitulo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.codpeliLabel1 = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.protagonistaTextBox = new System.Windows.Forms.TextBox();
            this.argumentoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.caratulaPictureBox = new System.Windows.Forms.PictureBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCambiaCaratula = new System.Windows.Forms.Button();
            this.categoriasTableAdapter = new Peliculas.videoclubDataSetTableAdapters.categoriasTableAdapter();
            this.alquileresTableAdapter = new Peliculas.videoclubDataSetTableAdapters.alquileresTableAdapter();
            this.videoclubDataSet1 = new Peliculas.videoclubDataSet();
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
            ((System.ComponentModel.ISupportInitialize)(this.videoclubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingNavigator)).BeginInit();
            this.peliculasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoclubDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // codpeliLabel
            // 
            codpeliLabel.AutoSize = true;
            codpeliLabel.Location = new System.Drawing.Point(16, 32);
            codpeliLabel.Name = "codpeliLabel";
            codpeliLabel.Size = new System.Drawing.Size(44, 13);
            codpeliLabel.TabIndex = 1;
            codpeliLabel.Text = "codpeli:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(16, 61);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(32, 13);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "titulo:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(16, 87);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(45, 13);
            directorLabel.TabIndex = 5;
            directorLabel.Text = "director:";
            // 
            // protagonistaLabel
            // 
            protagonistaLabel.AutoSize = true;
            protagonistaLabel.Location = new System.Drawing.Point(16, 113);
            protagonistaLabel.Name = "protagonistaLabel";
            protagonistaLabel.Size = new System.Drawing.Size(68, 13);
            protagonistaLabel.TabIndex = 7;
            protagonistaLabel.Text = "protagonista:";
            // 
            // argumentoLabel
            // 
            argumentoLabel.AutoSize = true;
            argumentoLabel.Location = new System.Drawing.Point(16, 139);
            argumentoLabel.Name = "argumentoLabel";
            argumentoLabel.Size = new System.Drawing.Size(60, 13);
            argumentoLabel.TabIndex = 9;
            argumentoLabel.Text = "argumento:";
            // 
            // estiloLabel
            // 
            estiloLabel.AutoSize = true;
            estiloLabel.Location = new System.Drawing.Point(16, 320);
            estiloLabel.Name = "estiloLabel";
            estiloLabel.Size = new System.Drawing.Size(34, 13);
            estiloLabel.TabIndex = 11;
            estiloLabel.Text = "estilo:";
            // 
            // anioLabel
            // 
            anioLabel.AutoSize = true;
            anioLabel.Location = new System.Drawing.Point(544, 48);
            anioLabel.Name = "anioLabel";
            anioLabel.Size = new System.Drawing.Size(28, 13);
            anioLabel.TabIndex = 13;
            anioLabel.Text = "año:";
            // 
            // caratulaLabel
            // 
            caratulaLabel.AutoSize = true;
            caratulaLabel.Location = new System.Drawing.Point(544, 88);
            caratulaLabel.Name = "caratulaLabel";
            caratulaLabel.Size = new System.Drawing.Size(48, 13);
            caratulaLabel.TabIndex = 15;
            caratulaLabel.Text = "caratula:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(16, 350);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(54, 13);
            categoriaLabel.TabIndex = 17;
            categoriaLabel.Text = "categoria:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(400, 352);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(36, 13);
            stockLabel.TabIndex = 19;
            stockLabel.Text = "stock:";
            // 
            // videoclubDataSet
            // 
            this.videoclubDataSet.DataSetName = "videoclubDataSet";
            this.videoclubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.videoclubDataSet;
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
            this.tableAdapterManager.UpdateOrder = Peliculas.videoclubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // peliculasBindingNavigatorSaveItem
            // 
            this.peliculasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peliculasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peliculasBindingNavigatorSaveItem.Image")));
            this.peliculasBindingNavigatorSaveItem.Name = "peliculasBindingNavigatorSaveItem";
            this.peliculasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.peliculasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.peliculasBindingNavigatorSaveItem.Click += new System.EventHandler(this.peliculasBindingNavigatorSaveItem_Click);
            // 
            // peliculasBindingNavigator
            // 
            this.peliculasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peliculasBindingNavigator.BindingSource = this.peliculasBindingSource;
            this.peliculasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peliculasBindingNavigator.DeleteItem = null;
            this.peliculasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.peliculasBindingNavigatorSaveItem,
            this.cmbPelisTitulo,
            this.toolStripButton1});
            this.peliculasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peliculasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.peliculasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.peliculasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peliculasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peliculasBindingNavigator.Name = "peliculasBindingNavigator";
            this.peliculasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peliculasBindingNavigator.Size = new System.Drawing.Size(716, 25);
            this.peliculasBindingNavigator.TabIndex = 0;
            this.peliculasBindingNavigator.Text = "bindingNavigator1";
            // 
            // cmbPelisTitulo
            // 
            this.cmbPelisTitulo.Name = "cmbPelisTitulo";
            this.cmbPelisTitulo.Size = new System.Drawing.Size(121, 25);
            this.cmbPelisTitulo.SelectedIndexChanged += new System.EventHandler(this.cmbPelisTitulo_SelectedIndexChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton1.Text = "Mostrar Todas";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // codpeliLabel1
            // 
            this.codpeliLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "codpeli", true));
            this.codpeliLabel1.Location = new System.Drawing.Point(96, 32);
            this.codpeliLabel1.Name = "codpeliLabel1";
            this.codpeliLabel1.Size = new System.Drawing.Size(121, 23);
            this.codpeliLabel1.TabIndex = 2;
            this.codpeliLabel1.Text = "label1";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(96, 58);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(416, 20);
            this.tituloTextBox.TabIndex = 4;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "director", true));
            this.directorTextBox.Location = new System.Drawing.Point(96, 84);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(416, 20);
            this.directorTextBox.TabIndex = 6;
            // 
            // protagonistaTextBox
            // 
            this.protagonistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "protagonista", true));
            this.protagonistaTextBox.Location = new System.Drawing.Point(96, 110);
            this.protagonistaTextBox.Name = "protagonistaTextBox";
            this.protagonistaTextBox.Size = new System.Drawing.Size(416, 20);
            this.protagonistaTextBox.TabIndex = 8;
            // 
            // argumentoRichTextBox
            // 
            this.argumentoRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "argumento", true));
            this.argumentoRichTextBox.Location = new System.Drawing.Point(96, 136);
            this.argumentoRichTextBox.Name = "argumentoRichTextBox";
            this.argumentoRichTextBox.Size = new System.Drawing.Size(416, 176);
            this.argumentoRichTextBox.TabIndex = 10;
            this.argumentoRichTextBox.Text = "";
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.peliculasBindingSource, "estilo", true));
            this.estiloComboBox.DataSource = this.peliculasBindingSource;
            this.estiloComboBox.DisplayMember = "estilo";
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Location = new System.Drawing.Point(96, 317);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(232, 21);
            this.estiloComboBox.TabIndex = 12;
            this.estiloComboBox.ValueMember = "estilo";
            // 
            // anioTextBox
            // 
            this.anioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "anio", true));
            this.anioTextBox.Location = new System.Drawing.Point(576, 40);
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(112, 20);
            this.anioTextBox.TabIndex = 14;
            // 
            // caratulaPictureBox
            // 
            this.caratulaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.peliculasBindingSource, "caratula", true));
            this.caratulaPictureBox.Location = new System.Drawing.Point(544, 104);
            this.caratulaPictureBox.Name = "caratulaPictureBox";
            this.caratulaPictureBox.Size = new System.Drawing.Size(144, 168);
            this.caratulaPictureBox.TabIndex = 16;
            this.caratulaPictureBox.TabStop = false;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.peliculasBindingSource, "categoria", true));
            this.categoriaComboBox.DataSource = this.categoriasBindingSource;
            this.categoriaComboBox.DisplayMember = "categoria";
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(96, 347);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(232, 21);
            this.categoriaComboBox.TabIndex = 18;
            this.categoriaComboBox.ValueMember = "categoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.videoclubDataSet;
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peliculasBindingSource, "stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(440, 344);
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.stockNumericUpDown.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Archivos de imagen\" | *.jpg;*.jpeg;*.png";
            // 
            // btnCambiaCaratula
            // 
            this.btnCambiaCaratula.Location = new System.Drawing.Point(544, 280);
            this.btnCambiaCaratula.Name = "btnCambiaCaratula";
            this.btnCambiaCaratula.Size = new System.Drawing.Size(144, 32);
            this.btnCambiaCaratula.TabIndex = 21;
            this.btnCambiaCaratula.Text = "Nueva Carátula";
            this.btnCambiaCaratula.UseVisualStyleBackColor = true;
            this.btnCambiaCaratula.Click += new System.EventHandler(this.btnCambiaCaratula_Click);
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // alquileresTableAdapter
            // 
            this.alquileresTableAdapter.ClearBeforeFill = true;
            // 
            // videoclubDataSet1
            // 
            this.videoclubDataSet1.DataSetName = "videoclubDataSet";
            this.videoclubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 385);
            this.Controls.Add(this.btnCambiaCaratula);
            this.Controls.Add(codpeliLabel);
            this.Controls.Add(this.codpeliLabel1);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(protagonistaLabel);
            this.Controls.Add(this.protagonistaTextBox);
            this.Controls.Add(argumentoLabel);
            this.Controls.Add(this.argumentoRichTextBox);
            this.Controls.Add(estiloLabel);
            this.Controls.Add(this.estiloComboBox);
            this.Controls.Add(anioLabel);
            this.Controls.Add(this.anioTextBox);
            this.Controls.Add(caratulaLabel);
            this.Controls.Add(this.caratulaPictureBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockNumericUpDown);
            this.Controls.Add(this.peliculasBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoclubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingNavigator)).EndInit();
            this.peliculasBindingNavigator.ResumeLayout(false);
            this.peliculasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoclubDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private videoclubDataSet videoclubDataSet;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private videoclubDataSetTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private videoclubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton peliculasBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator peliculasBindingNavigator;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCambiaCaratula;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private videoclubDataSetTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.ToolStripComboBox cmbPelisTitulo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private videoclubDataSetTableAdapters.alquileresTableAdapter alquileresTableAdapter;
        private videoclubDataSet videoclubDataSet1;
    }
}

