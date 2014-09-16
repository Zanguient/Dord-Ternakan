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
    public partial class frmGadoRegistrado : Form
    {
        public frmGadoRegistrado()
        {
            InitializeComponent();
        }

        private void btSairgadoRegistrado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGadoRegistrado_Resize(object sender, EventArgs e)
        {
            panel1.Width = Width;
        }

        public void carregarDataGridView()
        {
            string squery = "SELECT ID, NUMERO, NOME, PELAGEM, RACA, NUMERO_REGISTRO FROM GADO WHERE ((NUMERO_REGISTRO != '') AND ((TIPO_CADASTRO != 'MORTO') OR (TIPO_CADASTRO != 'VENDIDO') OR (TIPO_CADASTRO != 'TROCADO')))";
            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();
                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);
                dgvGadosRegistrados.DataSource = dtUsuarios;
                dgvGadosRegistrados.Refresh();
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
  
        private void frmGadoRegistrado_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDataGridView();
            dgvGadosRegistrados.Refresh();
        }

        private void btImprimirGadoRegistrado_Click(object sender, EventArgs e)
        {

            frmImprimirRelatorioRegistrado frm = new frmImprimirRelatorioRegistrado();
            frm.ShowDialog();

        }

        private void dgvGadosRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
