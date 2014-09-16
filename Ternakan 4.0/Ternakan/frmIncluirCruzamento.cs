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
    public partial class frmIncluirCruzamento : Form
    {

        bool temSemem = true;
        bool temGado = true;
        public frmIncluirCruzamento()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool cadastrarCruzamento()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO CRUZAMENTO (ID_GADO_MACHO,DATA_CRUZAMENTO,ID_GADO_FEMEA,ENVIADO,SEMEM, ID_FAZENDA) VALUES (@ID_GADO_MACHO,@DATA_CRUZAMENTO,@ID_GADO_FEMEA,'0',@SEMEM, {0})",
                frmHome.IDFazendaSelecionada);
            FbCommand fbCmdInsert = new FbCommand();
            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[4];
            if (!(rbSimInseminacao.Checked))
            {
                prmParametro[0] = new FbParameter("@ID_GADO_MACHO", cbNomeReprodutor.SelectedValue);
                prmParametro[1] = new FbParameter("@DATA_CRUZAMENTO", Convert.ToDateTime(txtDataCruzamento.Text));
                prmParametro[2] = new FbParameter("@ID_GADO_FEMEA", cbNumeroVacaCruzamento.SelectedValue);
                prmParametro[3] = new FbParameter("@SEMEM", Convert.ToInt32(rbSimInseminacao.Checked));
            }
            else
            {
                prmParametro[0] = new FbParameter("@ID_GADO_MACHO", cbSemem.SelectedValue);
                prmParametro[1] = new FbParameter("@DATA_CRUZAMENTO", Convert.ToDateTime(txtDataCruzamento.Text));
                prmParametro[2] = new FbParameter("@ID_GADO_FEMEA", cbNumeroVacaCruzamento.SelectedValue);
                prmParametro[3] = new FbParameter("@SEMEM", Convert.ToInt32(rbSimInseminacao.Checked));

            }
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

        private void alterarQuantidade(int IDSemen)
        {
            FbConnection fbConn = new FbConnection(frmHome.strConn);

            try
            {
                string squery = string.Format("UPDATE SEMEN SET QUANTIDADE = (SELECT QUANTIDADE FROM SEMEN WHERE ID = {0}) - 1 WHERE ID = {0}", IDSemen);
                FbCommand comando = new FbCommand(squery, fbConn);
                fbConn.Open();
                comando.ExecuteNonQuery();
            }
            catch (FbException e)
            {
                MessageBox.Show("Erro de acesso ao Banco de Dados\n" + e.Message);
            }
            finally
            {
                fbConn.Close();
            }
        }

        private void carregarCbVaca()
        {
            bool controle = true;
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID, NUMERO FROM GADO WHERE ((SEXO = 'F') AND (ID_FAZENDA = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') ) ORDER BY NUMERO",
                frmHome.IDFazendaSelecionada);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    if (controle)
                    {
                        mudarValorCbVaca(Convert.ToInt32(r[0]));
                        controle = false;
                    }
                    retorno.Add(Convert.ToInt32(r[0].ToString()), r[1].ToString());
                }
                if (retorno.Count != 0)
                {
                    cbNumeroVacaCruzamento.DataSource = new BindingSource(retorno, null);
                    cbNumeroVacaCruzamento.DisplayMember = "Value";
                    cbNumeroVacaCruzamento.ValueMember = "Key";
                    cbNumeroVacaCruzamento.Refresh();
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
        private void carregarCbSemem()
        {
            bool controle = true;
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID, NOME, REGISTRO FROM SEMEN WHERE (ID_FAZENDA = {0}) ORDER BY NOME",frmHome.IDFazendaSelecionada);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    if (controle)
                    {
                        cbSemem.SelectedValue = Convert.ToInt32(r[0]);
                        cbSemem.SelectedText = r[1].ToString();
                    }
                    string s = r[2].ToString() + " - " + r[1].ToString();
                    retorno.Add(Convert.ToInt32(r[0].ToString()), s);
                }
                if (retorno.Count != 0)
                {
                    cbSemem.DataSource = new BindingSource(retorno, null);
                    cbSemem.DisplayMember = "Value";
                    cbSemem.ValueMember = "Key";
                    cbSemem.Refresh();

                }
                else
                {
                    temSemem = false;
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
        private void mudarValorCbVaca(int IDVaca)
        {

            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT NOME, RACA FROM GADO WHERE (ID = {0})", IDVaca);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                if (r.Read())
                {
                    cbNomeVacaCruzamento.Text = r[0].ToString();
                    cbRacaVacaCruzamento.Text = r[1].ToString();
                }
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
            }

        }

        private void mudarValorCbGado(int IDGado)
        {

            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT RACA FROM GADO WHERE (ID = {0})", IDGado);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                if (r.Read())
                    cbRacaReprodutor.Text = r[0].ToString();
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
            }

        }

        private void carregarCbGado()
        {
            bool controle = true;
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID, NOME FROM GADO WHERE ((SEXO = 'M') AND (ID_FAZENDA = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO')) ORDER BY NOME",
                frmHome.IDFazendaSelecionada);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    if (controle)
                    {
                        mudarValorCbGado(Convert.ToInt32(r[0]));
                        controle = false;
                    }
                    retorno.Add(Convert.ToInt32(r[0].ToString()), r[1].ToString());
                }
                if (retorno.Count != 0)
                {
                    cbNomeReprodutor.DataSource = new BindingSource(retorno, null);
                    cbNomeReprodutor.DisplayMember = "Value";
                    cbNomeReprodutor.ValueMember = "Key";
                    cbNomeReprodutor.Refresh();
                }
                else
                {
                    temGado = false;
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
        private bool podeCruzar()
        {
            bool retorno = true;
            DateTime d = Convert.ToDateTime(txtDataCruzamento.Text);
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT DATA_CRUZAMENTO FROM CRUZAMENTO WHERE (ID_GADO_FEMEA = {0})",cbNumeroVacaCruzamento.SelectedValue);
            FbCommand cmd = new FbCommand(query, fbConn);
            fbConn.Open();
            FbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                if (Convert.ToDateTime(r[0].ToString()) == d)
                {
                    retorno = false;
                }
            }
            fbConn.Close();
            return retorno;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbNaoInseminacao.Checked == false && rbSimInseminacao.Checked == false)
                MessageBox.Show("Favor informar se foi ou não inseminação");
            else if (txtDataCruzamento.Text == "  /  /")
                MessageBox.Show("Favor informar a data do cruzamento");
            else if (rbSimInseminacao.Checked == true && temSemem == false)
                MessageBox.Show("Você não possui semem cadastrado na lista. Favor cadastrar um semem para prosseguir.");
            else if (rbNaoInseminacao.Checked == true && temGado == false)
                MessageBox.Show("Você não possui gado cadastrado na lista. Favor cadastrar um gado para prosseguir.");
            else
            {
                if (podeCruzar())
                {
                    if (cadastrarCruzamento())
                    {
                        MessageBox.Show("Cruzamento adicionado com sucesso");
                        if (rbSimInseminacao.Checked)
                        {
                            alterarQuantidade(Convert.ToInt32(cbSemem.SelectedValue));
                        }
                        txtDataCruzamento.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Vaca já cruzou na data especificada");
                }
            }
        }

        private void btSairIncluirCruzamento_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void frmIncluirCruzamento_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarCbVaca();
            carregarCbGado();
            carregarCbSemem();
            mudarValorCbVaca(Convert.ToInt32(cbNumeroVacaCruzamento.SelectedValue));
            mudarValorCbGado(Convert.ToInt32(cbNomeReprodutor.SelectedValue));


        }
        private void rbSimInseminacao_CheckedChanged(object sender, EventArgs e)
        {
            cbNomeReprodutor.Enabled = !rbSimInseminacao.Checked;
            cbSemem.Visible = rbSimInseminacao.Checked;
            cbSemem.Enabled = cbSemem.Visible;
            label7.Visible = rbSimInseminacao.Checked;
        }

        private void rbNaoInseminacao_CheckedChanged(object sender, EventArgs e)
        {
            cbNomeReprodutor.Enabled = !rbSimInseminacao.Checked;
            cbSemem.Visible = rbSimInseminacao.Checked;
            cbSemem.Enabled = cbSemem.Visible;
            label7.Visible = rbSimInseminacao.Checked;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbNumeroVacaCruzamento_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            mudarValorCbVaca(Convert.ToInt32(cbNumeroVacaCruzamento.SelectedValue));
        }

        private void cbNomeReprodutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNomeReprodutor_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            mudarValorCbGado(Convert.ToInt32(cbNomeReprodutor.SelectedValue));
        }

    }
}
