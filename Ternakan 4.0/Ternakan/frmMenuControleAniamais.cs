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
    public partial class frmMenuControleAniamais : Form
    {
        public frmMenuControleAniamais()
        {
            InitializeComponent();
        }

        private void frmMenuControleAniamais_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void btQuantidadeAnimais_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Informa a quantidade de animais cadastrados. Divide entre fêmeas e machos e mostra o total.";
        }

        private void btMedicacao_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Controle dos medicamentos aplicados nos animais.";
        }

        private void btEntradaAnimais_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Controla a entrada de animais cadastrando estes.";
        }

        private void btSaidaAnimais_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Controla a saida de animais removendo estes.";
        }

        private void btNatalidade_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Cadastro dos animais que nasceram.";
        }

        private void btMortalidade_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Remoção dos animais que morreram.";
        }

        private void btQuantidadeAnimais_Click(object sender, EventArgs e)
        {
            frmQuantidadeGado frm = new frmQuantidadeGado();
            frm.ShowDialog();
        }

        private void btMedicacao_Click(object sender, EventArgs e)
        {
            frmVacinacao frm = new frmVacinacao();
            frm.ShowDialog();
        }

        private void btEntradaAnimais_Click(object sender, EventArgs e)
        {
            frmGadoCadastro frm = new frmGadoCadastro();
            frm.rbCompra.Checked = true;
            frm.ShowDialog();
        }

        private void btSaidaAnimais_Click(object sender, EventArgs e)
        {
            frmSaidaAnimais frm = new frmSaidaAnimais();
            frm.ShowDialog();
        }

        private void btNatalidade_Click(object sender, EventArgs e)
        {
            frmGadoCadastro frm = new frmGadoCadastro();
            frm.rbNascido.Checked = true;
            frm.ShowDialog();
        }

        private void btMortalidade_Click(object sender, EventArgs e)
        {
            frmMortalidade frm = new frmMortalidade();
            frm.ShowDialog();
        }
    }
}
