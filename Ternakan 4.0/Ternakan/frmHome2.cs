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
    public partial class frmHome2 : Form
    {        
        public frmHome2()
        {
            InitializeComponent();
            txtInformacao.Text = "Passe o mouse em cima de cada botão e descubra suas funcionalidades!!";
            frmHome2.ActiveForm.MaximizeBox = false;
        }


        //Ações para o clique no botão
        private void btRelatorio_Click(object sender, EventArgs e)
        {
            frmMenuRelatorios frm = new frmMenuRelatorios();
            frm.ShowDialog();
        }

        private void btSobre_Click(object sender, EventArgs e)
        {
            frmAboutBox frm = new frmAboutBox();
            frm.ShowDialog();
        }

        private void btFazenda_Click_1(object sender, EventArgs e)
        {
            frmMenuFazenda frm = new frmMenuFazenda();
            frm.ShowDialog();
        }

        private void btAnimais_Click_1(object sender, EventArgs e)
        {
            frmMenuAnimais frm = new frmMenuAnimais();
            frm.ShowDialog();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frm = new frmMenuUsuario();
            frm.ShowDialog();
        }

        private void btAgenda_Click(object sender, EventArgs e)
        {
            frmMenuAgenda frm = new frmMenuAgenda();
            frm.ShowDialog();
        }

        private void btReproducao_Click(object sender, EventArgs e)
        {
            frmMenuReproducao frm = new frmMenuReproducao();
            frm.ShowDialog();
        }

        private void btLactacao_Click(object sender, EventArgs e)
        {
            frmMenuLactacao frm = new frmMenuLactacao();
            frm.ShowDialog();
        }

        private void btControle_Click(object sender, EventArgs e)
        {
            frmMenuControleAniamais frm = new frmMenuControleAniamais();
            frm.ShowDialog();
        }

        //Ações para a passagem do mouse sobre algum botão
        private void btFazenda_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Nessa área é possivel fazer o controle de gastos com produtos e trabalhadores, fazer o controle de piquetes e, dependendo da licença, fazer cadastro de outras propriedades.";
        }

        private void btAnimais_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Nessa área é possivel fazer o cadastro e a consulta de animais além de listar os que são registrados.";
        }

        private void btRelatorio_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Todos os relatórios podem ser obtidos nessa área. Caso deseje um relatório que não tenha no sistema basta entrar em contato conosco.";
        }

        private void btUsuarios_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Controle de contas de usuários. Dependendo de sua permissão, aqui pode-se alterar, remover e trocar de usuários além de poder trocar sua senha.";
        }

        private void btAgenda_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Cadastro e visualização de enventos das suas fazendas.";
        }


        private void btSobre_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Informações sobre o produtos e a nossa empresa.";
        }

        private void btReproducao_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Controla toda a reprodução dos animais, prever data de nascimento a partir do registro de um cruzamento e ainda permite fazer o controle do banco de sêmens, cadastrando-os e alterando-os.";
        }

        private void btLactacao_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Controle de toda produção leiteira.";
        }

        private void btControle_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Controle de animais que inclui entrada, saida, mortalidade, natalidade e medicação";
        }

        //Ações para mudança de tamanho da janela
        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            txtInformacao.Width = splitContainer1.Panel2.Width - 62;
            gbInformacao.Width = splitContainer1.Panel2.Width - 26;
            gbInformacao.Height = (splitContainer1.Height - 50);
            gbInformacao.Location = new Point(gbInformacao.Width / 120, gbInformacao.Height / 90);
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            gbMenu.Height = (splitContainer1.Height - 50);
            gbMenu.Width = (splitContainer1.Panel1.Width - 50);
            gbMenu.Location = new Point(gbMenu.Width / 15, gbMenu.Height / 90);
        }


        //Concatena o nome da fazenda selecionada com o nome da janela
        private void frmHome2_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}