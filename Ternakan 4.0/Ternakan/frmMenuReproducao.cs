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
    public partial class frmMenuReproducao : Form
    {
        public frmMenuReproducao()
        {
            InitializeComponent();
        }


        //Ações para a passagem do mouse sobre algum botão
        private void btCruzamento_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Inclusão e remoção de cruzamento.";
        }
        private void brPrevisaoNascimento_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Tabela com a previsão de nascimento referente aos cruzamentos cadastrados.";
        }
        private void btSemens_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Inclusão, remoção e listagem de sêmens.";
        }
        

        //Ações para o clique no botão
        private void btCruzamento_Click(object sender, EventArgs e)
        {
            frmCruzamento frm = new frmCruzamento();
            frm.ShowDialog();
        }
        private void brPrevisaoNascimento_Click(object sender, EventArgs e)
        {
            frmPrevisaoNascimento frm = new frmPrevisaoNascimento();
            frm.ShowDialog();
        }

        private void btSemens_Click(object sender, EventArgs e)
        {
            frmSemens frm = new frmSemens();
            frm.ShowDialog();
        }


        //Concatena o nome da fazenda selecionada com o nome da janela
        private void frmMenuReproducao_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
