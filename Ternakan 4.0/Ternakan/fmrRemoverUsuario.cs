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
    public partial class fmrRemoverUsuario : Form
    {
        public fmrRemoverUsuario()
        {
            InitializeComponent();
        }
        private void pesquisar()
        {
            string squery = string.Format("SELECT ID, USUARIO, PERMISSAO FROM USUARIO WHERE ID_FAZENDA = {0}",
                frmHome.IDFazendaSelecionada);

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

        private void btRemoverUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string squery = string.Format("DELETE FROM USUARIO WHERE ID = {0}",
                    ID);
                if (MessageBox.Show("Você tem certeza que deseja remover este usuario da lista?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    pesquisar();
                }
            }
        }

        private void fmrRemoverUsuario_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            pesquisar();
            btRemoverUsuario.Enabled = (dataGridView1.SelectedRows.Count > 0);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btRemoverUsuario.Enabled = (dataGridView1.SelectedRows.Count > 0);
        }
    }
}
