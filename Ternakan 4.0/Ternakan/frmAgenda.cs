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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }


        private bool atualizarAgenda(int RowIndex)
        {
            bool retorno = false;
            int ID = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[0].Value);
            string squery = string.Format("UPDATE AGENDA SET EVENTO = @EVENTO, DATA_ALERTA = @DATA_ALERTA where id = {0}",
                    ID);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand();

            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[2];

            prmParametro[0] = new FbParameter("@EVENTO", dataGridView1.Rows[RowIndex].Cells[1].Value.ToString());
            DateTime novaData;
            try
            {
                novaData = Convert.ToDateTime(dataGridView1.Rows[RowIndex].Cells[2].Value);
            }
            catch (Exception)
            {
                novaData = DateTime.Today;
                
            }

            prmParametro[1] = new FbParameter("@DATA_ALERTA", novaData);

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

        private void removerEventoAgenda(int ID)
        {
            string squery = string.Format("DELETE FROM AGENDA WHERE ID = {0}",
                ID);
            if (MessageBox.Show("Você tem certeza que deseja remover este evento da agenda?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void btSairAgenda_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void frmAgenda_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDgView();
        }

        private void carregarDgView()
        {
            string squery;

            squery = "SELECT ID, EVENTO, DATA_ALERTA FROM AGENDA";




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

        private bool cadastrarEvento()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO AGENDA (EVENTO,DATA_ALERTA, ALERTADO) VALUES (@EVENTO,@DATA_ALERTA,0)");

            FbCommand fbCmdInsert = new FbCommand();


            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[2];
            prmParametro[0] = new FbParameter("@EVENTO", textBox1.Text);
            prmParametro[1] = new FbParameter("@DATA_ALERTA", maskedTextBox1.Text);

            foreach (FbParameter p in prmParametro)
            {
                fbCmdInsert.Parameters.Add(p);
            }

            try
            {
                fbConn.Open();
                fbCmdInsert.Connection = fbConn;
                fbCmdInsert.CommandType = CommandType.Text;
                fbCmdInsert.CommandText = queryInsert;
                fbCmdInsert.ExecuteNonQuery();
                retorno = true;
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");
                retorno = false;
            }
            finally
            {
                fbConn.Close();
            }
            return retorno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool retorno;
            try
            {
                retorno = cadastrarEvento();
                if (retorno)
                {
                    MessageBox.Show("Evento cadastrado com sucesso");
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                    carregarDgView();
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("Erro ao gravar\n" + ee.Message);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            atualizarAgenda(e.RowIndex);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int id = Convert.ToInt32(e.Row.Cells[0].Value);
            removerEventoAgenda(id);
        }
    }
}