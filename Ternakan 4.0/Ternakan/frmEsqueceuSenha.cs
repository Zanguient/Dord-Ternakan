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
    public partial class frmEsqueceuSenha : Form
    {
        string resposta;
        string senha;
        bool passou = false;
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void frmEsqueceuSenha_Load(object sender, EventArgs e)
        {
        }
        private void carregarCbUsuario()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = "SELECT ID, USUARIO FROM USUARIO ORDER BY USUARIO";
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
                    cbUsuarios.DataSource = new BindingSource(retorno, null);
                    cbUsuarios.DisplayMember = "Value";
                    cbUsuarios.ValueMember = "Key";
                    cbUsuarios.Refresh();
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
        private void frmEsqueceuSenha_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarCbUsuario();
            cbUsuarios.Text = "";
            passou = true;
        }

        private void cbUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void btVerSenha_Click(object sender, EventArgs e)
        {
            if (txtRespostaDica.Text.ToLower() == resposta.ToLower())
            {
                string str;
                str = string.Format("Sua senha é {0} Deseja alterá-la?", senha);

                if ((MessageBox.Show(str, "Alterar senha", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    frmMudarSenha frm = new frmMudarSenha();
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("A resposta da dica não confere. Favor tentar novamente");
            }
        }

        private void selecionarUsuario()
        {
            if (passou)
            {
                FbConnection fbconn = new FbConnection(frmHome.strConn);
                string query = string.Format("SELECT SENHA,DICA,RESPOSTADICA FROM USUARIO WHERE ID = {0}", cbUsuarios.SelectedValue.ToString());
                FbCommand fbcmd = new FbCommand(query, fbconn);
                FbDataReader r;
                try
                {
                    fbconn.Open();
                    r = fbcmd.ExecuteReader();
                    if (r.Read())
                    {
                        lbNomeDica.Text = "Dica: " + r["DICA"].ToString();
                        resposta = r["RESPOSTADICA"].ToString();
                        senha = r["SENHA"].ToString();
                    }
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + fbex.Message);
                }
                finally
                {
                    fbconn.Close();
                }
                frmHome.usuarioSelecionado = cbUsuarios.Text;
            }
        }

        private void cbUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            selecionarUsuario();
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbUsuarios_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
