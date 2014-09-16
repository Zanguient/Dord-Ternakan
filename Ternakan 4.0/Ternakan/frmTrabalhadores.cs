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

    public partial class frmTrabalhadores : Form
    {
        private bool ehUpdate = false;
        private int IDUpdate = 0;
        private bool alterar = false;

        public frmTrabalhadores()
        {
            InitializeComponent();
        }


        private void btCadastrarTrabalhador_Click(object sender, EventArgs e)
        {
            if (txtNomeTrabalhador.Text == "" || txtRg.Text == "" || txtSalario.Text == "")
                MessageBox.Show("Favor preencher todos os campos obrigatórios");
            else
            {
                MessageBox.Show("Trabalhador cadastrado com sucesso");
                limpaCampos();

            }
        }
        private void limpaCampos()
        {
            txtNomeTrabalhador.Text = "";
            txtObs.Text = "";
            txtRg.Text = "";
            txtSalario.Text = "";
            txtDataContrato.Text = "";
            txtDatadeNascimentoTrabalhador.Text = "";
            txtCpf.Text = "";
            txtCartTrab.Text = "";
        }

        private void btLimparCampos_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            
            if (alterar == false)
            {
                alterar = true;
                dgListaTrabalhadores.Height = 248;
                lblCarteiraTrabalhoLT.Visible = true;
                lblCPFLT.Visible = true;
                lblDataContratoLT.Visible = true;
                lblDTNascimentoLT.Visible = true;
                lblNomeLT.Visible = true;
                lblObsLT.Visible = true;
                lblRGLT.Visible = true;
                lblSalarioLT.Visible = true;
                lblSifraoLT.Visible = true;
                lblDispensar.Text = "Cancelar";
                
                txtCartTrabLT.Visible = true;
                txtCPFLT.Visible = true;
                txtDataContratoLT.Visible = true;
                txtDatadeNascimentoTrabalhadorLT.Visible = true;
                txtNomeTrabalhadorLT.Visible = true;
                txtRGLT.Visible = true;
                txtSalarioLT.Visible = true;
                txtObsLT.Visible = true;

                btRemoverTrabalhador.Visible = false;
                btCancelar.Visible = true;
            }
            else
            {
                if (txtNomeTrabalhadorLT.Text == "")
                    MessageBox.Show("Preencher nome do trabalhador");
                else if (txtDatadeNascimentoTrabalhadorLT.Text == "  /  /")
                    MessageBox.Show("Preencher data de nascimento");
                else if (txtSalarioLT.Text == "")
                    MessageBox.Show("Preencher o salário do trabalhador");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            alterar = false;

            txtNomeTrabalhadorLT.Text = "";
            txtObsLT.Text = "";
            txtRGLT.Text = "";
            txtSalarioLT.Text = "";
            txtDataContratoLT.Text = "";
            txtDatadeNascimentoTrabalhadorLT.Text = "";
            txtCPFLT.Text = "";
            txtCartTrabLT.Text = "";

            txtCartTrabLT.Visible = false;
            txtCPFLT.Visible = false;
            txtDataContratoLT.Visible = false;
            txtDatadeNascimentoTrabalhadorLT.Visible = false;
            txtNomeTrabalhadorLT.Visible = false;
            txtRGLT.Visible = false;
            txtSalarioLT.Visible = false;
            txtObsLT.Visible = false;

            dgListaTrabalhadores.Height = 248;
            lblCarteiraTrabalhoLT.Visible = false;
            lblCPFLT.Visible = false;
            lblDataContratoLT.Visible = false;
            lblDTNascimentoLT.Visible = false;
            lblNomeLT.Visible = false;
            lblObsLT.Visible = false;
            lblRGLT.Visible = false;
            lblSalarioLT.Visible = false;
            lblSifraoLT.Visible = false;
            lblDispensar.Text = "Dispensar";

            dgListaTrabalhadores.Height = 424;

            btRemoverTrabalhador.Visible = true;
            btCancelar.Visible = false;
        }

        private void frmTrabalhadores_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

    }
}
