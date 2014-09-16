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
    public partial class frmTrabalhadoresInativos : Form
    {
        public frmTrabalhadoresInativos()
        {
            InitializeComponent();
        }

        private void pesquisar(string nome)
        {
            string squery = string.Format("SELECT ID, NOME as \"Nome\", DATA_TRABALHO as \"Data da contratação\", DATA_NASCIMENTO as \"Data do aniversário\" FROM TRABALHADOR WHERE ((ATIVIDADE = 0) AND (ID_FAZENDA = {0}) AND (NOME like '{1}%')) ",
                 frmHome.IDFazendaSelecionada,nome);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();
                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);
                dgvTrabalhadores.DataSource = dtUsuarios;
                dgvTrabalhadores.Refresh();
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

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
                pesquisar(txtPesquisar.Text);
        }

        private void frmTrabalhadoresInativos_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            pesquisar("");
            txtPesquisar.Clear();
            txtPesquisar.Focus();
            btImprimir.Visible = frmHome.admin;
            btApagar.Visible = frmHome.admin;
        }

        private bool removerTrabalhador(int ID)
        {
            bool retorno = true;
            string squery = string.Format("DELETE FROM TRABALHADOR WHERE ID = {0}",
                    ID);
            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();
                fbCmd.ExecuteNonQuery();
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados " + fbex.Message, "Erro");
                retorno = false;
            }
            finally
            {
                fbConn.Close();
            }
            return retorno;
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (dgvTrabalhadores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voce tem certeza que deseja apagar definitivamente este trabalhador do banco de dados?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (removerTrabalhador(Convert.ToInt32(dgvTrabalhadores.SelectedRows[0].Cells[0].Value)))
                    {
                        MessageBox.Show("Trabalhado removido com sucesso");
                        pesquisar("");
                        txtPesquisar.Clear();
                        txtPesquisar.Focus();
                    }
                }
            }
            else
                MessageBox.Show("Selecione um trabalhado primeiro");

        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            VerRelatorio frm = new VerRelatorio();
            frm.carregarDsTrabalhadoresInativos(txtPesquisar.Text);
            frm.ShowDialog();
        }
    }
}
