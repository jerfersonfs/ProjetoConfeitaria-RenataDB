namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmPedido
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
            System.Windows.Forms.Label id_pedidoLabel;
            System.Windows.Forms.Label fKid_clienteLabel;
            System.Windows.Forms.Label fKid_produtoLabel;
            System.Windows.Forms.Label data_pedidoLabel;
            System.Windows.Forms.Label data_entregaLabel;
            System.Windows.Forms.Label status_pedidoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.pedidoTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.pedidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pedidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pedidoTextBox = new System.Windows.Forms.TextBox();
            this.fKid_clienteTextBox = new System.Windows.Forms.TextBox();
            this.fKid_produtoTextBox = new System.Windows.Forms.TextBox();
            this.data_pedidoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_entregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.status_pedidoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            id_pedidoLabel = new System.Windows.Forms.Label();
            fKid_clienteLabel = new System.Windows.Forms.Label();
            fKid_produtoLabel = new System.Windows.Forms.Label();
            data_pedidoLabel = new System.Windows.Forms.Label();
            data_entregaLabel = new System.Windows.Forms.Label();
            status_pedidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).BeginInit();
            this.pedidoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_pedidoLabel
            // 
            id_pedidoLabel.AutoSize = true;
            id_pedidoLabel.Location = new System.Drawing.Point(144, 134);
            id_pedidoLabel.Name = "id_pedidoLabel";
            id_pedidoLabel.Size = new System.Drawing.Size(43, 13);
            id_pedidoLabel.TabIndex = 2;
            id_pedidoLabel.Text = "Código:";
            // 
            // fKid_clienteLabel
            // 
            fKid_clienteLabel.AutoSize = true;
            fKid_clienteLabel.Location = new System.Drawing.Point(123, 160);
            fKid_clienteLabel.Name = "fKid_clienteLabel";
            fKid_clienteLabel.Size = new System.Drawing.Size(65, 13);
            fKid_clienteLabel.TabIndex = 4;
            fKid_clienteLabel.Text = "FKid cliente:";
            // 
            // fKid_produtoLabel
            // 
            fKid_produtoLabel.AutoSize = true;
            fKid_produtoLabel.Location = new System.Drawing.Point(123, 186);
            fKid_produtoLabel.Name = "fKid_produtoLabel";
            fKid_produtoLabel.Size = new System.Drawing.Size(70, 13);
            fKid_produtoLabel.TabIndex = 6;
            fKid_produtoLabel.Text = "FKid produto:";
            // 
            // data_pedidoLabel
            // 
            data_pedidoLabel.AutoSize = true;
            data_pedidoLabel.Location = new System.Drawing.Point(111, 213);
            data_pedidoLabel.Name = "data_pedidoLabel";
            data_pedidoLabel.Size = new System.Drawing.Size(83, 13);
            data_pedidoLabel.TabIndex = 8;
            data_pedidoLabel.Text = "Data de pedido:";
            // 
            // data_entregaLabel
            // 
            data_entregaLabel.AutoSize = true;
            data_entregaLabel.Location = new System.Drawing.Point(104, 239);
            data_entregaLabel.Name = "data_entregaLabel";
            data_entregaLabel.Size = new System.Drawing.Size(90, 13);
            data_entregaLabel.TabIndex = 10;
            data_entregaLabel.Text = "Data  de entrega:";
            // 
            // status_pedidoLabel
            // 
            status_pedidoLabel.AutoSize = true;
            status_pedidoLabel.Location = new System.Drawing.Point(103, 264);
            status_pedidoLabel.Name = "status_pedidoLabel";
            status_pedidoLabel.Size = new System.Drawing.Size(90, 13);
            status_pedidoLabel.TabIndex = 12;
            status_pedidoLabel.Text = "Status do pedido:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.renataDBDataSet;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.pedidoTableAdapter = this.pedidoTableAdapter;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // pedidoBindingNavigator
            // 
            this.pedidoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pedidoBindingNavigator.BindingSource = this.pedidoBindingSource;
            this.pedidoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pedidoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pedidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pedidoBindingNavigatorSaveItem});
            this.pedidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pedidoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pedidoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pedidoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pedidoBindingNavigator.Name = "pedidoBindingNavigator";
            this.pedidoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pedidoBindingNavigator.Size = new System.Drawing.Size(1694, 25);
            this.pedidoBindingNavigator.TabIndex = 0;
            this.pedidoBindingNavigator.Text = "bindingNavigator1";
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
            // pedidoBindingNavigatorSaveItem
            // 
            this.pedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoBindingNavigatorSaveItem.Image")));
            this.pedidoBindingNavigatorSaveItem.Name = "pedidoBindingNavigatorSaveItem";
            this.pedidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pedidoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pedidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoBindingNavigatorSaveItem_Click);
            // 
            // pedidoDataGridView
            // 
            this.pedidoDataGridView.AutoGenerateColumns = false;
            this.pedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pedidoDataGridView.DataSource = this.pedidoBindingSource;
            this.pedidoDataGridView.Location = new System.Drawing.Point(614, 370);
            this.pedidoDataGridView.Name = "pedidoDataGridView";
            this.pedidoDataGridView.Size = new System.Drawing.Size(638, 608);
            this.pedidoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pedido";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FKid_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "FKid_cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FKid_produto";
            this.dataGridViewTextBoxColumn3.HeaderText = "FKid_produto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_pedido";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_pedido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "data_entrega";
            this.dataGridViewTextBoxColumn5.HeaderText = "data_entrega";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "status_pedido";
            this.dataGridViewTextBoxColumn6.HeaderText = "status_pedido";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // id_pedidoTextBox
            // 
            this.id_pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id_pedido", true));
            this.id_pedidoTextBox.Location = new System.Drawing.Point(202, 131);
            this.id_pedidoTextBox.Name = "id_pedidoTextBox";
            this.id_pedidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_pedidoTextBox.TabIndex = 3;
            // 
            // fKid_clienteTextBox
            // 
            this.fKid_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "FKid_cliente", true));
            this.fKid_clienteTextBox.Location = new System.Drawing.Point(202, 157);
            this.fKid_clienteTextBox.Name = "fKid_clienteTextBox";
            this.fKid_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.fKid_clienteTextBox.TabIndex = 5;
            // 
            // fKid_produtoTextBox
            // 
            this.fKid_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "FKid_produto", true));
            this.fKid_produtoTextBox.Location = new System.Drawing.Point(202, 183);
            this.fKid_produtoTextBox.Name = "fKid_produtoTextBox";
            this.fKid_produtoTextBox.Size = new System.Drawing.Size(200, 20);
            this.fKid_produtoTextBox.TabIndex = 7;
            // 
            // data_pedidoDateTimePicker
            // 
            this.data_pedidoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "data_pedido", true));
            this.data_pedidoDateTimePicker.Location = new System.Drawing.Point(202, 209);
            this.data_pedidoDateTimePicker.Name = "data_pedidoDateTimePicker";
            this.data_pedidoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_pedidoDateTimePicker.TabIndex = 9;
            // 
            // data_entregaDateTimePicker
            // 
            this.data_entregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "data_entrega", true));
            this.data_entregaDateTimePicker.Location = new System.Drawing.Point(202, 235);
            this.data_entregaDateTimePicker.Name = "data_entregaDateTimePicker";
            this.data_entregaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_entregaDateTimePicker.TabIndex = 11;
            // 
            // status_pedidoTextBox
            // 
            this.status_pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "status_pedido", true));
            this.status_pedidoTextBox.Location = new System.Drawing.Point(202, 264);
            this.status_pedidoTextBox.Name = "status_pedidoTextBox";
            this.status_pedidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.status_pedidoTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(614, 123);
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
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1694, 1041);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_pedidoLabel);
            this.Controls.Add(this.id_pedidoTextBox);
            this.Controls.Add(fKid_clienteLabel);
            this.Controls.Add(this.fKid_clienteTextBox);
            this.Controls.Add(fKid_produtoLabel);
            this.Controls.Add(this.fKid_produtoTextBox);
            this.Controls.Add(data_pedidoLabel);
            this.Controls.Add(this.data_pedidoDateTimePicker);
            this.Controls.Add(data_entregaLabel);
            this.Controls.Add(this.data_entregaDateTimePicker);
            this.Controls.Add(status_pedidoLabel);
            this.Controls.Add(this.status_pedidoTextBox);
            this.Controls.Add(this.pedidoDataGridView);
            this.Controls.Add(this.pedidoBindingNavigator);
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).EndInit();
            this.pedidoBindingNavigator.ResumeLayout(false);
            this.pedidoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private RenataDBDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pedidoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox id_pedidoTextBox;
        private System.Windows.Forms.TextBox fKid_clienteTextBox;
        private System.Windows.Forms.TextBox fKid_produtoTextBox;
        private System.Windows.Forms.DateTimePicker data_pedidoDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_entregaDateTimePicker;
        private System.Windows.Forms.TextBox status_pedidoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
    }
}