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
    public partial class frmSaidaAnimais : Form
    {
        
        public frmSaidaAnimais()
        {
            InitializeComponent();
        }

        

        private bool cadastroSaida()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert;
            string queryUpdateGado;
            //PARAMETROS
            FbCommand fbCmdInsert = new FbCommand();
            

            if (rbVenda.Checked == true)
            {
                queryUpdateGado = string.Format("UPDATE GADO SET TIPO_CADASTRO = 'VENDIDO' WHERE (ID = {0})",
                    cbGado.SelectedValue.ToString());

                queryInsert = string.Format("INSERT INTO SAIDA_ANIMAIS (ID_GADO, TIPO_SAIDA,PRECO,DATA_SAIDA,OBSERVACAO) VALUES ({0},'VENDIDO',@PRECO,@DATA_SAIDA,@OBS)",
                  cbGado.SelectedValue.ToString());
                fbCmdInsert.Parameters.Add("@PRECO", Convert.ToDouble(txtPrecoVenda.Text));
            }
            else
            {
                queryUpdateGado = string.Format("UPDATE GADO SET TIPO_CADASTRO = 'TROCADO' WHERE (ID = {0})",
                   cbGado.SelectedValue.ToString());

                queryInsert = string.Format("INSERT INTO SAIDA_ANIMAIS (ID_GADO, TIPO_SAIDA,PRECO,DATA_SAIDA,OBSERVACAO) VALUES ({0},'TROCADO',0,@DATA_SAIDA,@OBS)",
                  cbGado.SelectedValue.ToString());
            }
            fbCmdInsert.Parameters.Add("@DATA_SAIDA", Convert.ToDateTime(txtDataVenda.Text));
            fbCmdInsert.Parameters.Add("@OBS", txtObs.Text);
            FbCommand fbCmdUpdate = new FbCommand(queryUpdateGado, fbConn);

            try
            {

                fbConn.Open();
                fbCmdInsert.Connection = fbConn;
                fbCmdInsert.CommandType = CommandType.Text;
                fbCmdInsert.CommandText = queryInsert;
                fbCmdInsert.ExecuteNonQuery();
                fbCmdUpdate.ExecuteNonQuery();
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
           

            if ((txtDataVenda.Text == "  /  /") || (cbGado.Text == "") || ((rbTroca.Checked != true) && (rbVenda.Checked != true)) || ((rbVenda.Checked == true) && (txtPrecoVenda.Text == "")))
                MessageBox.Show("Preencher todos os dados corretamente");
            else
            {
                if (cadastroSaida())
                {
                    MessageBox.Show("Item armazenado com sucesso");
                    cbGado.Text = "";
                    txtDataVenda.Clear();
                    txtPrecoVenda.Clear();
                    txtObs.Clear();
                    atualizarCb();
                }

            }
        }

        private void atualizarCb()
        {

            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID, NOME, NUMERO FROM GADO WHERE ((TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') AND (ID_FAZENDA = {0}))",
                frmHome.IDFazendaSelecionada);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    string s = r[1].ToString() + " - " + r[2].ToString();
                    retorno.Add(Convert.ToInt32(r[0].ToString()), s);
                }
                if (retorno.Count != 0)
                {
                    cbGado.DataSource = new BindingSource(retorno, null);
                    cbGado.DisplayMember = "Value";
                    cbGado.ValueMember = "Key";
                    cbGado.Refresh();
                }
                else
                {
                    MessageBox.Show("Não há nenhum gado cadastrado, cadastre um gado primeiro");
                    Close();
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

        private void frmSaidaAnimais_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            atualizarCb();
       
        }

        

       
    }
}
