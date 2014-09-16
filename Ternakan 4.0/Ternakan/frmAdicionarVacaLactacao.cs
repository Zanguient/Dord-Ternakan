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
    public partial class frmAdicionarVacaLactacao : Form
    {
       
        public frmAdicionarVacaLactacao()
        {
            InitializeComponent();
        }

        private void carregarGados()
        {
            
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID, NUMERO, NOME FROM GADO WHERE ((SEXO = 'F') AND (LACTACAO = 0) AND(ID_FAZENDA = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') ) ORDER BY NUMERO",
                frmHome.IDFazendaSelecionada);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                string s;
                while (r.Read())
                {
                     s =  r[1].ToString() + " - " +  r[2].ToString();
                    retorno.Add(Convert.ToInt32(r[0].ToString()),s);
                }
                if (retorno.Count != 0)
                {
                    cbNomegadoLactacao.DataSource = new BindingSource(retorno, null);
                    cbNomegadoLactacao.DisplayMember = "Value";
                    cbNomegadoLactacao.ValueMember = "Key";
                    cbNomegadoLactacao.Refresh();
                }
                else
                {
                    MessageBox.Show("Não há vacas cadastradas");
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

        private bool cadastrarVacLactacao()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            int IDGado = Convert.ToInt32(cbNomegadoLactacao.SelectedValue);
            string queryInsert = string.Format("UPDATE GADO SET LACTACAO = 1 WHERE(ID = {0})",
                IDGado);

            FbCommand fbCmdInsert = new FbCommand();

         

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
        
        private void btAdicionarVacaLactacao_Click(object sender, EventArgs e)
        {
            if (cbNomegadoLactacao.Text == "")
                MessageBox.Show("Favor preencher todos os dados");
            else
            {
                if (cadastrarVacLactacao())
                {
                    MessageBox.Show("Vaca Adicionada");
                    carregarGados();
                }
          
            }
        }

        private void btSairAdicionarVacaLactacao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdicionarVacaLactacao_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarGados();
        }

      
    }
}
