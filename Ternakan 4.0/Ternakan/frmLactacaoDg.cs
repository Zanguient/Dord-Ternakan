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
    public partial class frmLactacaoDg : Form
    {
        private bool carregado;
        public frmLactacaoDg()
        {
            InitializeComponent();
        }
        private void removerLactacao(int ID)
        {
            string squery = string.Format("DELETE FROM LACTACAO_DIA WHERE ID = {0}",
                ID);
            if (MessageBox.Show("Você tem certeza que deseja remover esta lactação da lista?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void carregarDgView()
        {
            string squery;

            squery = string.Format("SELECT lactacao_dia.id, lactacao_dia.data, lactacao_dia.producao, lactacao_dia.tirada, gado.nome from gado, lactacao_dia where (gado.id = lactacao_dia.id_gado AND gado.id_fazenda = {0})", frmHome.IDFazendaSelecionada);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();


                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);

                dgLactacao.DataSource = dtUsuarios;

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

        private void dgLactacao_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (carregado)
            {
                int id = Convert.ToInt32(e.Row.Cells[0].Value);
                removerLactacao(id);
            }
        }

        private void frmLactacaoDg_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregado = true;
            carregarDgView();

        }
    }
}
