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
    
    public partial class fmrAlterarPiquet : Form
    {
        public fmrAlterarPiquet()
        {
            InitializeComponent();
        }

        private bool carregado = false;
        private void fmrAlterarPiquet_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDgView();
            carregado = true;
        }

        private void carregarDgView()
        {
            string squery;

            squery = string.Format("SELECT ID, NOME, NUMERO FROM PIQUET WHERE ID_FAZENDA = {0}",
                frmHome.IDFazendaSelecionada);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();


                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);

                dgPiquets.DataSource = dtUsuarios;
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

        private bool atualizarPiquet(int ID)
        {
            bool retorno = true;
            string squery = string.Format("UPDATE PIQUET SET NOME = '{0}', NUMERO = '{1}' where id = {2}",
                    txtNovoNomePiquet.Text,txtNovoNumeroPiquet.Text, ID);
          
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
                    retorno = false;
                }
                finally
                {
                    fbConn.Close();
                }
              
            
            return retorno;
        }

        private void fmrAlterarPiquet_Activated(object sender, EventArgs e)
        {
            if (dgPiquets.SelectedRows.Count > 0)
            {
                btAlterarPiquet.Enabled = true;
                txtNovoNomePiquet.Text = dgPiquets.SelectedRows[0].Cells[1].Value.ToString();
                txtNovoNumeroPiquet.Text = dgPiquets.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
                btAlterarPiquet.Enabled = false;

        }

        private void fmrAlterarPiquet_Load(object sender, EventArgs e)
        {

        }

        private void btAlterarPiquet_Click(object sender, EventArgs e)
        {
            if (dgPiquets.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgPiquets.SelectedRows[0].Cells[0].Value);
                if (atualizarPiquet(id))
                {
                    MessageBox.Show("Piquet atualizado com sucesso");
                    carregarDgView();
                    txtNovoNumeroPiquet.Clear();
                    txtNovoNomePiquet.Clear();
                }
            }
        }

        private void removerPiquet(int ID)
        {
            string squery = string.Format("DELETE FROM PIQUET SEMEN WHERE ID = {0}",
                ID);
            if (MessageBox.Show("Você tem certeza que deseja remover este piquet", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void dgPiquets_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (carregado)
            {
                int id = Convert.ToInt32(e.Row.Cells[0].Value);
                removerPiquet(id);
            }
        }
    }
}
