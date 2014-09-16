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
    public partial class frmCadastroUsuarios : Form
    {
        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {

        }

        

        private void frmCadastroUsuarios_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;           
        }

        private bool cadastrarUsuario()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO USUARIO (ID_FAZENDA, USUARIO, PERMISSAO, SENHA,DICA,RESPOSTADICA) VALUES ({0},@USUARIO,@PERMISSAO,@SENHA,@DICA,@RESPOSTADICA)",
                frmHome.IDFazendaSelecionada);
            
            FbCommand fbCmdInsert = new FbCommand();
            
            int permissao = 0;
            if (cbAdmin.Checked)
                permissao = 1;
            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[5];

            prmParametro[0] = new FbParameter("@USUARIO", txtUsuario.Text);
            prmParametro[1] = new FbParameter("@PERMISSAO", permissao);
            prmParametro[2] = new FbParameter("@SENHA", txtSenha.Text);
            prmParametro[3] = new FbParameter("@DICA", cbbDicas.Text);
            prmParametro[4] = new FbParameter("@RESPOSTADICA", txtRespostaDica.Text);
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
            if (txtConfirmacaoSenhaCadastro.Text != txtSenha.Text)
            {
                MessageBox.Show("As senhas não conferem. Favor digitá-las novamente.");
                Close();
            }
            else if (txtUsuario.Text == "" || txtSenha.Text == "" || txtRespostaDica.Text == "" || cbbDicas.Text == "")
            {
                MessageBox.Show("Favor preencher os campos corretamente");
            }
            else
            {
                if (cadastrarUsuario())
                {
                    MessageBox.Show("Usuário Cadastrado com sucesso");
                    Close();
                }
            }
        }

        private void frmCadastroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
