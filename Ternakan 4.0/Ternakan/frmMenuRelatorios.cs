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
    public partial class frmMenuRelatorios : Form
    {
        int opcaoEscolhida = new int();
        VerRelatorio frm = new VerRelatorio();
        public frmMenuRelatorios()
        {
            InitializeComponent();
            txtInformacao.Text = "";
            opcaoEscolhida = 0;
        }

        private void limpar()
        {
            txtAte.Clear();
            txtDe.Clear();
        }

        private void llblPiquetes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 1;
            lblPiquetRelatorio.Visible = true;
            cbPiquetRelatorio.Visible = true;
            lblIntervalo.Visible = false;
            lblDe.Visible = false;
            lblAte.Visible = false;
            txtAte.Visible = false;
            txtDe.Visible = false;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            //btImprimirBranco.Visible = true;
            txtInformacao.Text = "Relatório com nome e número dos animais que se encontram no piquete selecionado.";
        }

        private void llblTrabalhadores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 2;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório com nome, data de contrato e salário de cada trabalhador que estava ativo durante o período selecionado. Ao final do relatório aparece a soma salarial dos trabalhadores listados.";
        }

        private void llblProdutos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 3;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório com: data de compra; empresa onde o produto foi adiquirido; número da nota fiscal; nome, quantidade, valor unitário do produto; total parcial (quantidade mutiplicada pelo valor unitário do produto); custo total dos gastos durante o intervalo desejado que se encontra ao final do relatório.";
        }

        private void llblAnimaisComRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 4;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = false;
            lblDe.Visible = false;
            lblAte.Visible = false;
            txtAte.Visible = false;
            txtDe.Visible = false;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório com número, nome, sexo e número do registro de todos os animais registrados.";
        }

        private void llblMortalidade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 5;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório com sexo, número, nome e data de mortalidade de todos os animais que morreram no intervalo selecionado.";
        }

        private void llblNatalidade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 6;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório com sexo, número, nome e data de nascimento de todos os animais nascidos no intervalo selecionado.";
        }

        private void llblEntradaAnimias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 7;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório, com sexo, nome e número do animal, preço de compra e o nome do vendedor, das compras de animais feitas no intervalo selecionado.";
        }

        private void llblSaidaAnimais_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 8;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório, com sexo, nome e número do animal, preço de venda e o nome do comprador, tipo de saida (venda ou troca), das vendas de animais feitas no intervalo selecionado.";
        }

        private void llblLactação_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 9;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório com: nome, data da tirada, número do animal, produção de uma tirada, qual tirada, produção média de cada animal e produção média de todos os animais no intervalo selecionado.";
        }

        private void llblPrevisaoNascimento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 10;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório com nome da vaca, nome do reprodutor, data do cruzamento e previsão para nascimento dos animais no intervalo selecionado.";
        }

        private void llblTrabalhadorDemitido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 11;
            lblPiquetRelatorio.Visible = false;
            cbPiquetRelatorio.Visible = false;
            lblIntervalo.Visible = true;
            lblDe.Visible = true;
            lblAte.Visible = true;
            txtAte.Visible = true;
            txtDe.Visible = true;
            btImprimir.Visible = true;
            txtInformacao.Visible = true;
            lblImprimir.Visible = true;
            lblInformacao.Visible = true;
            txtInformacao.Text = "Relatório com o nome dos funcionários demitidos no intervalo escolhido.";
        }

        private void llblLactacaoBranco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 12;
            lblInformacaoBranco.Visible = true;
            txtInformacaoBranco.Visible = true;
            btImprimirBranco.Visible = true;
            lblImprimirBranco.Visible = true;
            txtInformacaoBranco.Text = "Relatorio para preenchimento manual com a finalidade de ajudar nas anotações durante a tirada do leite.";
        }

        private void llblCruzamentoBranco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 13;
            lblInformacaoBranco.Visible = true;
            txtInformacaoBranco.Visible = true;
            btImprimirBranco.Visible = true;
            lblImprimirBranco.Visible = true;
            txtInformacaoBranco.Text = "Relatorio para preenchimento manual com a finalidade de ajudar nas anotações durante o cruzamento ou inseminação";
        }

        private void llblVacinacaoBranco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpar();
            opcaoEscolhida = 14;
            lblInformacaoBranco.Visible = true;
            txtInformacaoBranco.Visible = true;
            btImprimirBranco.Visible = true;
            lblImprimirBranco.Visible = true;
            txtInformacaoBranco.Text = "Relatorio para preenchimento manual com a finalidade de ajudar nas anotações durante a medicação dos animais.";
        }

        private void frmMenuRelatorios_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            switch (opcaoEscolhida)
            {
                case 1://Relatório de piquete
                    int IDPiquet = Convert.ToInt32(cbPiquetRelatorio.SelectedValue);
                    frm.carregarPiquet(IDPiquet);
                    frm.ShowDialog();
                    break;

                case 2://Relatório de trabalhadores
                    if (txtAte.Text != "  /  /" && txtDe.Text != "  /  /")
                    {
                        frm.carregarDsTrabalhadores(Convert.ToDateTime(txtDe.Text), Convert.ToDateTime(txtAte.Text), false);
                        frm.ShowDialog();
                    }
                    else
                        MessageBox.Show("A data de início ou data final não estão preenchidas");
                    break;

                case 3://Relatório de produtos
                    if (txtAte.Text != "  /  /" && txtDe.Text != "  /  /")
                    {
                        frm.carregarRelatorioProduto(Convert.ToDateTime(txtDe.Text), Convert.ToDateTime(txtAte.Text));
                        frm.ShowDialog();
                    }
                    else
                        MessageBox.Show("A data de início ou data final não estão preenchidas");
                    break;

                case 4://Relatório de animais registrados
                    frm.carregarRelatorioGadoRegistrado(false, false);
                    frm.ShowDialog();
                    break;

                case 5://Relatório de Mortalidade
                    if (txtAte.Text != "  /  /" && txtDe.Text != "  /  /")
                    {
                        frm.carregarRelatorioMortalidade(Convert.ToDateTime(txtDe.Text), Convert.ToDateTime(txtAte.Text));
                        frm.Show();
                    }
                    else
                        MessageBox.Show("A data de início ou data final não estão preenchidas");
                    break;

                case 6://Relatório de natalidade
                    if (txtAte.Text != "  /  /" && txtDe.Text != "  /  /")
                    {
                        frm.carregarRelatorioNatalidade(Convert.ToDateTime(txtDe.Text), Convert.ToDateTime(txtAte.Text));
                        frm.ShowDialog();
                    }
                    else
                        MessageBox.Show("A data de início ou data final não estão preenchidas");
                    break;

                case 7://Relatório de entrada de animais
                    if (txtAte.Text != "  /  /" && txtDe.Text != "  /  /")
                    {
                        frm.carregarRelatorioEntrada(Convert.ToDateTime(txtDe.Text), Convert.ToDateTime(txtAte.Text));
                        frm.ShowDialog();
                    }
                    else
                        MessageBox.Show("A data de início ou data final não estão preenchidas");
                    break;

                case 8://Relatório de saída de animais
                    if (txtAte.Text != "  /  /" && txtDe.Text != "  /  /")
                    {
                        frm.carregarRelatorioSaida(Convert.ToDateTime(txtDe.Text), Convert.ToDateTime(txtAte.Text));
                        frm.ShowDialog();
                    }
                    else
                        MessageBox.Show("A data de início ou data final não estão preenchidas");
                    break;

                case 9://Relatório de lactação
                    if (txtAte.Text != "  /  /" && txtDe.Text != "  /  /")
                    {
                        frm.carregarRelatorioLactacaoDia(Convert.ToDateTime(txtDe.Text),Convert.ToDateTime(txtAte.Text));
                        frm.ShowDialog();
                    }
                    else
                        MessageBox.Show("A data de início ou data final não estão preenchidas");
                    break;

                /*case 10://Relatório de Previsão de nascimento
                    break;

                case 11://Relatório de Trabalhadores demitidos
                    if (txtAte.Text != "  /  /" && txtDe.Text != "  /  /")
                    {
                        //falta por aqui
                    }
                    else
                        MessageBox.Show("A data de início ou data final não estão preenchidas");
                    break;*/
            }
        }

        private void btImprimirBranco_Click(object sender, EventArgs e)
        {
            switch (opcaoEscolhida)
            {
                case 12://Relatório de lactação branco
                    frm.relatorioEmBranco(0);
                    frm.Show();
                    break;

                case 13://Relatório de cruzamento branco
                    frm.relatorioEmBranco(2);
                    frm.Show();
                    break;

                case 14://Relatório de vacinação
                    frm.relatorioEmBranco(1);
                    frm.Show();
                    break;
            }
        }
    }
}
