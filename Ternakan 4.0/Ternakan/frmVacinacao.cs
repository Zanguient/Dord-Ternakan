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
    public partial class frmVacinacao : Form
    {
        LinkedList<int> link = new LinkedList<int>();
        private const int todosPiquest = 999887;
        public frmVacinacao()
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
                retorno.Add(todosPiquest, "Todos");
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
        private void carregarDgView(int IDpiquet)
        {
            string squery;
            if (IDpiquet == todosPiquest)
                squery = string.Format("SELECT ID, NUMERO, NOME FROM GADO WHERE ((ID_FAZENDA = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO'))", frmHome.IDFazendaSelecionada);
            else
                squery = string.Format("SELECT ID, NUMERO, NOME FROM GADO WHERE ((ID_FAZENDA = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') AND (ID_PIQUET = {1}))", 
                    frmHome.IDFazendaSelecionada, IDpiquet);

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
        private void btVacinar_Click(object sender, EventArgs e)
        {
            frmDadosVacinas frm = new frmDadosVacinas();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    link.AddLast(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                }
            }
            frm.gadosVacinados(link);
            frm.ShowDialog();
            link.Clear();
        }

        void imprimir(LinkedList<int> lista)
        {
            foreach (int item in lista)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVacinacao_Load(object sender, EventArgs e)
        {

        }

        private void frmVacinacao_Shown(object sender, EventArgs e)
        {
            atualizarCbPiquet();
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDgView(todosPiquest);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVacinacao_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btSelecionarTudo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = true;
            }
        }

        private void btDesmarcarTudo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            carregarDgView(Convert.ToInt32(cbPiquet.SelectedValue));
        }
    }
}