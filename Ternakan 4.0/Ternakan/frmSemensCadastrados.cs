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
    public partial class frmSemensCadastrados : Form
    {
        private bool carregado = false;
        public frmSemensCadastrados()
        {
            InitializeComponent();
        }

        private void carregarDgView()
        {
            string squery;

            squery = string.Format("SELECT ID,NOME,RACA,CANECA,REGISTRO,QUANTIDADE FROM SEMEN WHERE (ID_FAZENDA = {0})", frmHome.IDFazendaSelecionada);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();


                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);
                
                dgvSemens.DataSource = dtUsuarios;

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


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            atualizarSemen(e.RowIndex); 
        }

        private bool atualizarSemen(int RowIndex)
        {
            bool retorno = false;
            int ID = Convert.ToInt32(dgvSemens.Rows[RowIndex].Cells[0].Value);
            string squery = string.Format("UPDATE SEMEN SET NOME = @NOME, RACA = @RACA, CANECA = @CANECA, REGISTRO = @REGISTRO, QUANTIDADE = @QUANTIDADE where id = {0}",
                    ID);
           
                FbConnection fbConn = new FbConnection(frmHome.strConn);

                FbCommand fbCmd = new FbCommand();

               //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[5];

            prmParametro[0] = new FbParameter("@NOME", dgvSemens.Rows[RowIndex].Cells[1].Value.ToString());
                prmParametro[1] = new FbParameter("@RACA", dgvSemens.Rows[RowIndex].Cells[2].Value.ToString());
            prmParametro[2] = new FbParameter("@CANECA", dgvSemens.Rows[RowIndex].Cells[3].Value.ToString());
            prmParametro[3] = new FbParameter("@REGISTRO", dgvSemens.Rows[RowIndex].Cells[4].Value.ToString());
            if (!(dgvSemens.Rows[RowIndex].Cells[5].Value is DBNull))
                prmParametro[4] = new FbParameter("@QUANTIDADE", Convert.ToInt32(dgvSemens.Rows[RowIndex].Cells[5].Value));
            else
                prmParametro[4] = new FbParameter("@QUANTIDADE", 0);
          
            foreach (FbParameter p in prmParametro)
            {

               fbCmd.Parameters.Add(p);
            }

            try
            {

                fbConn.Open();
                fbCmd.Connection = fbConn;
                fbCmd.CommandType = CommandType.Text;
                fbCmd.CommandText = squery;
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
                retorno = true;
            return retorno;
        
        }

        private void frmSemensCadastrados_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDgView();
            carregado = true;
        }

        private void dgvSemens_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void removerSemen(int ID)
        {
                string squery = string.Format("DELETE FROM SEMEN WHERE ID = {0}",
                    ID);
                if (MessageBox.Show("Você tem certeza que deseja remover este Semen da lista?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void dgvSemens_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void dgvSemens_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (carregado)
            {
                int id = Convert.ToInt32(e.Row.Cells[0].Value);
                removerSemen(id);
            }
        }
    }
}
