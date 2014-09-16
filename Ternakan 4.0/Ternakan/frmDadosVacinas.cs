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
    public partial class frmDadosVacinas : Form
    {
        LinkedList<int> list = new LinkedList<int>();
        public frmDadosVacinas()
        {
            InitializeComponent();
        }

        private void btConfirmaMedicamento_Click(object sender, EventArgs e)
        {
            FbConnection fbconn = new FbConnection(frmHome.strConn);
            if (txtDataMedicacao.Text == "  /  /")
                MessageBox.Show("Preencher a data da aplicação");
            else if (txtNomeMedicamento.Text == "")
                MessageBox.Show("Preencher Nome do medicamento");
            else
            {
                string query;
                int i = 0;
                try
                {
                    FbCommand fbcmd = new FbCommand();
                    fbconn.Open();
                    FbParameter[] fbprm = new FbParameter[2];
                    foreach (int num in list)
                    {
                        query = string.Format("INSERT INTO VACINACA (ID_GADO,NOME,DATA_APLICACAO) VALUES ({0},@NOME,@DATA_APLICACAO)",num.ToString());
                        fbprm[0] = new FbParameter("@NOME", txtNomeMedicamento.Text);
                        fbprm[1] = new FbParameter("@DATA_APLICACAO", Convert.ToDateTime(txtDataMedicacao.Text));
                        foreach (FbParameter p in fbprm)
                        {
                            fbcmd.Parameters.Add(p);
                        }
                        fbcmd.Connection = fbconn;
                        fbcmd.CommandType = CommandType.Text;
                        fbcmd.CommandText = query;
                        fbcmd.ExecuteNonQuery();
                        i++;
                    }
                    if (txtDataProxVacina.Text != "  /  /")
                    {
                        FbCommand comando = new FbCommand();
                        FbParameter[] prm = new FbParameter[2];
                        string queryInsert = string.Format("INSERT INTO AGENDA (EVENTO,DATA_ALERTA, ALERTADO) VALUES (@EVENTO,@DATA_ALERTA,0)");
                        prm[0] = new FbParameter("@EVENTO", "Vacina " + txtNomeMedicamento.Text);
                        prm[1] = new FbParameter("@DATA_ALERTA", Convert.ToDateTime(txtDataProxVacina.Text));
                        foreach (FbParameter p in prm)
                        {
                            comando.Parameters.Add(p);
                        }
                        comando.Connection = fbconn;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = queryInsert;
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                MessageBox.Show("Vacina cadastrada com sucesso");
                if (rbOutroMedicamentoSim.Checked == true)
                {
                    txtNomeMedicamento.Clear();
                    txtDataMedicacao.Clear();
                    rbOutroMedicamentoSim.Checked = false;
                    rbOutroMedicamentoNao.Checked = false;
                }
                else
                {
                    Close();
                }
            }
        }

        private void btVoltardadosVacina_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void gadosVacinados(LinkedList<int> link)
        {
            foreach (int elto in link)
            {
                list.AddLast(elto);
            }
        }

        private void frmDadosVacinas_Load(object sender, EventArgs e)
        {

        }

        private void frmDadosVacinas_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void frmDadosVacinas_FormClosing(object sender, FormClosingEventArgs e)
        {
            list.Clear();
        }

        private void frmDadosVacinas_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmDadosVacinas_Load_1(object sender, EventArgs e)
        {

        }
    }
}