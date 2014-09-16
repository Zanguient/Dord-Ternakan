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
    public partial class frmAlterarPiquetGados : Form
    {
        public List<int> ids;
        public frmAlterarPiquetGados()
        {
            InitializeComponent();
        }

        private void atualizarCbPiquet()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID, NOME, NUMERO FROM PIQUET WHERE ID_FAZENDA = {0}", frmHome.IDFazendaSelecionada);
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
                    cbPiquet.DataSource = new BindingSource(retorno, null);
                    cbPiquet.DisplayMember = "Value";
                    cbPiquet.ValueMember = "Key";
                    cbPiquet.Refresh();
                }
                else
                {
                    MessageBox.Show("Não há piquets cadastrados para esta fazenda.\nCadastre um piquet primeiro");
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

        private void cbPiquet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btOK_Click(sender, e);

        }

        private bool alterarPiquet(int IDGado)
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            FbCommand fbCmd = new FbCommand();
            string query = string.Format("UPDATE GADO SET ID_PIQUET = {0} WHERE (ID = {1})",
                Convert.ToInt32(cbPiquet.SelectedValue), IDGado);
            try
            {
                fbConn.Open();
                fbCmd.Connection = fbConn;
                fbCmd.CommandType = CommandType.Text;
                fbCmd.CommandText = query;
                fbCmd.ExecuteNonQuery();
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

        private void btOK_Click(object sender, EventArgs e)
        {
            bool estahTudoCerto = true;
            for (int i = 0; (i < ids.Count) && estahTudoCerto; i++)
            {
                estahTudoCerto = alterarPiquet(ids[i]);
            }

            if (estahTudoCerto)
            {
                MessageBox.Show("Piquets alterados com sucesso!");
                Close();
            }
        }

        private void frmAlterarPiquetGados_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            lblPiquet.Text = String.Format("Você vai alterar o piquet de {0} gados",
                ids.Count);
            atualizarCbPiquet();
        }
    }
}
