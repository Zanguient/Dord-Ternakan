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
    public partial class frmMortalidade : Form
    {
      
        public frmMortalidade()
        {
            InitializeComponent();
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

        private bool cadastroMortalidade()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO MORTALIDAE (ID, CAUSA, OBS, DATA_MORTE) VALUES ({0},@CAUSA,@OBS,@DATA_MORTE)",
                  cbGado.SelectedValue.ToString());
            string queryUpdateGado = string.Format("UPDATE GADO SET TIPO_CADASTRO = 'MORTO' WHERE (ID = {0})",
                cbGado.SelectedValue.ToString());

            FbCommand fbCmdInsert = new FbCommand();
            FbCommand fbCmdUpdate = new FbCommand(queryUpdateGado, fbConn);


            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[3];

            prmParametro[0] = new FbParameter("@CAUSA", txtCasoMorte.Text);
            prmParametro[1] = new FbParameter("@OBS", rtObservacoesGadoMorto.Text);
            prmParametro[2] = new FbParameter("@DATA_MORTE", Convert.ToDateTime(txtDataMorte.Text));
         
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

           if (cbGado.Text == "")
                MessageBox.Show("Selecione o animal");
            else if (txtDataMorte.Text == "  /  /")
                MessageBox.Show("Preencher a data da morte do animal");
            else
            {
                try
                {
                    if (cadastroMortalidade())
                    {
                        MessageBox.Show("Dados armazenados com sucesso");
                        txtCasoMorte.Clear();
                        txtDataMorte.Clear();
                        rtObservacoesGadoMorto.Clear();
                        cbGado.Text = "";
                        atualizarCb();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Erro de banco de dados\n" + ee.Message);
                }
            }
        }

        private void btSairMortalidade_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void frmMortalidade_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            atualizarCb();
        }
    }
}
