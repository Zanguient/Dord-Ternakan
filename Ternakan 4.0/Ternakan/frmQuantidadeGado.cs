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
    public partial class frmQuantidadeGado : Form
    {
        private bool carregarPiquet = false;
        public frmQuantidadeGado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btFecharQuantidadeGado_Click(object sender, EventArgs e)
        {
            Close();
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

        private void frmQuantidadeGado_Shown(object sender, EventArgs e)
        {
            atualizarCbPiquet();
            Text += " - " + frmHome.NomeFazendaSelecionada;
            int qmacho = 0;
            int femea = 0;
            int total = 0;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID FROM GADO WHERE ((SEXO = 'M') AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') AND (ID_FAZENDA = {0}))",frmHome.IDFazendaSelecionada);
            string query2 = string.Format("SELECT ID FROM GADO WHERE((TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') AND (ID_FAZENDA = {0}))",frmHome.IDFazendaSelecionada);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            FbCommand fbCmd2 = new FbCommand(query2, fbConn);
            try
            {
                fbConn.Open();
                FbDataReader fbDa = fbCmd.ExecuteReader();
                FbDataReader fbDa2 = fbCmd2.ExecuteReader();
                while (fbDa.Read())
                {
                    qmacho++;
                }
                while (fbDa2.Read())
                {
                    total++;
                }
                femea = total - qmacho;
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
            }
            finally
            {
                fbConn.Close();
            }
            lbQuantidadeGadoFemea.Text = femea.ToString();
            lbQuantidadeGadoMacho.Text = qmacho.ToString();
            lbQuantidadeGadoTotal.Text = total.ToString();
            carregarPiquet = true;
        }

        private void frmQuantidadeGado_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void cbPiquet_SelectedValueChanged(object sender, EventArgs e)
        {
            int qpiquet = 0;
            if (carregarPiquet)
            {
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                try
                {
                    string query = string.Format("SELECT ID FROM GADO WHERE ((ID_PIQUET = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') AND (ID_FAZENDA = {1}))",
                        Convert.ToInt32(cbPiquet.SelectedValue), frmHome.IDFazendaSelecionada);
                    FbCommand fbCmd = new FbCommand(query, fbConn);
                    fbConn.Open();
                    FbDataReader fbDa = fbCmd.ExecuteReader();
                    while (fbDa.Read())
                    {
                        qpiquet++;
                    }
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
                }
                finally
                {
                    fbConn.Close();
                }
                lblqntPiquet.Text = qpiquet.ToString();
            }
        }
    }
}
