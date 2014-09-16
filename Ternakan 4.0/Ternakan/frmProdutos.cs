using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ternakan
{
    public partial class frmProdutos : Form
    {
        private bool alterar = false;
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void limparDados(bool limpar)
        {
            if (limpar == true)
            {
                txtEmpresaAE.Text = "";
                txtDatCompraAE.Text = "  /  /";
                txtNomeProdutoAE.Text = "";
                txtNotaFiscalAE.Text = "";
                txtQuantidadeAE.Text = "";
                txtValorUnitarioAE.Text = "";
            }
            else
            {
                txtEmpresa.Clear();
                txtDataCompra.Clear();
                txtNomeProduto.Clear();
                txtNotaFiscal.Clear();
                txtQuantidadeProduto.Clear();
                txtValorProdutoUnitario.Clear();
            }
        }

        private void voltarInicio()
        {
            alterar = false;

            lblDataCompraAE.Visible = false;
            lblEmpresaAE.Visible = false;
            lblNomeProdutoAE.Visible = false;
            lblNotaFiscalAE.Visible = false;
            lblQuantidadeAE.Visible = false;
            lblValorUnitarioAE.Visible = false;
            lblCancelar.Visible = false;
            lblAlterar.Left = 270;

            txtDatCompraAE.Visible = false;
            txtEmpresaAE.Visible = false;
            txtNomeProdutoAE.Visible = false;
            txtNotaFiscalAE.Visible = false;
            txtQuantidadeAE.Visible = false;
            txtValorUnitarioAE.Visible = false;

            btCancelar.Visible = false;
            btAlterar.Left = 271;

            dgProdutos.Height = 271;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (alterar == false)
            {
                alterar = true;
                lblDataCompraAE.Visible = true;
                lblEmpresaAE.Visible = true;
                lblNomeProdutoAE.Visible = true;
                lblNotaFiscalAE.Visible = true;
                lblQuantidadeAE.Visible = true;
                lblValorUnitarioAE.Visible = true;
                lblCancelar.Visible = true;
                lblAlterar.Left = 305;

                txtDatCompraAE.Visible = true;
                txtEmpresaAE.Visible = true;
                txtNomeProdutoAE.Visible = true;
                txtNotaFiscalAE.Visible = true;
                txtQuantidadeAE.Visible = true;
                txtValorUnitarioAE.Visible = true;

                btCancelar.Visible = true;
                btAlterar.Left = 306;

                dgProdutos.Height = 173;
            }
            else
            {
                if (txtEmpresaAE.Text == "")
                    MessageBox.Show("Preencha o nome da empresa");
                else if (txtNomeProdutoAE.Text == "")
                    MessageBox.Show("Preencha o nome do produto");
                else if (txtDatCompraAE.Text == "  /  /")
                    MessageBox.Show("Preencha a data da compra");
                else if (txtNotaFiscalAE.Text == "")
                    MessageBox.Show("Preencha o número da nota fiscal");
                else if (txtQuantidadeAE.Text == "")
                    MessageBox.Show("Preencha a quantidade de produtos comprados");
                else if (txtValorUnitarioAE.Text == "")
                    MessageBox.Show("Preencha valor unitário do produto");
                else
                {
                    //commit

                    limparDados(true);

                    voltarInicio();                    
                }
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparDados(true);

            voltarInicio();
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
                //commit
                limparDados(false);
            }
        }

        private void btLimparCampos_Click(object sender, EventArgs e)
        {
            limparDados(false);
        }

        private void txtQuantidadeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeProdutoAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProdutos_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
