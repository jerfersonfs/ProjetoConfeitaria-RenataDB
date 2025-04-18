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
    public partial class frmEvento: Form
    {
        Conection cntn =  new Conection();
        public frmEvento()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void eventosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmEvento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.eventos'. Você pode movê-la ou removê-la conforme necessário.
            this.eventosTableAdapter.Fill(this.renataDBDataSet.eventos);

        }

        private void eventosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_eventoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Eventos WHERE id_evento = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable evento = new DataTable();
                    adapter.Fill(evento);
                    eventosDataGridView.DataSource = evento;
                }
                if (cbmFiltrar.Text == "Eventos")
                {
                    string sql = "SELECT * FROM Eventos WHERE tipo_evento LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable evento = new DataTable();
                    adapter.Fill(evento);
                    eventosDataGridView.DataSource = evento;
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
