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
    public partial class frmSelecionarFazenda : Form
    {
        private bool logado = false;
        public frmSelecionarFazenda()
        {
            InitializeComponent();
        }

        private void carregarCbFazenda()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = "SELECT ID, NOME FROM FAZENDA ORDER BY NOME";
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    retorno.Add(Convert.ToInt32(r[0].ToString()), r[1].ToString());
                }
                if (retorno.Count != 0)
                {
                    cbListaFazendasCadastradas.DataSource = new BindingSource(retorno, null);
                    cbListaFazendasCadastradas.DisplayMember = "Value";
                    cbListaFazendasCadastradas.ValueMember = "Key";
                    cbListaFazendasCadastradas.Refresh();
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

        private bool temUsuarios(int IDFazenda)
        {
            
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = "SELECT ID, ID_FAZENDA FROM USUARIO";
            FbCommand fbCmd = new FbCommand(query, fbConn);
            bool retorno = false;
            try
            {
                fbConn.Open();
                FbDataReader r = fbCmd.ExecuteReader();
                if (r.Read())
                {
                    retorno = true;
                }
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");
            }
            finally
            {
                fbConn.Close();
            }
            return retorno;
        }
        private void frmSelecionarFazenda_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada;
            //Evitar erros no primeiro acesso
           
            carregarCbFazenda();
            while ( cbListaFazendasCadastradas.Items.Count == 0)
            {
                if (MessageBox.Show("Não há fazenda cadastradas\nDeseja cadastrar?", "Informação", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                    break;
                }
                else
                {
                    frmFazendaCadastro frm = new frmFazendaCadastro();
                    frm.ShowDialog();
                    carregarCbFazenda();
                }
            }    

        }

        private void logar()
        {
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = "SELECT ID, ID_FAZENDA, USUARIO, SENHA, PERMISSAO FROM USUARIO WHERE ((USUARIO = @USUARIO) AND (SENHA = @SENHA))";
            FbCommand fbCmd = new FbCommand(query, fbConn);
           
            try
            {
                //PARAMETROS
                FbParameter[] prmParametro = new FbParameter[3];

                prmParametro[0] = new FbParameter("@ID_FAZENDA", Convert.ToInt32(cbListaFazendasCadastradas.SelectedValue));
                prmParametro[1] = new FbParameter("@USUARIO", txtUsuario.Text);
                prmParametro[2] = new FbParameter("@SENHA", txtSenha.Text);

                foreach (FbParameter p in prmParametro)
                {

                    fbCmd.Parameters.Add(p);

                }
                if (temUsuarios(Convert.ToInt32(cbListaFazendasCadastradas.SelectedValue)))
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();
                    if (r.Read())
                    {
                        frmHome.admin = (r[4].ToString() == "1");
                        logado = true;
                        frmHome.logado = true;
                        frmHome.IDFazendaSelecionada = Convert.ToInt32(cbListaFazendasCadastradas.SelectedValue);
                        frmHome.NomeFazendaSelecionada = cbListaFazendasCadastradas.Text;
                        frmHome.usuarioSelecionado = txtUsuario.Text;
                        Close();
                        MessageBox.Show("Você está trabalhando na fazenda: "+frmHome.NomeFazendaSelecionada);
                    }
                    else
                    {
                        MessageBox.Show(@"Usuário e/ou Senha inválida");
                    }
                }
                else
                {
                    if (MessageBox.Show("Não há usuários cadastrados.\nDeseja cadastrar agora?", "Informação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmHome.NomeFazendaSelecionada = cbListaFazendasCadastradas.SelectedText;
                        frmHome.IDFazendaSelecionada = Convert.ToInt32(cbListaFazendasCadastradas.SelectedValue);
                        frmCadastroUsuarios frm = new frmCadastroUsuarios();
                        frm.ShowDialog();
                    }
                }



            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");


            }
            finally
            {
                fbConn.Close();
            }
            txtSenha.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
                logar();
        }

        private void frmSelecionarFazenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((logado == false) && (frmHome.logado == false))
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEsqueceuSenha frm = new frmEsqueceuSenha();
            frm.ShowDialog();
        }

    }
}
