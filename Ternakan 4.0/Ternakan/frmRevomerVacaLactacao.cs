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
    public partial class frmRevomerVacaLactacao : Form
    {
        LinkedList<int> link = new LinkedList<int>();
        public frmRevomerVacaLactacao()
        {
            InitializeComponent();
        }

        private void carregarDgView()
        {
            string squery;

            squery = string.Format("SELECT ID, NOME, NUMERO FROM GADO WHERE ((LACTACAO = '1') AND (ID_FAZENDA = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO'))", frmHome.IDFazendaSelecionada);
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            
            FbCommand fbCmd = new FbCommand(squery, fbConn);
            try
            {
                fbConn.Open();
                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);
                dataGridView1.DataSource = dtUsuarios;
                dataGridView1.Columns[1].ReadOnly = true;
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

        private void btSairRemoverVacasLactacao_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RemoverVacaLactacao()
        {
            string query;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            FbCommand fbCmd;
            fbConn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    query = string.Format("UPDATE GADO SET LACTACAO = '0' WHERE ID = {0}", Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                    fbCmd = new FbCommand(query, fbConn);
                    fbCmd.ExecuteNonQuery();
                }
            }
            fbConn.Close();
            MessageBox.Show("Vaca(s) removida(s) da lactação com sucesso");
            carregarDgView();
        }

        private void frmRevomerVacaLactacao_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada; 
            carregarDgView();
        }

        private void btRevomerVacaLactacao_Click_1(object sender, EventArgs e)
        {
            RemoverVacaLactacao();
        }
    }
}