namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmEstoque
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
            System.Windows.Forms.Label id_estoqueLabel;
            System.Windows.Forms.Label cat_estoqueLabel;
            System.Windows.Forms.Label nome_estoqueLabel;
            System.Windows.Forms.Label fKid_ingredienteLabel;
            System.Windows.Forms.Label data_movimentacaoLabel;
            System.Windows.Forms.Label quantidade_movimentadaLabel;
            System.Windows.Forms.Label tipo_movimentacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.estoqueTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.estoqueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.estoqueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.estoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.cat_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.nome_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.fKid_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.data_movimentacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantidade_movimentadaTextBox = new System.Windows.Forms.TextBox();
            this.tipo_movimentacaoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            id_estoqueLabel = new System.Windows.Forms.Label();
            cat_estoqueLabel = new System.Windows.Forms.Label();
            nome_estoqueLabel = new System.Windows.Forms.Label();
            fKid_ingredienteLabel = new System.Windows.Forms.Label();
            data_movimentacaoLabel = new System.Windows.Forms.Label();
            quantidade_movimentadaLabel = new System.Windows.Forms.Label();
            tipo_movimentacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).BeginInit();
            this.estoqueBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_estoqueLabel
            // 
            id_estoqueLabel.AutoSize = true;
            id_estoqueLabel.Location = new System.Drawing.Point(125, 108);
            id_estoqueLabel.Name = "id_estoqueLabel";
            id_estoqueLabel.Size = new System.Drawing.Size(43, 13);
            id_estoqueLabel.TabIndex = 2;
            id_estoqueLabel.Text = "Código:";
            // 
            // cat_estoqueLabel
            // 
            cat_estoqueLabel.AutoSize = true;
            cat_estoqueLabel.Location = new System.Drawing.Point(125, 134);
            cat_estoqueLabel.Name = "cat_estoqueLabel";
            cat_estoqueLabel.Size = new System.Drawing.Size(55, 13);
            cat_estoqueLabel.TabIndex = 4;
            cat_estoqueLabel.Text = "Categoria:";
            // 
            // nome_estoqueLabel
            // 
            nome_estoqueLabel.AutoSize = true;
            nome_estoqueLabel.Location = new System.Drawing.Point(125, 160);
            nome_estoqueLabel.Name = "nome_estoqueLabel";
            nome_estoqueLabel.Size = new System.Drawing.Size(49, 13);
            nome_estoqueLabel.TabIndex = 6;
            nome_estoqueLabel.Text = "Estoque:";
            // 
            // fKid_ingredienteLabel
            // 
            fKid_ingredienteLabel.AutoSize = true;
            fKid_ingredienteLabel.Location = new System.Drawing.Point(125, 186);
            fKid_ingredienteLabel.Name = "fKid_ingredienteLabel";
            fKid_ingredienteLabel.Size = new System.Drawing.Size(86, 13);
            fKid_ingredienteLabel.TabIndex = 8;
            fKid_ingredienteLabel.Text = "FKid ingrediente:";
            // 
            // data_movimentacaoLabel
            // 
            data_movimentacaoLabel.AutoSize = true;
            data_movimentacaoLabel.Location = new System.Drawing.Point(125, 213);
            data_movimentacaoLabel.Name = "data_movimentacaoLabel";
            data_movimentacaoLabel.Size = new System.Drawing.Size(120, 13);
            data_movimentacaoLabel.TabIndex = 10;
            data_movimentacaoLabel.Text = "Data da movimentação:";
            // 
            // quantidade_movimentadaLabel
            // 
            quantidade_movimentadaLabel.AutoSize = true;
            quantidade_movimentadaLabel.Location = new System.Drawing.Point(125, 238);
            quantidade_movimentadaLabel.Name = "quantidade_movimentadaLabel";
            quantidade_movimentadaLabel.Size = new System.Drawing.Size(131, 13);
            quantidade_movimentadaLabel.TabIndex = 12;
            quantidade_movimentadaLabel.Text = "Quantidade movimentada:";
            // 
            // tipo_movimentacaoLabel
            // 
            tipo_movimentacaoLabel.AutoSize = true;
            tipo_movimentacaoLabel.Location = new System.Drawing.Point(125, 264);
            tipo_movimentacaoLabel.Name = "tipo_movimentacaoLabel";
            tipo_movimentacaoLabel.Size = new System.Drawing.Size(118, 13);
            tipo_movimentacaoLabel.TabIndex = 14;
            tipo_movimentacaoLabel.Text = "Tipo de movimentação:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "estoque";
            this.estoqueBindingSource.DataSource = this.renataDBDataSet;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avaliacaoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.estoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.eventosTableAdapter = null;
            this.tableAdapterManager.ingredientesTableAdapter = null;
            this.tableAdapterManager.item_pedidoTableAdapter = null;
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // estoqueBindingNavigator
            // 
            this.estoqueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estoqueBindingNavigator.BindingSource = this.estoqueBindingSource;
            this.estoqueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estoqueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estoqueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estoqueBindingNavigatorSaveItem});
            this.estoqueBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estoqueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estoqueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estoqueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estoqueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estoqueBindingNavigator.Name = "estoqueBindingNavigator";
            this.estoqueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estoqueBindingNavigator.Size = new System.Drawing.Size(1694, 25);
            this.estoqueBindingNavigator.TabIndex = 0;
            this.estoqueBindingNavigator.Text = "bindingNavigator1";
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
            // estoqueBindingNavigatorSaveItem
            // 
            this.estoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estoqueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estoqueBindingNavigatorSaveItem.Image")));
            this.estoqueBindingNavigatorSaveItem.Name = "estoqueBindingNavigatorSaveItem";
            this.estoqueBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estoqueBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.estoqueBindingNavigatorSaveItem.Click += new System.EventHandler(this.estoqueBindingNavigatorSaveItem_Click);
            // 
            // estoqueDataGridView
            // 
            this.estoqueDataGridView.AutoGenerateColumns = false;
            this.estoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estoqueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.estoqueDataGridView.DataSource = this.estoqueBindingSource;
            this.estoqueDataGridView.Location = new System.Drawing.Point(862, 558);
            this.estoqueDataGridView.Name = "estoqueDataGridView";
            this.estoqueDataGridView.Size = new System.Drawing.Size(738, 471);
            this.estoqueDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_estoque";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_estoque";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cat_estoque";
            this.dataGridViewTextBoxColumn2.HeaderText = "cat_estoque";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome_estoque";
            this.dataGridViewTextBoxColumn3.HeaderText = "nome_estoque";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FKid_ingrediente";
            this.dataGridViewTextBoxColumn4.HeaderText = "FKid_ingrediente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "data_movimentacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "data_movimentacao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "quantidade_movimentada";
            this.dataGridViewTextBoxColumn6.HeaderText = "quantidade_movimentada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tipo_movimentacao";
            this.dataGridViewTextBoxColumn7.HeaderText = "tipo_movimentacao";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // id_estoqueTextBox
            // 
            this.id_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "id_estoque", true));
            this.id_estoqueTextBox.Location = new System.Drawing.Point(260, 105);
            this.id_estoqueTextBox.Name = "id_estoqueTextBox";
            this.id_estoqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_estoqueTextBox.TabIndex = 3;
            // 
            // cat_estoqueTextBox
            // 
            this.cat_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "cat_estoque", true));
            this.cat_estoqueTextBox.Location = new System.Drawing.Point(260, 131);
            this.cat_estoqueTextBox.Name = "cat_estoqueTextBox";
            this.cat_estoqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.cat_estoqueTextBox.TabIndex = 5;
            // 
            // nome_estoqueTextBox
            // 
            this.nome_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "nome_estoque", true));
            this.nome_estoqueTextBox.Location = new System.Drawing.Point(260, 157);
            this.nome_estoqueTextBox.Name = "nome_estoqueTextBox";
            this.nome_estoqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.nome_estoqueTextBox.TabIndex = 7;
            // 
            // fKid_ingredienteTextBox
            // 
            this.fKid_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "FKid_ingrediente", true));
            this.fKid_ingredienteTextBox.Location = new System.Drawing.Point(260, 183);
            this.fKid_ingredienteTextBox.Name = "fKid_ingredienteTextBox";
            this.fKid_ingredienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.fKid_ingredienteTextBox.TabIndex = 9;
            // 
            // data_movimentacaoDateTimePicker
            // 
            this.data_movimentacaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estoqueBindingSource, "data_movimentacao", true));
            this.data_movimentacaoDateTimePicker.Location = new System.Drawing.Point(260, 209);
            this.data_movimentacaoDateTimePicker.Name = "data_movimentacaoDateTimePicker";
            this.data_movimentacaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_movimentacaoDateTimePicker.TabIndex = 11;
            // 
            // quantidade_movimentadaTextBox
            // 
            this.quantidade_movimentadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "quantidade_movimentada", true));
            this.quantidade_movimentadaTextBox.Location = new System.Drawing.Point(260, 235);
            this.quantidade_movimentadaTextBox.Name = "quantidade_movimentadaTextBox";
            this.quantidade_movimentadaTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantidade_movimentadaTextBox.TabIndex = 13;
            // 
            // tipo_movimentacaoTextBox
            // 
            this.tipo_movimentacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "tipo_movimentacao", true));
            this.tipo_movimentacaoTextBox.Location = new System.Drawing.Point(260, 261);
            this.tipo_movimentacaoTextBox.Name = "tipo_movimentacaoTextBox";
            this.tipo_movimentacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipo_movimentacaoTextBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(667, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 129);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
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
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1694, 1049);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_estoqueLabel);
            this.Controls.Add(this.id_estoqueTextBox);
            this.Controls.Add(cat_estoqueLabel);
            this.Controls.Add(this.cat_estoqueTextBox);
            this.Controls.Add(nome_estoqueLabel);
            this.Controls.Add(this.nome_estoqueTextBox);
            this.Controls.Add(fKid_ingredienteLabel);
            this.Controls.Add(this.fKid_ingredienteTextBox);
            this.Controls.Add(data_movimentacaoLabel);
            this.Controls.Add(this.data_movimentacaoDateTimePicker);
            this.Controls.Add(quantidade_movimentadaLabel);
            this.Controls.Add(this.quantidade_movimentadaTextBox);
            this.Controls.Add(tipo_movimentacaoLabel);
            this.Controls.Add(this.tipo_movimentacaoTextBox);
            this.Controls.Add(this.estoqueDataGridView);
            this.Controls.Add(this.estoqueBindingNavigator);
            this.Name = "frmEstoque";
            this.Text = "frmEstoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).EndInit();
            this.estoqueBindingNavigator.ResumeLayout(false);
            this.estoqueBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private RenataDBDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estoqueBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estoqueBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView estoqueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox id_estoqueTextBox;
        private System.Windows.Forms.TextBox cat_estoqueTextBox;
        private System.Windows.Forms.TextBox nome_estoqueTextBox;
        private System.Windows.Forms.TextBox fKid_ingredienteTextBox;
        private System.Windows.Forms.DateTimePicker data_movimentacaoDateTimePicker;
        private System.Windows.Forms.TextBox quantidade_movimentadaTextBox;
        private System.Windows.Forms.TextBox tipo_movimentacaoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
    }
}