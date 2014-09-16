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
    public partial class frmLactacaoDia : Form
    {
        
        public frmLactacaoDia()
        {
            InitializeComponent();
        }

        private void atualizarCB()
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Dictionary<int, string> retorno = new Dictionary<int, string>();
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query = string.Format("SELECT ID, NUMERO, NOME FROM GADO WHERE ((SEXO = 'F') AND (LACTACAO = 1) AND(ID_FAZENDA = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') ) ORDER BY NUMERO",
                    frmHome.IDFazendaSelecionada);
                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();
                    string s;
                    while (r.Read())
                    {
                        s = r[1].ToString() + " - " + r[2].ToString();
                        retorno.Add(Convert.ToInt32(r[0].ToString()), s);
                    }
                    if (retorno.Count != 0)
                    {
                        cbVaca.DataSource = new BindingSource(retorno, null);
                        cbVaca.DisplayMember = "Value";
                        cbVaca.ValueMember = "Key";
                        cbVaca.Refresh();
                    }


                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");
                }
                finally
                {
                    fbConn.Close();
                }
               
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
           
        }

        private void frmLactacaoDia_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            atualizarCB();
            txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private bool atualizarLactacaoDia(int ID)
        {
            bool retorno = true;
            string squery = string.Format("UPDATE LACTACAO_DIA SET PRODUCAO = {0} WHERE (ID = {1})",
                    txtProducao.Text, ID);

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

        private bool cadastrarLactacaoDia()
        {
            bool retorno = false;
            int IDVaca = Convert.ToInt32(cbVaca.SelectedValue);
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO LACTACAO_DIA (ID_GADO, DATA, PRODUCAO, TIRADA) VALUES ({0}, @DATA, @PRODUCAO, @TIRADA)",
                IDVaca);
            string querySelect = string.Format("SELECT ID FROM LACTACAO_DIA WHERE ((ID_GADO = {0}) AND (DATA = @DATA) AND (TIRADA = '{1}'))",
                IDVaca, cbTirada.Text);

            FbCommand fbCmdInsert = new FbCommand();
            FbCommand fbCmdSelect = new FbCommand();


            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[3];

            prmParametro[0] = new FbParameter("@DATA", Convert.ToDateTime(txtData.Text));
            prmParametro[1] = new FbParameter("@PRODUCAO", Convert.ToInt32(txtProducao.Text));
            prmParametro[2] = new FbParameter("@TIRADA", cbTirada.Text);

            foreach (FbParameter p in prmParametro)
            {
                fbCmdInsert.Parameters.Add(p);
            }

            fbCmdSelect.Parameters.Add("@DATA", Convert.ToDateTime(txtData.Text));

            try
            {
                fbConn.Open();
                fbCmdSelect.Connection = fbConn;
                fbCmdSelect.CommandType = CommandType.Text;
                fbCmdSelect.CommandText = querySelect;
                FbDataReader r = fbCmdSelect.ExecuteReader();

                if (r.Read())
                {
                    if (MessageBox.Show("A vaca selecionada já tem uma produção associada a este dia.\nDeseja alterá-la?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (atualizarLactacaoDia(Convert.ToInt32(r[0])))
                        {
                            MessageBox.Show("Atualizado com sucesso");
                        }
                        retorno = false;
                    }
                }
                else
                {
                    fbCmdInsert.Connection = fbConn;
                    fbCmdInsert.CommandType = CommandType.Text;
                    fbCmdInsert.CommandText = queryInsert;
                    fbCmdInsert.ExecuteNonQuery();
                    retorno = true;
                }
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
        private void btGravar_Click(object sender, EventArgs e)
        {
            if (cadastrarLactacaoDia())
            {
                MessageBox.Show("Adicionado com sucesso");
                txtProducao.Clear();
            }
        }

        private void txtProducao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > '0') && (e.KeyChar < '9')))
                e.Handled = false;
        }

   
    }
}
