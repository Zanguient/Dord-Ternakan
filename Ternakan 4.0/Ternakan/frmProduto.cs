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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void carregarDgView()
        {
            string squery;

            squery = string.Format("SELECT ID,  NOME_PRODUTO, VALOR_PRODUTO, QUANTIDADE, EMPRESA, NUMERO_NOTA_FISCAL, DATA_COMPRA FROM PRODUTO WHERE (ID_FAZENDA = {0})", frmHome.IDFazendaSelecionada);

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

        private bool atualizarProduto(int RowIndex)
        {
            bool retorno = false;
            int ID = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[0].Value);
            
            string squery = string.Format("UPDATE PRODUTO SET EMPRESA = @EMPRESA, NUMERO_NOTA_FISCAL = @NUMERO_NOTA_FISCAL,"
            + " DATA_COMPRA = @DATA_COMPRA,QUANTIDADE = @QUANTIDADE, NOME_PRODUTO = @NOME_PRODUTO, VALOR_PRODUTO = @VALOR_PRODUTO where id = {0}",
                    ID);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand();

            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[7];

            prmParametro[0] = new FbParameter("@EMPRESA", dataGridView1.Rows[RowIndex].Cells[4].Value.ToString());
            prmParametro[1] = new FbParameter("@NUMERO_NOTA_FISCAL", dataGridView1.Rows[RowIndex].Cells[5].Value.ToString());
            DateTime novaData;
            try
            {
                novaData = Convert.ToDateTime(dataGridView1.Rows[RowIndex].Cells[6].Value);
            }
            catch (Exception)
            {

                novaData = DateTime.Today;
            }
            prmParametro[2] = new FbParameter("@DATA_COMPRA", novaData);
            prmParametro[3] = new FbParameter("@REGISTRO", dataGridView1.Rows[RowIndex].Cells[4].Value.ToString());
            if (!(dataGridView1.Rows[RowIndex].Cells[3].Value is DBNull))
                prmParametro[4] = new FbParameter("@QUANTIDADE", Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[3].Value));
            else
                prmParametro[4] = new FbParameter("@QUANTIDADE", 0);
            prmParametro[5] = new FbParameter("@NOME_PRODUTO", dataGridView1.Rows[RowIndex].Cells[1].Value.ToString());
            double novoValor;
            try
            {
                novoValor = Convert.ToDouble(dataGridView1.Rows[RowIndex].Cells[2].Value.ToString());
            }
            catch (Exception)
            {

                novoValor = 0;
            }
            prmParametro[6] = new FbParameter("@VALOR_PRODUTO", novoValor);

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
            return retorno;

        }

        private void removerProduto(int ID)
        {
            string squery = string.Format("DELETE FROM PRODUTO WHERE ID = {0}",
                ID);
            if (MessageBox.Show("Você tem certeza que deseja remover este produto da lista?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                }
                finally
                {
                    fbConn.Close();
                }
            }
        }

        private bool cadastrarProduto()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO PRODUTO (EMPRESA,NUMERO_NOTA_FISCAL,DATA_COMPRA,QUANTIDADE,NOME_PRODUTO,VALOR_PRODUTO,ID_FAZENDA) VALUES (@EMPRESA,@NUMERO_NOTA_FISCAL,@DATA_COMPRA_PRODUTO,@QUANTIDADE,@NOME_PRODUTO,@VALOR_PRODUTO,{0})",
                  frmHome.IDFazendaSelecionada);

            FbCommand fbCmdInsert = new FbCommand();

            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[6];

            prmParametro[0] = new FbParameter("@EMPRESA", txtEmpresa.Text);
            prmParametro[1] = new FbParameter("@NUMERO_NOTA_FISCAL", txtNotaFiscal.Text);
            prmParametro[2] = new FbParameter("@DATA_COMPRA_PRODUTO", Convert.ToDateTime(txtDataCompra.Text));
            prmParametro[3] = new FbParameter("@QUANTIDADE", Convert.ToInt32(txtQuantidadeProduto.Text));
            prmParametro[4] = new FbParameter("@NOME_PRODUTO", txtNomeProduto.Text);
            prmParametro[5] = new FbParameter("@VALOR_PRODUTO", Convert.ToDouble(txtValorProdutoUnitario.Text));

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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btAdicionarLista_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "")
                MessageBox.Show("Preencha o nome da empresa");
            else if (txtNomeProduto.Text == "")
                MessageBox.Show("Preencha o nome do produto");
            else if (txtDataCompra.Text == "  /  /")
                MessageBox.Show("Preencha a data da compra");
            else if (txtNotaFiscal.Text == "")
                MessageBox.Show("Preencha o número da nota fiscal");
            else if (txtQuantidadeProduto.Text == "")
                MessageBox.Show("Preencha a quantidade de produtos comprados");
            else if (txtValorProdutoUnitario.Text == "")
                MessageBox.Show("Preencha valor unitário do produto");
            else
            {
                try
                {
                    if (cadastrarProduto())
                    {
                        MessageBox.Show("Produto cadastrado com sucesso");
                        carregarDgView();
                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
                }
                txtEmpresa.Clear();
                txtDataCompra.Clear();
                txtDataFinal.Clear();
                txtDataInicio.Clear();
                txtNomeProduto.Clear();
                txtNotaFiscal.Clear();
                txtQuantidadeProduto.Clear();
                txtValorProdutoUnitario.Clear();
            }
        }

        private void cxEscolherDetalheImpressao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btImprimirRelatorioProdutos_Click(object sender, EventArgs e)
        {
            if ((txtDataFinal.Text == "  /  /") || (txtDataInicio.Text == "  /  /"))
                MessageBox.Show("A data de início e/ou data final não estão preenchidas");
            else
            {
                VerRelatorio frm = new VerRelatorio();
                frm.carregarRelatorioProduto(Convert.ToDateTime(txtDataInicio.Text), Convert.ToDateTime(txtDataFinal.Text));
                frm.ShowDialog();
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
        }

        private void btVoltarProduto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProduto_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDgView();
        }

        private void frmProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            atualizarProduto(e.RowIndex);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int id = Convert.ToInt32(e.Row.Cells[0].Value);
            removerProduto(id);
        }
    }
}