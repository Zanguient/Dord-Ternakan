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
    public partial class frmFazendaCadastro : Form
    {
        public frmFazendaCadastro()
        {
            InitializeComponent();
        }

        private bool cadastrarFazenda()
        {
            
                bool retorno;
            try
            {
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string queryInsert = string.Format("INSERT INTO FAZENDA (NOME,ENDERECO,BAIRRO,CEP,CIDADE,ESTADO,COMPLEMENTO,TELEFONE,FAX,EMAIL,SITE,PROPRIETARIO,DATA_NASCIMENTO_PROPRIETARIO,CPF) VALUES (@NOME,@ENDERECO,@BAIRRO,@CEP,@CIDADE,@ESTADO,@COMPLEMENTO,@TELEFONE,@FAX,@EMAIL,@SITE,@PROPRIETARIO,@DATA_NASCIMENTO_PROPRIETARIO,@CPF)");

                FbCommand fbCmdInsert = new FbCommand();


                //PARAMETROS
                FbParameter[] prmParametro = new FbParameter[14];
                prmParametro[0] = new FbParameter("@NOME", txtNomeFazenda.Text);
                prmParametro[1] = new FbParameter("@ENDERECO", txtEndereco.Text);
                prmParametro[2] = new FbParameter("@BAIRRO", txtBairro.Text);
                prmParametro[3] = new FbParameter("@CEP", txtCep.Text);
                prmParametro[4] = new FbParameter("@CIDADE", txtCidade.Text);
                prmParametro[5] = new FbParameter("@ESTADO", txtEstado.Text);
                prmParametro[6] = new FbParameter("@COMPLEMENTO", txtCompleto.Text);
                prmParametro[7] = new FbParameter("@TELEFONE", txtTelefone.Text);
                prmParametro[8] = new FbParameter("@FAX", txtFax.Text);
                prmParametro[9] = new FbParameter("@EMAIL", txtEmail.Text);
                prmParametro[10] = new FbParameter("@SITE", txtSite.Text);
                prmParametro[11] = new FbParameter("@PROPRIETARIO", txtProprietario.Text);
                DateTime dtData = new DateTime();
                DateTime.TryParse(txtDtNascimento.Text,out dtData);
                prmParametro[12] = new FbParameter("@DATA_NASCIMENTO_PROPRIETARIO", dtData);
                prmParametro[13] = new FbParameter("@CPF", txtCPFCNPJ.Text);
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
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro na hora de tratar um dos campos: favor verificar os campos digitados.");
                retorno = false;
            }
            return retorno;
        }

        private bool existeFazenda()
        {
            bool retorno = true;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            FbCommand fbCmd = new FbCommand();
            string query = "SELECT * FROM FAZENDA";
            FbDataReader r;
            try
            {
                fbConn.Open();
                fbCmd.Connection = fbConn;
                fbCmd.CommandType = CommandType.Text;
                fbCmd.CommandText = query;
                r = fbCmd.ExecuteReader();
                while (r.Read() && retorno)
                {
                    if (txtNomeFazenda.Text.ToLower() == r["NOME"].ToString().ToLower())
                    {
                        retorno = false;
                    }
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

        private void btCadastrarFazenda_Click(object sender, EventArgs e)
        {
            if (txtNomeFazenda.Text == "" || txtEndereco.Text == "" || txtBairro.Text == "" || txtCep.Text == "     -" || txtCidade.Text == "" || txtEstado.Text == "" || txtProprietario.Text == "" || txtDtNascimento.Text == "  /  /" || txtTelefone.Text == "(  )    -")
                MessageBox.Show("Favor preencher os campos obrigatórios");
            else
            {
                bool retorno = false;
                bool retorno2;
                retorno2 = existeFazenda();
                if (retorno2 == false)
                {
                    MessageBox.Show("Já existe uma fazenda com esse nome, favor selecionar um nome diferente");
                }
                else
                {
                    retorno = cadastrarFazenda();
                }
                if (retorno)
                {
                    MessageBox.Show("Fazenda cadastrada com sucesso");
                    Close();
                }
            }
        }

    

        private void frmFazendaCadastro_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void frmFazendaCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void frmFazendaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
