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
    public partial class frmEscolherPiquet : Form
    {
        public frmEscolherPiquet()
        {
            InitializeComponent();
        }
        private void atualizarCbPiquet()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format( "SELECT ID, NOME, NUMERO FROM PIQUET WHERE ID_FAZENDA = {0} ORDER BY NUMERO", frmHome.IDFazendaSelecionada);
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
                    cbPiquetRelatorio.DataSource = new BindingSource(retorno, null);
                    cbPiquetRelatorio.DisplayMember = "Value";
                    cbPiquetRelatorio.ValueMember = "Key";
                    cbPiquetRelatorio.Refresh();
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

        private void btImprimirPiquet_Click(object sender, EventArgs e)
        {
            int IDPiquet = Convert.ToInt32(cbPiquetRelatorio.SelectedValue);
            VerRelatorio frm = new VerRelatorio();
            frm.carregarPiquet(IDPiquet);
            frm.ShowDialog();
        }

        private void frmEscolherPiquet_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            atualizarCbPiquet();
        }
    }
}