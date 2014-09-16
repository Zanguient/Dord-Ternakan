using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Threading;

namespace Ternakan
{
    public partial class frmVerHistorico : Form
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public frmVerHistorico()
        {
            InitializeComponent();
        }

        private void btVerHistorico_Click(object sender, EventArgs e)
        {

        }

        private void frmVerHistorico_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            string query = string.Format("SELECT ID,DATA,OBS FROM HISTORICO WHERE (ID_GADO = {0})", Id.ToString());
            FbConnection fbconn = new FbConnection(frmHome.strConn);
            FbCommand fbcmd = new FbCommand(query, fbconn);
            try
            {
                fbconn.Open();
                FbDataAdapter fbda = new FbDataAdapter(fbcmd);
                DataTable dt = new DataTable();
                fbda.Fill(dt);
                dgVerHistorico.DataSource = dt;
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar banco de dados: " + fbex.Message);
            }
            finally
            {
                fbconn.Close();
                dgVerHistorico.Columns[0].ReadOnly = true;
            }
        }

        private void dgVerHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVerHistorico.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgVerHistorico.SelectedRows[0].Cells[0].Value);
                frmVisualizarHistorico frm = new frmVisualizarHistorico();
                frm.Id = id;
                frm.ShowDialog();
            }
        }

        private void dgVerHistorico_Click(object sender, EventArgs e)
        {
            if (dgVerHistorico.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgVerHistorico.SelectedRows[0].Cells[0].Value);
                frmVisualizarHistorico frm = new frmVisualizarHistorico();
                frm.Id = id;
                frm.ShowDialog();
            }
        }
    }
}
