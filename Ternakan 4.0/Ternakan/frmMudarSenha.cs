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
    public partial class frmMudarSenha : Form
    {
        public frmMudarSenha()
        {
            InitializeComponent();
        }

        private void btAlterarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenhaNova.Text != txtConfirmacaoSenha.Text)
            {
                MessageBox.Show("As senha nova não confere com sua confirmação de senha. Favor digitá-las novamente.");
                txtSenhaAntiga.Text = "";
                txtConfirmacaoSenha.Text = "";
                txtSenhaNova.Text = "";
            }
            else
            {
                FbConnection fbconn = new FbConnection(frmHome.strConn);
                string query = "SELECT SENHA FROM USUARIO WHERE (USUARIO = @USUARIO)";
                FbCommand fbcmd = new FbCommand();
                FbParameter fbprm = new FbParameter("@USUARIO", frmHome.usuarioSelecionado);
                try
                {
                    fbconn.Open();
                    fbcmd.Parameters.Add(fbprm);
                    fbcmd.Connection = fbconn;
                    fbcmd.CommandType = CommandType.Text;
                    fbcmd.CommandText = query;
                    FbDataReader r;
                    r = fbcmd.ExecuteReader();
                    if (r.Read())
                    {
                        if (r["SENHA"].ToString() == txtSenhaAntiga.Text)
                        {
                            string query2 = "UPDATE USUARIO SET SENHA=@SENHA WHERE (USUARIO = @USUARIO)";
                            FbCommand cmd2 = new FbCommand();
                            FbParameter[] prm2 = new FbParameter[2];
                            prm2[0] = new FbParameter("@SENHA", txtSenhaNova.Text);
                            prm2[1] = new FbParameter("@USUARIO", frmHome.usuarioSelecionado);


                                foreach (FbParameter p in prm2)
                                {
                                    cmd2.Parameters.Add(p);
                                }
                                cmd2.Connection = fbconn;
                                cmd2.CommandType = CommandType.Text;
                                cmd2.CommandText = query2;
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("Senha alterada com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("A senha digitada não confere com a antiga, favor redigitar a senha.");
                            txtSenhaAntiga.Text = "";
                            txtConfirmacaoSenha.Text = "";
                            txtSenhaNova.Text = "";
                        }
                    }
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro no banco de dados: " + fbex.Message);
                }
                finally
                {
                    fbconn.Close();
                }
            }
        }
    }
}
