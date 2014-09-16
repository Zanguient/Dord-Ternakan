using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Ternakan
{
    public partial class frmTabelaVacina : Form
    {
        int IDGado;
        public frmTabelaVacina()
        {
            InitializeComponent();
        }
        public void carregar(int ID)
        {
            IDGado = ID;
            ShowDialog();
        }

        private void carregarDgView()
        {
            string squery;

            squery = string.Format("SELECT * FROM VACINACA WHERE ID_GADO = {0}", IDGado);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();
                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);
                dataGridView1.DataSource = dtUsuarios;
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
            }
            finally
            {
                fbConn.Close();
            }
        }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTabelaVacina_Load(object sender, EventArgs e)
        {

        }

        private void frmTabelaVacina_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDgView();
        }

        private void frmTabelaVacina_Load_1(object sender, EventArgs e)
        {

        }

        private void removerVacinacao(int ID)
        {
            string squery = string.Format("DELETE FROM VACINACA WHERE ID = {0}",
                ID);
            if (MessageBox.Show("Você tem certeza que deseja remover esta vacina do gado?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                FbConnection fbConn = new FbConnection(frmHome.strConn);

                FbCommand fbCmd = new FbCommand(squery, fbConn);

                try
                {
                    fbConn.Open();
                    fbCmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
                }
                finally
                {
                    fbConn.Close();
                }
            }

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                removerVacinacao(id);
                carregarDgView();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btRemover.Enabled = (dataGridView1.SelectedRows.Count > 0);
        }
    }
}