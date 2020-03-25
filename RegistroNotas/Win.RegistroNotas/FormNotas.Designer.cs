namespace Win.RegistroNotas
{
    partial class FormNotas
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label materiaIdLabel;
            System.Windows.Forms.Label promedioLabel;
            System.Windows.Forms.Label seccionIdLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotas));
            this.listaTransaccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTransaccionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listaTransaccionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.listaMateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaSeccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaIdComboBox = new System.Windows.Forms.ComboBox();
            this.seccionIdComboBox = new System.Windows.Forms.ComboBox();
            this.transaccionDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.transaccionDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            materiaIdLabel = new System.Windows.Forms.Label();
            promedioLabel = new System.Windows.Forms.Label();
            seccionIdLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaTransaccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTransaccionesBindingNavigator)).BeginInit();
            this.listaTransaccionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMateriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionDetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(12, 105);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 1;
            fechaLabel.Text = "Fecha:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 70);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // materiaIdLabel
            // 
            materiaIdLabel.AutoSize = true;
            materiaIdLabel.Location = new System.Drawing.Point(12, 135);
            materiaIdLabel.Name = "materiaIdLabel";
            materiaIdLabel.Size = new System.Drawing.Size(45, 13);
            materiaIdLabel.TabIndex = 5;
            materiaIdLabel.Text = "Materia:";
            // 
            // promedioLabel
            // 
            promedioLabel.AutoSize = true;
            promedioLabel.Location = new System.Drawing.Point(284, 418);
            promedioLabel.Name = "promedioLabel";
            promedioLabel.Size = new System.Drawing.Size(54, 13);
            promedioLabel.TabIndex = 9;
            promedioLabel.Text = "Promedio:";
            // 
            // seccionIdLabel
            // 
            seccionIdLabel.AutoSize = true;
            seccionIdLabel.Location = new System.Drawing.Point(12, 163);
            seccionIdLabel.Name = "seccionIdLabel";
            seccionIdLabel.Size = new System.Drawing.Size(49, 13);
            seccionIdLabel.TabIndex = 11;
            seccionIdLabel.Text = "Seccion:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(217, 74);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 16;
            activoLabel.Text = "Activo:";
            // 
            // listaTransaccionesBindingSource
            // 
            this.listaTransaccionesBindingSource.DataSource = typeof(BL.Registro.Transaccion);
            this.listaTransaccionesBindingSource.CurrentChanged += new System.EventHandler(this.listaTransaccionesBindingSource_CurrentChanged);
            // 
            // listaTransaccionesBindingNavigator
            // 
            this.listaTransaccionesBindingNavigator.AddNewItem = null;
            this.listaTransaccionesBindingNavigator.BindingSource = this.listaTransaccionesBindingSource;
            this.listaTransaccionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaTransaccionesBindingNavigator.DeleteItem = null;
            this.listaTransaccionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaTransaccionesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaTransaccionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaTransaccionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaTransaccionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaTransaccionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaTransaccionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaTransaccionesBindingNavigator.Name = "listaTransaccionesBindingNavigator";
            this.listaTransaccionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaTransaccionesBindingNavigator.Size = new System.Drawing.Size(571, 25);
            this.listaTransaccionesBindingNavigator.TabIndex = 0;
            this.listaTransaccionesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Text = "Anular";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaTransaccionesBindingNavigatorSaveItem
            // 
            this.listaTransaccionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaTransaccionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaTransaccionesBindingNavigatorSaveItem.Image")));
            this.listaTransaccionesBindingNavigatorSaveItem.Name = "listaTransaccionesBindingNavigatorSaveItem";
            this.listaTransaccionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaTransaccionesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaTransaccionesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaTransaccionesBindingNavigatorSaveItem_Click);
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
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaTransaccionesBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(79, 101);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTransaccionesBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "00000"));
            this.idTextBox.Location = new System.Drawing.Point(79, 67);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(53, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTransaccionesBindingSource, "Promedio", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.promedioTextBox.Location = new System.Drawing.Point(351, 415);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.ReadOnly = true;
            this.promedioTextBox.Size = new System.Drawing.Size(200, 20);
            this.promedioTextBox.TabIndex = 10;
            this.promedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listaMateriasBindingSource
            // 
            this.listaMateriasBindingSource.DataSource = typeof(BL.Registro.Materia);
            // 
            // listaSeccionesBindingSource
            // 
            this.listaSeccionesBindingSource.DataSource = typeof(BL.Registro.Seccion);
            // 
            // listaAlumnosBindingSource
            // 
            this.listaAlumnosBindingSource.DataSource = typeof(BL.Registro.AlumnosBL.Alumno);
            // 
            // materiaIdComboBox
            // 
            this.materiaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTransaccionesBindingSource, "MateriaId", true));
            this.materiaIdComboBox.DataSource = this.listaMateriasBindingSource;
            this.materiaIdComboBox.DisplayMember = "Descripcion";
            this.materiaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materiaIdComboBox.FormattingEnabled = true;
            this.materiaIdComboBox.Location = new System.Drawing.Point(79, 132);
            this.materiaIdComboBox.Name = "materiaIdComboBox";
            this.materiaIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.materiaIdComboBox.TabIndex = 13;
            this.materiaIdComboBox.ValueMember = "Id";
            // 
            // seccionIdComboBox
            // 
            this.seccionIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTransaccionesBindingSource, "SeccionId", true));
            this.seccionIdComboBox.DataSource = this.listaSeccionesBindingSource;
            this.seccionIdComboBox.DisplayMember = "Descripcion";
            this.seccionIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seccionIdComboBox.FormattingEnabled = true;
            this.seccionIdComboBox.Location = new System.Drawing.Point(79, 160);
            this.seccionIdComboBox.Name = "seccionIdComboBox";
            this.seccionIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.seccionIdComboBox.TabIndex = 14;
            this.seccionIdComboBox.ValueMember = "Id";
            // 
            // transaccionDetalleBindingSource
            // 
            this.transaccionDetalleBindingSource.AllowNew = false;
            this.transaccionDetalleBindingSource.DataMember = "TransaccionDetalle";
            this.transaccionDetalleBindingSource.DataSource = this.listaTransaccionesBindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(402, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(471, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // transaccionDetalleDataGridView
            // 
            this.transaccionDetalleDataGridView.AutoGenerateColumns = false;
            this.transaccionDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaccionDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.transaccionDetalleDataGridView.DataSource = this.transaccionDetalleBindingSource;
            this.transaccionDetalleDataGridView.Location = new System.Drawing.Point(12, 236);
            this.transaccionDetalleDataGridView.Name = "transaccionDetalleDataGridView";
            this.transaccionDetalleDataGridView.Size = new System.Drawing.Size(539, 165);
            this.transaccionDetalleDataGridView.TabIndex = 16;
            this.transaccionDetalleDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.transaccionDetalleDataGridView_CellEndEdit);
            this.transaccionDetalleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.transaccionDetalleDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AlumnoId";
            this.dataGridViewTextBoxColumn3.DataSource = this.listaAlumnosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Alumno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contador";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contador";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nota";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nota";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaTransaccionesBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(263, 69);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(16, 24);
            this.activoCheckBox.TabIndex = 17;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(443, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "ANULADO";
            this.label1.Visible = false;
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.transaccionDetalleDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seccionIdComboBox);
            this.Controls.Add(this.materiaIdComboBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(materiaIdLabel);
            this.Controls.Add(promedioLabel);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(seccionIdLabel);
            this.Controls.Add(this.listaTransaccionesBindingNavigator);
            this.Name = "FormNotas";
            this.Text = "Registro de notas";
            ((System.ComponentModel.ISupportInitialize)(this.listaTransaccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTransaccionesBindingNavigator)).EndInit();
            this.listaTransaccionesBindingNavigator.ResumeLayout(false);
            this.listaTransaccionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMateriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionDetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaTransaccionesBindingSource;
        private System.Windows.Forms.BindingNavigator listaTransaccionesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaTransaccionesBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.BindingSource listaMateriasBindingSource;
        private System.Windows.Forms.BindingSource listaSeccionesBindingSource;
        private System.Windows.Forms.BindingSource listaAlumnosBindingSource;
        private System.Windows.Forms.ComboBox materiaIdComboBox;
        private System.Windows.Forms.ComboBox seccionIdComboBox;
        private System.Windows.Forms.BindingSource transaccionDetalleBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView transaccionDetalleDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.Label label1;
    }
}