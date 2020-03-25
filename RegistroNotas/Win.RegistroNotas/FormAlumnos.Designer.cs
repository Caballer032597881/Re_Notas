namespace Win.RegistroNotas
{
    partial class FormAlumnos
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label anioLabel;
            System.Windows.Forms.Label numeroIdentidadLabel;
            System.Windows.Forms.Label materiaIdLabel;
            System.Windows.Forms.Label seccionIdLabel;
            System.Windows.Forms.Label carreraIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnos));
            System.Windows.Forms.Label notaLabel;
            this.listaAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaAlumnosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaAlumnosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.numeroIdentidadTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaMateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaSeccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaIdComboBox = new System.Windows.Forms.ComboBox();
            this.seccionIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaCarrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carreraIdComboBox = new System.Windows.Forms.ComboBox();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            anioLabel = new System.Windows.Forms.Label();
            numeroIdentidadLabel = new System.Windows.Forms.Label();
            materiaIdLabel = new System.Windows.Forms.Label();
            seccionIdLabel = new System.Windows.Forms.Label();
            carreraIdLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingNavigator)).BeginInit();
            this.listaAlumnosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMateriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCarrerasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 79);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // anioLabel
            // 
            anioLabel.AutoSize = true;
            anioLabel.Location = new System.Drawing.Point(12, 247);
            anioLabel.Name = "anioLabel";
            anioLabel.Size = new System.Drawing.Size(29, 13);
            anioLabel.TabIndex = 9;
            anioLabel.Text = "Año:";
            // 
            // numeroIdentidadLabel
            // 
            numeroIdentidadLabel.AutoSize = true;
            numeroIdentidadLabel.Location = new System.Drawing.Point(12, 106);
            numeroIdentidadLabel.Name = "numeroIdentidadLabel";
            numeroIdentidadLabel.Size = new System.Drawing.Size(108, 13);
            numeroIdentidadLabel.TabIndex = 9;
            numeroIdentidadLabel.Text = "Numero de identidad:";
            // 
            // materiaIdLabel
            // 
            materiaIdLabel.AutoSize = true;
            materiaIdLabel.Location = new System.Drawing.Point(12, 162);
            materiaIdLabel.Name = "materiaIdLabel";
            materiaIdLabel.Size = new System.Drawing.Size(45, 13);
            materiaIdLabel.TabIndex = 14;
            materiaIdLabel.Text = "Materia:";
            // 
            // seccionIdLabel
            // 
            seccionIdLabel.AutoSize = true;
            seccionIdLabel.Location = new System.Drawing.Point(12, 192);
            seccionIdLabel.Name = "seccionIdLabel";
            seccionIdLabel.Size = new System.Drawing.Size(49, 13);
            seccionIdLabel.TabIndex = 16;
            seccionIdLabel.Text = "Seccion:";
            // 
            // carreraIdLabel
            // 
            carreraIdLabel.AutoSize = true;
            carreraIdLabel.Location = new System.Drawing.Point(12, 135);
            carreraIdLabel.Name = "carreraIdLabel";
            carreraIdLabel.Size = new System.Drawing.Size(44, 13);
            carreraIdLabel.TabIndex = 17;
            carreraIdLabel.Text = "Carrera:";
            // 
            // listaAlumnosBindingSource
            // 
            this.listaAlumnosBindingSource.DataSource = typeof(BL.Registro.AlumnosBL.Alumno);
            // 
            // listaAlumnosBindingNavigator
            // 
            this.listaAlumnosBindingNavigator.AddNewItem = null;
            this.listaAlumnosBindingNavigator.BindingSource = this.listaAlumnosBindingSource;
            this.listaAlumnosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaAlumnosBindingNavigator.DeleteItem = null;
            this.listaAlumnosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaAlumnosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaAlumnosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaAlumnosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaAlumnosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaAlumnosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaAlumnosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaAlumnosBindingNavigator.Name = "listaAlumnosBindingNavigator";
            this.listaAlumnosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaAlumnosBindingNavigator.Size = new System.Drawing.Size(670, 25);
            this.listaAlumnosBindingNavigator.TabIndex = 0;
            this.listaAlumnosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // listaAlumnosBindingNavigatorSaveItem
            // 
            this.listaAlumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaAlumnosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaAlumnosBindingNavigatorSaveItem.Image")));
            this.listaAlumnosBindingNavigatorSaveItem.Name = "listaAlumnosBindingNavigatorSaveItem";
            this.listaAlumnosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaAlumnosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaAlumnosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaAlumnosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(123, 50);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(252, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(123, 76);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(252, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.Tag = "1";
            // 
            // anioTextBox
            // 
            this.anioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "Anio", true));
            this.anioTextBox.Location = new System.Drawing.Point(123, 244);
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(252, 20);
            this.anioTextBox.TabIndex = 4;
            this.anioTextBox.Tag = "4";
            // 
            // numeroIdentidadTextBox
            // 
            this.numeroIdentidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "NumeroIdentidad", true));
            this.numeroIdentidadTextBox.Location = new System.Drawing.Point(123, 103);
            this.numeroIdentidadTextBox.Name = "numeroIdentidadTextBox";
            this.numeroIdentidadTextBox.Size = new System.Drawing.Size(252, 20);
            this.numeroIdentidadTextBox.TabIndex = 2;
            this.numeroIdentidadTextBox.Tag = "2";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaAlumnosBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(415, 50);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(190, 125);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 12;
            this.fotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png | * .jpg; *.png";
            // 
            // listaMateriasBindingSource
            // 
            this.listaMateriasBindingSource.DataSource = typeof(BL.Registro.Materia);
            // 
            // listaSeccionesBindingSource
            // 
            this.listaSeccionesBindingSource.DataSource = typeof(BL.Registro.Seccion);
            // 
            // materiaIdComboBox
            // 
            this.materiaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaAlumnosBindingSource, "MateriaId", true));
            this.materiaIdComboBox.DataSource = this.listaMateriasBindingSource;
            this.materiaIdComboBox.DisplayMember = "Descripcion";
            this.materiaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materiaIdComboBox.FormattingEnabled = true;
            this.materiaIdComboBox.Location = new System.Drawing.Point(123, 159);
            this.materiaIdComboBox.Name = "materiaIdComboBox";
            this.materiaIdComboBox.Size = new System.Drawing.Size(252, 21);
            this.materiaIdComboBox.TabIndex = 15;
            this.materiaIdComboBox.ValueMember = "Id";
            // 
            // seccionIdComboBox
            // 
            this.seccionIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaAlumnosBindingSource, "SeccionId", true));
            this.seccionIdComboBox.DataSource = this.listaSeccionesBindingSource;
            this.seccionIdComboBox.DisplayMember = "Descripcion";
            this.seccionIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seccionIdComboBox.FormattingEnabled = true;
            this.seccionIdComboBox.Location = new System.Drawing.Point(123, 189);
            this.seccionIdComboBox.Name = "seccionIdComboBox";
            this.seccionIdComboBox.Size = new System.Drawing.Size(252, 21);
            this.seccionIdComboBox.TabIndex = 17;
            this.seccionIdComboBox.ValueMember = "Id";
            // 
            // listaCarrerasBindingSource
            // 
            this.listaCarrerasBindingSource.DataSource = typeof(BL.Registro.Carrera);
            // 
            // carreraIdComboBox
            // 
            this.carreraIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaAlumnosBindingSource, "CarreraId", true));
            this.carreraIdComboBox.DataSource = this.listaCarrerasBindingSource;
            this.carreraIdComboBox.DisplayMember = "Descripcion";
            this.carreraIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carreraIdComboBox.FormattingEnabled = true;
            this.carreraIdComboBox.Location = new System.Drawing.Point(123, 129);
            this.carreraIdComboBox.Name = "carreraIdComboBox";
            this.carreraIdComboBox.Size = new System.Drawing.Size(252, 21);
            this.carreraIdComboBox.TabIndex = 18;
            this.carreraIdComboBox.ValueMember = "Id";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new System.Drawing.Point(12, 225);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(33, 13);
            notaLabel.TabIndex = 18;
            notaLabel.Text = "Nota:";
            // 
            // notaTextBox
            // 
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAlumnosBindingSource, "Nota", true));
            this.notaTextBox.Location = new System.Drawing.Point(123, 218);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(252, 20);
            this.notaTextBox.TabIndex = 19;
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 301);
            this.Controls.Add(notaLabel);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(carreraIdLabel);
            this.Controls.Add(this.carreraIdComboBox);
            this.Controls.Add(seccionIdLabel);
            this.Controls.Add(this.seccionIdComboBox);
            this.Controls.Add(materiaIdLabel);
            this.Controls.Add(this.materiaIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(numeroIdentidadLabel);
            this.Controls.Add(this.numeroIdentidadTextBox);
            this.Controls.Add(anioLabel);
            this.Controls.Add(this.anioTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaAlumnosBindingNavigator);
            this.Name = "FormAlumnos";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingNavigator)).EndInit();
            this.listaAlumnosBindingNavigator.ResumeLayout(false);
            this.listaAlumnosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMateriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCarrerasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaAlumnosBindingSource;
        private System.Windows.Forms.BindingNavigator listaAlumnosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaAlumnosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.TextBox numeroIdentidadTextBox;
        public System.Windows.Forms.TextBox anioTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaMateriasBindingSource;
        private System.Windows.Forms.BindingSource listaSeccionesBindingSource;
        private System.Windows.Forms.ComboBox materiaIdComboBox;
        private System.Windows.Forms.ComboBox seccionIdComboBox;
        private System.Windows.Forms.BindingSource listaCarrerasBindingSource;
        private System.Windows.Forms.ComboBox carreraIdComboBox;
        private System.Windows.Forms.TextBox notaTextBox;
    }
}