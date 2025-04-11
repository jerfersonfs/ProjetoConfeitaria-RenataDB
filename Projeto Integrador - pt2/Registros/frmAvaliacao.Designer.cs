namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmAvaliacao
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
            System.Windows.Forms.Label id_avaliacaoLabel;
            System.Windows.Forms.Label fKid_produtoLabel;
            System.Windows.Forms.Label fKid_clienteLabel;
            System.Windows.Forms.Label nota_avaliacaoLabel;
            System.Windows.Forms.Label comentario_avaliacaoLabel;
            System.Windows.Forms.Label data_avaliacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvaliacao));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.avaliacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avaliacaoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.avaliacaoTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.avaliacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.avaliacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.avaliacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_avaliacaoTextBox = new System.Windows.Forms.TextBox();
            this.fKid_produtoTextBox = new System.Windows.Forms.TextBox();
            this.fKid_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nota_avaliacaoTextBox = new System.Windows.Forms.TextBox();
            this.comentario_avaliacaoTextBox = new System.Windows.Forms.TextBox();
            this.data_avaliacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            id_avaliacaoLabel = new System.Windows.Forms.Label();
            fKid_produtoLabel = new System.Windows.Forms.Label();
            fKid_clienteLabel = new System.Windows.Forms.Label();
            nota_avaliacaoLabel = new System.Windows.Forms.Label();
            comentario_avaliacaoLabel = new System.Windows.Forms.Label();
            data_avaliacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoBindingNavigator)).BeginInit();
            this.avaliacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_avaliacaoLabel
            // 
            id_avaliacaoLabel.AutoSize = true;
            id_avaliacaoLabel.Location = new System.Drawing.Point(91, 205);
            id_avaliacaoLabel.Name = "id_avaliacaoLabel";
            id_avaliacaoLabel.Size = new System.Drawing.Size(43, 13);
            id_avaliacaoLabel.TabIndex = 2;
            id_avaliacaoLabel.Text = "Código:";
            // 
            // fKid_produtoLabel
            // 
            fKid_produtoLabel.AutoSize = true;
            fKid_produtoLabel.Location = new System.Drawing.Point(91, 231);
            fKid_produtoLabel.Name = "fKid_produtoLabel";
            fKid_produtoLabel.Size = new System.Drawing.Size(70, 13);
            fKid_produtoLabel.TabIndex = 4;
            fKid_produtoLabel.Text = "FKid produto:";
            // 
            // fKid_clienteLabel
            // 
            fKid_clienteLabel.AutoSize = true;
            fKid_clienteLabel.Location = new System.Drawing.Point(91, 257);
            fKid_clienteLabel.Name = "fKid_clienteLabel";
            fKid_clienteLabel.Size = new System.Drawing.Size(65, 13);
            fKid_clienteLabel.TabIndex = 6;
            fKid_clienteLabel.Text = "FKid cliente:";
            // 
            // nota_avaliacaoLabel
            // 
            nota_avaliacaoLabel.AutoSize = true;
            nota_avaliacaoLabel.Location = new System.Drawing.Point(91, 283);
            nota_avaliacaoLabel.Name = "nota_avaliacaoLabel";
            nota_avaliacaoLabel.Size = new System.Drawing.Size(33, 13);
            nota_avaliacaoLabel.TabIndex = 8;
            nota_avaliacaoLabel.Text = "Nota:";
            // 
            // comentario_avaliacaoLabel
            // 
            comentario_avaliacaoLabel.AutoSize = true;
            comentario_avaliacaoLabel.Location = new System.Drawing.Point(91, 309);
            comentario_avaliacaoLabel.Name = "comentario_avaliacaoLabel";
            comentario_avaliacaoLabel.Size = new System.Drawing.Size(66, 13);
            comentario_avaliacaoLabel.TabIndex = 10;
            comentario_avaliacaoLabel.Text = "Comentário: ";
            // 
            // data_avaliacaoLabel
            // 
            data_avaliacaoLabel.AutoSize = true;
            data_avaliacaoLabel.Location = new System.Drawing.Point(91, 336);
            data_avaliacaoLabel.Name = "data_avaliacaoLabel";
            data_avaliacaoLabel.Size = new System.Drawing.Size(33, 13);
            data_avaliacaoLabel.TabIndex = 12;
            data_avaliacaoLabel.Text = "Data:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avaliacaoBindingSource
            // 
            this.avaliacaoBindingSource.DataMember = "avaliacao";
            this.avaliacaoBindingSource.DataSource = this.renataDBDataSet;
            // 
            // avaliacaoTableAdapter
            // 
            this.avaliacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avaliacaoTableAdapter = this.avaliacaoTableAdapter;
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
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // avaliacaoBindingNavigator
            // 
            this.avaliacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.avaliacaoBindingNavigator.BindingSource = this.avaliacaoBindingSource;
            this.avaliacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.avaliacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.avaliacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.avaliacaoBindingNavigatorSaveItem});
            this.avaliacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avaliacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.avaliacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.avaliacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.avaliacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.avaliacaoBindingNavigator.Name = "avaliacaoBindingNavigator";
            this.avaliacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.avaliacaoBindingNavigator.Size = new System.Drawing.Size(1694, 25);
            this.avaliacaoBindingNavigator.TabIndex = 0;
            this.avaliacaoBindingNavigator.Text = "bindingNavigator1";
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
            // avaliacaoBindingNavigatorSaveItem
            // 
            this.avaliacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avaliacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("avaliacaoBindingNavigatorSaveItem.Image")));
            this.avaliacaoBindingNavigatorSaveItem.Name = "avaliacaoBindingNavigatorSaveItem";
            this.avaliacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.avaliacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.avaliacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.avaliacaoBindingNavigatorSaveItem_Click);
            // 
            // avaliacaoDataGridView
            // 
            this.avaliacaoDataGridView.AutoGenerateColumns = false;
            this.avaliacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avaliacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.avaliacaoDataGridView.DataSource = this.avaliacaoBindingSource;
            this.avaliacaoDataGridView.Location = new System.Drawing.Point(619, 392);
            this.avaliacaoDataGridView.Name = "avaliacaoDataGridView";
            this.avaliacaoDataGridView.Size = new System.Drawing.Size(638, 504);
            this.avaliacaoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_avaliacao";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_avaliacao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FKid_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "FKid_produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FKid_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "FKid_cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nota_avaliacao";
            this.dataGridViewTextBoxColumn4.HeaderText = "nota_avaliacao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "comentario_avaliacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "comentario_avaliacao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data_avaliacao";
            this.dataGridViewTextBoxColumn6.HeaderText = "data_avaliacao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // id_avaliacaoTextBox
            // 
            this.id_avaliacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avaliacaoBindingSource, "id_avaliacao", true));
            this.id_avaliacaoTextBox.Location = new System.Drawing.Point(208, 202);
            this.id_avaliacaoTextBox.Name = "id_avaliacaoTextBox";
            this.id_avaliacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_avaliacaoTextBox.TabIndex = 3;
            // 
            // fKid_produtoTextBox
            // 
            this.fKid_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avaliacaoBindingSource, "FKid_produto", true));
            this.fKid_produtoTextBox.Location = new System.Drawing.Point(208, 228);
            this.fKid_produtoTextBox.Name = "fKid_produtoTextBox";
            this.fKid_produtoTextBox.Size = new System.Drawing.Size(200, 20);
            this.fKid_produtoTextBox.TabIndex = 5;
            // 
            // fKid_clienteTextBox
            // 
            this.fKid_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avaliacaoBindingSource, "FKid_cliente", true));
            this.fKid_clienteTextBox.Location = new System.Drawing.Point(208, 254);
            this.fKid_clienteTextBox.Name = "fKid_clienteTextBox";
            this.fKid_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.fKid_clienteTextBox.TabIndex = 7;
            // 
            // nota_avaliacaoTextBox
            // 
            this.nota_avaliacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avaliacaoBindingSource, "nota_avaliacao", true));
            this.nota_avaliacaoTextBox.Location = new System.Drawing.Point(208, 280);
            this.nota_avaliacaoTextBox.Name = "nota_avaliacaoTextBox";
            this.nota_avaliacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nota_avaliacaoTextBox.TabIndex = 9;
            // 
            // comentario_avaliacaoTextBox
            // 
            this.comentario_avaliacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avaliacaoBindingSource, "comentario_avaliacao", true));
            this.comentario_avaliacaoTextBox.Location = new System.Drawing.Point(208, 306);
            this.comentario_avaliacaoTextBox.Name = "comentario_avaliacaoTextBox";
            this.comentario_avaliacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.comentario_avaliacaoTextBox.TabIndex = 11;
            // 
            // data_avaliacaoDateTimePicker
            // 
            this.data_avaliacaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.avaliacaoBindingSource, "data_avaliacao", true));
            this.data_avaliacaoDateTimePicker.Location = new System.Drawing.Point(208, 332);
            this.data_avaliacaoDateTimePicker.Name = "data_avaliacaoDateTimePicker";
            this.data_avaliacaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_avaliacaoDateTimePicker.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(619, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 117);
            this.groupBox1.TabIndex = 19;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(619, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 62);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "     Avaliação";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1694, 1041);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_avaliacaoLabel);
            this.Controls.Add(this.id_avaliacaoTextBox);
            this.Controls.Add(fKid_produtoLabel);
            this.Controls.Add(this.fKid_produtoTextBox);
            this.Controls.Add(fKid_clienteLabel);
            this.Controls.Add(this.fKid_clienteTextBox);
            this.Controls.Add(nota_avaliacaoLabel);
            this.Controls.Add(this.nota_avaliacaoTextBox);
            this.Controls.Add(comentario_avaliacaoLabel);
            this.Controls.Add(this.comentario_avaliacaoTextBox);
            this.Controls.Add(data_avaliacaoLabel);
            this.Controls.Add(this.data_avaliacaoDateTimePicker);
            this.Controls.Add(this.avaliacaoDataGridView);
            this.Controls.Add(this.avaliacaoBindingNavigator);
            this.Name = "frmAvaliacao";
            this.Text = "frmAvaliacao";
            this.Load += new System.EventHandler(this.frmAvaliacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoBindingNavigator)).EndInit();
            this.avaliacaoBindingNavigator.ResumeLayout(false);
            this.avaliacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource avaliacaoBindingSource;
        private RenataDBDataSetTableAdapters.avaliacaoTableAdapter avaliacaoTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator avaliacaoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton avaliacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView avaliacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox id_avaliacaoTextBox;
        private System.Windows.Forms.TextBox fKid_produtoTextBox;
        private System.Windows.Forms.TextBox fKid_clienteTextBox;
        private System.Windows.Forms.TextBox nota_avaliacaoTextBox;
        private System.Windows.Forms.TextBox comentario_avaliacaoTextBox;
        private System.Windows.Forms.DateTimePicker data_avaliacaoDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.TextBox textBox1;
    }
}