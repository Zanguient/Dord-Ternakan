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
    public partial class frmResultadoBusca : Form
    {
        private string queryOriginal;
        public frmResultadoBusca()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        

        public void busca(string squery)
        {
            queryOriginal = squery;
            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);
            
            try
            {
                fbConn.Open();
                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);
                dgResultadoBusca.DataSource = dtUsuarios;
                dgResultadoBusca.Refresh();
                //Altera a aparencia do dg
                dgResultadoBusca.Columns["ID"].Visible = false;
                DataGridViewCheckBoxColumn cbxSelecionar = new DataGridViewCheckBoxColumn();
                cbxSelecionar.Name = "CBX";
                cbxSelecionar.HeaderText = " ";
                cbxSelecionar.DisplayIndex = 0;
                cbxSelecionar.Width = 20;
                cbxSelecionar.ReadOnly = false;
                dgResultadoBusca.Columns.Add(cbxSelecionar);

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
        private void btSairResultadoBusca_Click(object sender, EventArgs e)
        {
            if (dgResultadoBusca.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgResultadoBusca.SelectedRows[0].Cells["ID"].Value);

                frmPerfilGado frm = new frmPerfilGado();
                frm.carregarDg(id);
                frm.ShowDialog();
     
            }
        }

        private void dgResultadoBusca_SelectionChanged(object sender, EventArgs e)
        {
            btSelecionar.Enabled = (dgResultadoBusca.SelectedRows.Count > 0);
            dgResultadoBusca.Refresh();
        }

        private void frmResultadoBusca_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada;


        }

        private void frmResultadoBusca_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btImprimirGadoRegistrado_Click(object sender, EventArgs e)
        {
            LinkedList<int> link = new LinkedList<int>();
           
            for (int i = 0; i < dgResultadoBusca.Rows.Count; i++)
            {
                if (dgResultadoBusca.Rows[i].Cells[0].Value != null)
                {
                    link.AddLast(Convert.ToInt32(dgResultadoBusca.Rows[i].Cells["ID"].Value.ToString()));

                }
            }
            VerRelatorio frm = new VerRelatorio();
            frm.carregarRelatorioPerfilGado(link);
            frm.ShowDialog();


        }

        private void dgResultadoBusca_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgResultadoBusca.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgResultadoBusca.SelectedRows[0].Cells["ID"].Value);


                frmPerfilGado frm = new frmPerfilGado();
                frm.carregarDg(id);
                frm.ShowDialog();
            }
        }

        private void btAlterarPiquet_Click(object sender, EventArgs e)
        {
            List<int> idsSelecionados = new List<int>();
            bool alterarPiquet = false;
            for (int i = 0; i < dgResultadoBusca.RowCount; i++)
            {
                if (Convert.ToBoolean(dgResultadoBusca["CBX", i].Value) == true)
                {
                    alterarPiquet = true;
                    idsSelecionados.Add(Convert.ToInt32(dgResultadoBusca["ID",i].Value.ToString()));
                }
            }
            if (alterarPiquet)
            {
                frmAlterarPiquetGados frm = new frmAlterarPiquetGados();
                frm.ids = idsSelecionados;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum gado selecionado!\nClique na caixinha para selecionar.");
            }
            idsSelecionados.Clear();
        }
    }
}
