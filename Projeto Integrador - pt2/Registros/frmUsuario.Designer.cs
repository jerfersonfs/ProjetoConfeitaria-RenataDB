﻿namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmUsuario
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
            System.Windows.Forms.Label id_usuLabel;
            System.Windows.Forms.Label nome_usuLabel;
            System.Windows.Forms.Label senha_usuLabel;
            System.Windows.Forms.Label celular_usuLabel;
            System.Windows.Forms.Label telefone_usuLabel;
            System.Windows.Forms.Label email_usuLabel;
            System.Windows.Forms.Label data_cadastroLabel;
            System.Windows.Forms.Label fKid_clienteLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_usuTextBox = new System.Windows.Forms.TextBox();
            this.nome_usuTextBox = new System.Windows.Forms.TextBox();
            this.senha_usuTextBox = new System.Windows.Forms.TextBox();
            this.celular_usuTextBox = new System.Windows.Forms.TextBox();
            this.telefone_usuTextBox = new System.Windows.Forms.TextBox();
            this.email_usuTextBox = new System.Windows.Forms.TextBox();
            this.data_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fKid_clienteTextBox = new System.Windows.Forms.TextBox();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.repitasenhatxtBox = new System.Windows.Forms.TextBox();
            id_usuLabel = new System.Windows.Forms.Label();
            nome_usuLabel = new System.Windows.Forms.Label();
            senha_usuLabel = new System.Windows.Forms.Label();
            celular_usuLabel = new System.Windows.Forms.Label();
            telefone_usuLabel = new System.Windows.Forms.Label();
            email_usuLabel = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            fKid_clienteLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_usuLabel
            // 
            id_usuLabel.AutoSize = true;
            id_usuLabel.Location = new System.Drawing.Point(32, 165);
            id_usuLabel.Name = "id_usuLabel";
            id_usuLabel.Size = new System.Drawing.Size(43, 13);
            id_usuLabel.TabIndex = 1;
            id_usuLabel.Text = "Código:";
            id_usuLabel.Click += new System.EventHandler(this.id_usuLabel_Click);
            // 
            // nome_usuLabel
            // 
            nome_usuLabel.AutoSize = true;
            nome_usuLabel.Location = new System.Drawing.Point(32, 196);
            nome_usuLabel.Name = "nome_usuLabel";
            nome_usuLabel.Size = new System.Drawing.Size(38, 13);
            nome_usuLabel.TabIndex = 3;
            nome_usuLabel.Text = "Nome:";
            // 
            // senha_usuLabel
            // 
            senha_usuLabel.AutoSize = true;
            senha_usuLabel.Location = new System.Drawing.Point(299, 201);
            senha_usuLabel.Name = "senha_usuLabel";
            senha_usuLabel.Size = new System.Drawing.Size(41, 13);
            senha_usuLabel.TabIndex = 5;
            senha_usuLabel.Text = "Senha:";
            // 
            // celular_usuLabel
            // 
            celular_usuLabel.AutoSize = true;
            celular_usuLabel.Location = new System.Drawing.Point(32, 279);
            celular_usuLabel.Name = "celular_usuLabel";
            celular_usuLabel.Size = new System.Drawing.Size(42, 13);
            celular_usuLabel.TabIndex = 7;
            celular_usuLabel.Text = "Celular:";
            // 
            // telefone_usuLabel
            // 
            telefone_usuLabel.AutoSize = true;
            telefone_usuLabel.Location = new System.Drawing.Point(32, 305);
            telefone_usuLabel.Name = "telefone_usuLabel";
            telefone_usuLabel.Size = new System.Drawing.Size(52, 13);
            telefone_usuLabel.TabIndex = 9;
            telefone_usuLabel.Text = "Telefone:";
            // 
            // email_usuLabel
            // 
            email_usuLabel.AutoSize = true;
            email_usuLabel.Location = new System.Drawing.Point(37, 329);
            email_usuLabel.Name = "email_usuLabel";
            email_usuLabel.Size = new System.Drawing.Size(35, 13);
            email_usuLabel.TabIndex = 11;
            email_usuLabel.Text = "Email:";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Location = new System.Drawing.Point(106, 134);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(93, 13);
            data_cadastroLabel.TabIndex = 13;
            data_cadastroLabel.Text = "Data de Cadastro:";
            // 
            // fKid_clienteLabel
            // 
            fKid_clienteLabel.AutoSize = true;
            fKid_clienteLabel.Location = new System.Drawing.Point(319, 330);
            fKid_clienteLabel.Name = "fKid_clienteLabel";
            fKid_clienteLabel.Size = new System.Drawing.Size(92, 13);
            fKid_clienteLabel.TabIndex = 15;
            fKid_clienteLabel.Text = "Código do cliente:";
            fKid_clienteLabel.Click += new System.EventHandler(this.fKid_clienteLabel_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(285, 226);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 13);
            label2.TabIndex = 19;
            label2.Text = "Repita senha:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.renataDBDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avaliacaoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.estoqueTableAdapter = null;
            this.tableAdapterManager.eventosTableAdapter = null;
            this.tableAdapterManager.ingredientesTableAdapter = null;
            this.tableAdapterManager.item_pedidoTableAdapter = null;
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuarioBindingNavigatorSaveItem});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(1522, 25);
            this.usuarioBindingNavigator.TabIndex = 0;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
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
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
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
            // usuarioBindingNavigatorSaveItem
            // 
            this.usuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingNavigatorSaveItem.Image")));
            this.usuarioBindingNavigatorSaveItem.Name = "usuarioBindingNavigatorSaveItem";
            this.usuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.usuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingNavigatorSaveItem_Click);
            // 
            // id_usuTextBox
            // 
            this.id_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "id_usu", true));
            this.id_usuTextBox.Location = new System.Drawing.Point(96, 162);
            this.id_usuTextBox.Name = "id_usuTextBox";
            this.id_usuTextBox.Size = new System.Drawing.Size(56, 20);
            this.id_usuTextBox.TabIndex = 2;
            // 
            // nome_usuTextBox
            // 
            this.nome_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nome_usu", true));
            this.nome_usuTextBox.Location = new System.Drawing.Point(96, 197);
            this.nome_usuTextBox.Name = "nome_usuTextBox";
            this.nome_usuTextBox.Size = new System.Drawing.Size(183, 20);
            this.nome_usuTextBox.TabIndex = 4;
            // 
            // senha_usuTextBox
            // 
            this.senha_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "senha_usu", true));
            this.senha_usuTextBox.Location = new System.Drawing.Point(363, 197);
            this.senha_usuTextBox.Name = "senha_usuTextBox";
            this.senha_usuTextBox.Size = new System.Drawing.Size(123, 20);
            this.senha_usuTextBox.TabIndex = 6;
            // 
            // celular_usuTextBox
            // 
            this.celular_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "celular_usu", true));
            this.celular_usuTextBox.Location = new System.Drawing.Point(96, 272);
            this.celular_usuTextBox.Name = "celular_usuTextBox";
            this.celular_usuTextBox.Size = new System.Drawing.Size(122, 20);
            this.celular_usuTextBox.TabIndex = 8;
            // 
            // telefone_usuTextBox
            // 
            this.telefone_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "telefone_usu", true));
            this.telefone_usuTextBox.Location = new System.Drawing.Point(96, 298);
            this.telefone_usuTextBox.Name = "telefone_usuTextBox";
            this.telefone_usuTextBox.Size = new System.Drawing.Size(122, 20);
            this.telefone_usuTextBox.TabIndex = 10;
            // 
            // email_usuTextBox
            // 
            this.email_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "email_usu", true));
            this.email_usuTextBox.Location = new System.Drawing.Point(96, 330);
            this.email_usuTextBox.Name = "email_usuTextBox";
            this.email_usuTextBox.Size = new System.Drawing.Size(200, 20);
            this.email_usuTextBox.TabIndex = 12;
            // 
            // data_cadastroDateTimePicker
            // 
            this.data_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "data_cadastro", true));
            this.data_cadastroDateTimePicker.Location = new System.Drawing.Point(206, 130);
            this.data_cadastroDateTimePicker.Name = "data_cadastroDateTimePicker";
            this.data_cadastroDateTimePicker.Size = new System.Drawing.Size(226, 20);
            this.data_cadastroDateTimePicker.TabIndex = 14;
            // 
            // fKid_clienteTextBox
            // 
            this.fKid_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "FKid_cliente", true));
            this.fKid_clienteTextBox.Location = new System.Drawing.Point(418, 327);
            this.fKid_clienteTextBox.Name = "fKid_clienteTextBox";
            this.fKid_clienteTextBox.Size = new System.Drawing.Size(135, 20);
            this.fKid_clienteTextBox.TabIndex = 16;
            this.fKid_clienteTextBox.TextChanged += new System.EventHandler(this.fKid_clienteTextBox_TextChanged);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(571, 85);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.Size = new System.Drawing.Size(842, 573);
            this.usuarioDataGridView.TabIndex = 17;
            this.usuarioDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_usu";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_usu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_usu";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_usu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "senha_usu";
            this.dataGridViewTextBoxColumn3.HeaderText = "senha_usu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "celular_usu";
            this.dataGridViewTextBoxColumn4.HeaderText = "celular_usu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefone_usu";
            this.dataGridViewTextBoxColumn5.HeaderText = "telefone_usu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email_usu";
            this.dataGridViewTextBoxColumn6.HeaderText = "email_usu";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "data_cadastro";
            this.dataGridViewTextBoxColumn7.HeaderText = "data_cadastro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FKid_cliente";
            this.dataGridViewTextBoxColumn8.HeaderText = "FKid_cliente";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(124, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 129);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(42, 75);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(312, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(197, 35);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(152, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Location = new System.Drawing.Point(42, 32);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(130, 21);
            this.cbmFiltrar.TabIndex = 0;
            // 
            // repitasenhatxtBox
            // 
            this.repitasenhatxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "senha_usu", true));
            this.repitasenhatxtBox.Location = new System.Drawing.Point(363, 223);
            this.repitasenhatxtBox.Name = "repitasenhatxtBox";
            this.repitasenhatxtBox.Size = new System.Drawing.Size(123, 20);
            this.repitasenhatxtBox.TabIndex = 20;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1522, 749);
            this.Controls.Add(label2);
            this.Controls.Add(this.repitasenhatxtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(id_usuLabel);
            this.Controls.Add(this.id_usuTextBox);
            this.Controls.Add(nome_usuLabel);
            this.Controls.Add(this.nome_usuTextBox);
            this.Controls.Add(senha_usuLabel);
            this.Controls.Add(this.senha_usuTextBox);
            this.Controls.Add(celular_usuLabel);
            this.Controls.Add(this.celular_usuTextBox);
            this.Controls.Add(telefone_usuLabel);
            this.Controls.Add(this.telefone_usuTextBox);
            this.Controls.Add(email_usuLabel);
            this.Controls.Add(this.email_usuTextBox);
            this.Controls.Add(data_cadastroLabel);
            this.Controls.Add(this.data_cadastroDateTimePicker);
            this.Controls.Add(fKid_clienteLabel);
            this.Controls.Add(this.fKid_clienteTextBox);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUsuario";
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private RenataDBDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_usuTextBox;
        private System.Windows.Forms.TextBox nome_usuTextBox;
        private System.Windows.Forms.TextBox senha_usuTextBox;
        private System.Windows.Forms.TextBox celular_usuTextBox;
        private System.Windows.Forms.TextBox telefone_usuTextBox;
        private System.Windows.Forms.TextBox email_usuTextBox;
        private System.Windows.Forms.DateTimePicker data_cadastroDateTimePicker;
        private System.Windows.Forms.TextBox fKid_clienteTextBox;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repitasenhatxtBox;
    }
}