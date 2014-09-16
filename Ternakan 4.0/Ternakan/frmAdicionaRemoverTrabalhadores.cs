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
    public partial class adicionaRemoverTrabalhadores : Form
    {
        private bool ehUpdate = false;
        private int IDUpdate = 0;

        public adicionaRemoverTrabalhadores()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adicionaRemoverTrabalhadores_Load(object sender, EventArgs e)
        {

        }

        private bool cadastrarTrabalhador()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
              string queryInsert = string.Format("INSERT INTO TRABALHADOR (ID_FAZENDA, NOME, SALARIO, DATA_NASCIMENTO,  DATA_TRABALHO, ATIVIDADE, RG, CPF, CARTTRABALHO, OBS) VALUES ({0},@NOME,@SALARIO,@DATA_NASCIMENTO,@DATA_TRABALHO,@ATIVIDADE, @RG, @CPF, @CARTTRABALHO, @OBS)",
                    frmHome.IDFazendaSelecionada);
            
            FbCommand fbCmdInsert = new FbCommand();


            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[9];

            prmParametro[0] = new FbParameter("@NOME", txtNomeTrabalhador.Text);
            if (txtSalario.Text != "")
                 prmParametro[1] = new FbParameter("@SALARIO", Convert.ToDouble(txtSalario.Text));
            prmParametro[2] = new FbParameter("@DATA_NASCIMENTO", Convert.ToDateTime(txtDatadeNascimentoTrabalhador.Text));
            prmParametro[3] = new FbParameter("@DATA_TRABALHO", Convert.ToDateTime(txtDataContrato.Text));
            prmParametro[4] = new FbParameter("@ATIVIDADE", 1);
            prmParametro[5] = new FbParameter("@RG", txtRg.Text);
            prmParametro[6] = new FbParameter("@CPF", txtCpf.Text);
            prmParametro[7] = new FbParameter("@CARTTRABALHO", txtCartTrab.Text);
            prmParametro[8] = new FbParameter("@OBS", txtObs.Text);

            foreach (FbParameter p in prmParametro)
            {
               fbCmdInsert.Parameters.Add(p);
            }

            try
            {

                    fbConn.Open();
                    fbCmdInsert.Connection = fbConn;
                    fbCmdInsert.CommandType = CommandType.Text;
                    fbCmdInsert.CommandText = queryInsert;
                    fbCmdInsert.ExecuteNonQuery();
                    retorno = true;
                    txtNomeTrabalhador.Text = "";
                    txtObs.Text = "";
                    txtRg.Text = "";
                    txtSalario.Text = "";
                    txtInicio.Text = "";
                    txtFim.Text = "";
                    txtDataContrato.Text = "";
                    txtDatadeNascimentoTrabalhador.Text = "";
                    txtCpf.Text = "";
                    txtCartTrab.Text = "";
               
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

        private void btCadastrarTrabalhador_Click(object sender, EventArgs e)
        {
            if (txtNomeTrabalhador.Text == "")
                MessageBox.Show("Preencher nome do trabalhador");
            else if (txtDatadeNascimentoTrabalhador.Text == "  /  /")
                MessageBox.Show("Preencher data de nascimento");
            else if (txtSalario.Text == "")
                MessageBox.Show("Preencher o salário do trabalhador");
            else
            {
                
                dgListaTrabalhadores.Refresh();
                if (!ehUpdate)
                {
                    if (cadastrarTrabalhador())
                    {
                        txtNomeTrabalhador.Clear();
                        txtSalario.Clear();
                        MessageBox.Show("Trabalhador cadastrado com sucesso");
                        carregarDgView();
                    }
                }
                else
                {
                    update();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            VerRelatorio frm = new VerRelatorio();
            frm.carregarDsTrabalhadores(Convert.ToDateTime(txtInicio.Text), Convert.ToDateTime(txtFim.Text),false);
            frm.ShowDialog();
        }

        private bool alterarTrabalhador(int ID)
        {
            bool retorno = false;
            string squery = string.Format("UPDATE TRABALHADOR SET NOME = @NOME, SALARIO = @SALARIO, DATA_NASCIMENTO = @DATA_NASCIMENTO, DATA_TRABALHO = @DATA_TRABALHO, RG = @RG, CPF = @CPF, CARTTRABALHO = @CARTTRABALHO, OBS = @OBS where id = {0}",
                    ID);
            if (MessageBox.Show("Você tem certeza que deseja alterar este trabalhador?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                FbConnection fbConn = new FbConnection(frmHome.strConn);

                FbCommand fbCmd = new FbCommand();

               //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[8];

            prmParametro[0] = new FbParameter("@NOME", txtNomeTrabalhador.Text);
            if (txtSalario.Text != "")
                 prmParametro[1] = new FbParameter("@SALARIO", Convert.ToDouble(txtSalario.Text));
            prmParametro[2] = new FbParameter("@DATA_NASCIMENTO", Convert.ToDateTime(txtDatadeNascimentoTrabalhador.Text));
            prmParametro[3] = new FbParameter("@DATA_TRABALHO", Convert.ToDateTime(txtDataContrato.Text));
            prmParametro[4] = new FbParameter("@RG", txtRg.Text);
            prmParametro[5] = new FbParameter("@CPF", txtCpf.Text);
            prmParametro[6] = new FbParameter("@CARTTRABALHO", txtCartTrab.Text);
            prmParametro[7] = new FbParameter("@OBS", txtObs.Text);
            foreach (FbParameter p in prmParametro)
            {

               fbCmd.Parameters.Add(p);
            }

            try
            {

                fbConn.Open();
                fbCmd.Connection = fbConn;
                fbCmd.CommandType = CommandType.Text;
                fbCmd.CommandText = squery;
                fbCmd.ExecuteNonQuery();
                txtNomeTrabalhador.Text = "";
                txtObs.Text = "";
                txtRg.Text = "";
                txtSalario.Text = "";
                txtInicio.Text = "";
                txtFim.Text = "";
                txtDataContrato.Text = "";
                txtDatadeNascimentoTrabalhador.Text = "";
                txtCpf.Text = "";
                txtCartTrab.Text = "";
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
                retorno = false;
            }
                finally
                {
                    fbConn.Close();
                }
                retorno = true;
            }
            return retorno;
        }

        private bool removerTrabalhador(int ID)
        {
            bool retorno = false;
            string squery = string.Format("UPDATE TRABALHADOR SET ATIVIDADE = 0 where id = {0}",
                    ID);
            if (MessageBox.Show("Você tem certeza que deseja remover este trabalhador da lista?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    retorno = false;
                }
                finally
                {
                    fbConn.Close();
                }
                retorno = true;
            }
            return retorno;
        }
        private void btRemoverTrabalhador_Click(object sender, EventArgs e)
        {
           try
            {
                if (dgListaTrabalhadores.SelectedRows.Count > 0)
                {
                    int ID = Convert.ToInt32(dgListaTrabalhadores.SelectedRows[0].Cells[0].Value);
                    if (removerTrabalhador(ID))
                    {
                        MessageBox.Show("Trabalhador removido com sucesso");
                        carregarDgView();
                    }
                }
                else
                {
                    MessageBox.Show("Não há um item selecionado");
                }

            }
           catch (Exception ee)
           {

               MessageBox.Show("ERRO:\n" + ee.Message);
           }
        }

        private void carregarDgView()
        {
            string squery;

            squery = string.Format("SELECT ID, NOME FROM TRABALHADOR WHERE ((ATIVIDADE = 1) AND (ID_FAZENDA = {0}))",
                frmHome.IDFazendaSelecionada);




            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();


                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);

                dgListaTrabalhadores.DataSource = dtUsuarios;
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
        private void btVoltarAdicionarRemoverTrabalhador_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adicionaRemoverTrabalhadores_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDgView();
        }

        private void adicionaRemoverTrabalhadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void preencherTrabalhadorUpdate(int ID)
        {
            string squery = string.Format("SELECT NOME, SALARIO, DATA_NASCIMENTO, DATA_TRABALHO, RG, CPF, OBS, CARTTRABALHO FROM TRABALHADOR where id = {0}",
                    ID);
            
                FbConnection fbConn = new FbConnection(frmHome.strConn);

                FbCommand fbCmd = new FbCommand(squery, fbConn);

                try
                {
                    fbConn.Open();
                    FbDataReader r = fbCmd.ExecuteReader();
                    if (r.Read())
                    {
                        txtNomeTrabalhador.Text = r[0].ToString();
                        txtSalario.Text = r[1].ToString();
                        txtDatadeNascimentoTrabalhador.Text = r[2].ToString();
                        txtDataContrato.Text = r[3].ToString();
                        txtRg.Text = r["RG"].ToString();
                        txtCpf.Text = r["CPF"].ToString();
                        txtObs.Text = r["OBS"].ToString();
                        txtCartTrab.Text = r["CARTTRABALHO"].ToString();
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
            
        }

        private void update()
        {
            try
            {
                
              if (alterarTrabalhador(IDUpdate))
                    {
                        MessageBox.Show("Trabalhador alterado com sucesso");
                        carregarDgView();
                        ehUpdate = false;
                        txtNomeTrabalhador.Clear();
                        txtSalario.Clear();
                        txtNomeTrabalhador.Text = "";
                        txtObs.Text = "";
                        txtRg.Text = "";
                        txtSalario.Text = "";
                        txtInicio.Text = "";
                        txtFim.Text = "";
                        txtDataContrato.Text = "";
                        txtDatadeNascimentoTrabalhador.Text = "";
                        txtCpf.Text = "";
                        txtCartTrab.Text = "";
                    } 
                else
                {
                    MessageBox.Show("Não há um item selecionado");
                }


            }
            catch (Exception ee)
            {

                MessageBox.Show("ERRO:\n" + ee.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgListaTrabalhadores.SelectedRows.Count > 0)
            {
                IDUpdate = Convert.ToInt32(dgListaTrabalhadores.SelectedRows[0].Cells[0].Value);
                preencherTrabalhadorUpdate(IDUpdate);
                ehUpdate = true;
            }
            else
            {
                MessageBox.Show("Selecione um trabalhador primeiro");
            }
        }

        private void txtDatadeNascimentoTrabalhador_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgListaTrabalhadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}