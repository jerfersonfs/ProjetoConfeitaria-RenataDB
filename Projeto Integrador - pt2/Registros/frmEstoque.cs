using System;
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
    public partial class frmEstoque: Form
    {
        Conection cntn = new Conection();
        public frmEstoque()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void estoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.renataDBDataSet.estoque);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Estoque WHERE id_estoque = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable estoque = new DataTable();
                    adapter.Fill(estoque);
                    estoqueDataGridView.DataSource = estoque;
                }
                if (cbmFiltrar.Text == "Usuário")
                {
                    string sql = "SELECT * FROM Estoque WHERE nome_estoque LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable  estoque = new DataTable();
                    adapter.Fill(estoque);
                    estoqueDataGridView.DataSource = estoque;
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
