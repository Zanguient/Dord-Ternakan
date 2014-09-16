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
    public partial class frmRemoverCruzamento : Form
    {
        LinkedList<int> ids = new LinkedList<int>();
        LinkedList<int> idfemea = new LinkedList<int>();
        public frmRemoverCruzamento()
        {
            InitializeComponent();
        }

        private void btSairRemoverCruzamento_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void carregarDgView()
        {
            string squery;
            string query2;
            int i = 0;
            squery = string.Format("SELECT * FROM CRUZAMENTO WHERE (ID_FAZENDA = {0})", frmHome.IDFazendaSelecionada);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);
            try
            {
                fbConn.Open();
                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    dataGridView1.Rows.Add();
                    if (r["SEMEM"].ToString() == "1")
                    {
                        try
                        {
                            string query3;
                            query2 = string.Format("SELECT NOME FROM SEMEN WHERE (ID = {0})", r["ID_GADO_MACHO"]);
                            FbCommand fbCmd2 = new FbCommand(query2, fbConn);
                            FbDataReader r2 = fbCmd2.ExecuteReader();
                            r2.Read();
                            dataGridView1.Rows[i].Cells["Reprodutor"].Value = r2["NOME"].ToString();
                            dataGridView1.Rows[i].Cells["Numero"].Value = "0";
                            query3 = string.Format("SELECT NOME, NUMERO FROM GADO WHERE (ID = {0})", r["ID_GADO_FEMEA"]);
                            FbCommand fbCmd3 = new FbCommand(query3, fbConn);
                            FbDataReader r3 = fbCmd3.ExecuteReader();
                            r3.Read();
                            idfemea.AddLast(Convert.ToInt32(r["ID_GADO_FEMEA"].ToString()));
                            dataGridView1.Rows[i].Cells["Vaca"].Value = r3["NOME"].ToString();
                            dataGridView1.Rows[i].Cells["NumeroVaca"].Value = r3["NUMERO"].ToString();
                        }
                        catch (FbException fbex)
                        {
                            MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
                        }
                    }
                    else
                    {
                        try
                        {
                            string query3;
                            query2 = string.Format("SELECT NOME, NUMERO FROM GADO WHERE (ID = {0})", r["ID_GADO_MACHO"]);
                            FbCommand fbCmd2 = new FbCommand(query2, fbConn);
                            FbDataReader r2 = fbCmd2.ExecuteReader();
                            if (r2.Read())
                            {
                                dataGridView1.Rows[i].Cells[1].Value = r2[0].ToString();
                                dataGridView1.Rows[i].Cells[2].Value = r2[1].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao acessar o banco de dados.");
                            }
                            query3 = string.Format("SELECT NOME, NUMERO FROM GADO WHERE (ID = {0})", r["ID_GADO_FEMEA"]);
                            idfemea.AddLast(Convert.ToInt32(r["ID_GADO_FEMEA"].ToString()));
                            FbCommand fbCmd3 = new FbCommand(query3, fbConn);
                            FbDataReader r3 = fbCmd3.ExecuteReader();
                            r3.Read();
                            dataGridView1.Rows[i].Cells["Vaca"].Value = r3["NOME"].ToString();
                            dataGridView1.Rows[i].Cells["NumeroVaca"].Value = r3["NUMERO"].ToString();
                        }
                        catch (FbException fbex)
                        {
                            MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
                        }
                    }
                    dataGridView1.Rows[i].Cells["Data"].Value = r["DATA_CRUZAMENTO"].ToString();
                    ids.AddLast(Convert.ToInt32(r["ID"].ToString()));
                    i++;
                }
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
            }
        }

        private void frmRemoverCruzamento_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDgView();
            dataGridView1.ReadOnly = false;
        }

        private bool AlterarHistoricoVaca(int IDVaca, bool nasceu)
        {
            string query = "INSERT INTO HISTORICO (DATA,OBS,ID_GADO) VALUES (@DATA,@OBS,@ID_GADO)";
            FbConnection fbconn = new FbConnection(frmHome.strConn);
            try
            {
                FbCommand fbcmd = new FbCommand();
                fbconn.Open();
                FbParameter[] fbprm = new FbParameter[3];
                try
                {
                    fbprm[0] = new FbParameter("@DATA", Convert.ToDateTime(txtDataNascimento.Text));
                }catch(FormatException ex)
                {
                    fbprm[0] = new FbParameter("@DATA", DateTime.Today);
                }
                    
                if (nasceu)
                    fbprm[1] = new FbParameter("@OBS", "A vaca pariu com sucesso!");
                else
                    fbprm[1] = new FbParameter("@OBS", "Houve algum problema. O cruzamento foi removido sem bezerros!");
                
                fbprm[2] = new FbParameter("ID_GADO", IDVaca);
                foreach (FbParameter p in fbprm)
                {
                    fbcmd.Parameters.Add(p);
                }
                fbcmd.CommandText = query;
                fbcmd.CommandType = CommandType.Text;
                fbcmd.Connection = fbconn;
                fbcmd.ExecuteNonQuery();
                fbconn.Close();
                Close();
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro no banco de dados: " + fbex.Message);
                return false;
            }
            return true;
        }
        private void btRemoverCruzamentos_Click(object sender, EventArgs e)
        {
            if ((cbNao.Checked == false && cbSim.Checked == false) || (cbSim.Checked == true && cbNao.Checked == true))
            {
                MessageBox.Show("Favor preencher os campos corretamente");
            }
            else
            {
                int conta = 0;
                int contador = 0;
                for (conta = 0; conta < dataGridView1.Rows.Count; conta++)
                {
                    if (dataGridView1.Rows[conta].Cells[0].Value != null)
                    {
                        contador++;
                    }
                }
                FbConnection fbconn = new FbConnection(frmHome.strConn);
                fbconn.Open();
                bool deuTudocerto = true;
                if (contador > 0)
                {
                    if (MessageBox.Show("Você tem certeza que deseja remover os cruzamentos selecionados", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value != null)
                            {
                                try
                                {
                                    string query2,  query3;
                                    string query = string.Format("DELETE FROM CRUZAMENTO WHERE (ID = {0})", ids.ElementAt(i));
                                    FbCommand fbCmd = new FbCommand(query, fbconn);
                                    fbCmd.ExecuteNonQuery();
                                    if (cbSim.Checked == false)
                                    {
                                        query2 = string.Format("UPDATE GADO SET CIO = ((SELECT CIO FROM GADO WHERE ID = {0}) + 1) WHERE ID = {0}", idfemea.ElementAt(i));
                                    }
                                    else
                                    {
                                        query2 = string.Format("UPDATE GADO SET CIO = '0' WHERE ID = {0}", idfemea.ElementAt(i));
                                    }
                                    FbCommand fbCmd2 = new FbCommand(query2, fbconn);
                                    fbCmd2.ExecuteNonQuery();
                                    //Adiciona a informacao de remover o cruzamento ao historico da vaca
                                    deuTudocerto = AlterarHistoricoVaca(idfemea.ElementAt(i),cbSim.Checked);

                                }
                                catch (Exception ee)
                                {
                                    MessageBox.Show("Erro ao tentar remover.\n" + ee.Message);
                                    deuTudocerto = false;
                                }
                              
                            }
                        }
                        fbconn.Close();
                        if (deuTudocerto)
                            MessageBox.Show("Cruzamento(s) removido(s) com sucesso!");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Não há nenhum cruzamento selecionado");
                }
            }
        }

        private void frmRemoverCruzamento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRemoverCruzamento_Load(object sender, EventArgs e)
        {

        }
    }
}