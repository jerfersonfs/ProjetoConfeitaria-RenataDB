﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Formulários
{
    public partial class frmPedido: Form
    {
        Conection cntn = new Conection();
        public frmPedido()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter.Fill(this.renataDBDataSet.pedido);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Pedido WHERE id_pedido = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable pedido = new DataTable();
                    adapter.Fill(pedido);
                    pedidoDataGridView.DataSource = pedido;
                }
                if (cbmFiltrar.Text == "Pedido")
                {
                    string sql = "SELECT * FROM Pedido WHERE FKid_produto LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable pedido = new DataTable();
                    adapter.Fill(pedido);
                    pedidoDataGridView.DataSource = pedido;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cntn.Close();
            }
        }
    }
}
