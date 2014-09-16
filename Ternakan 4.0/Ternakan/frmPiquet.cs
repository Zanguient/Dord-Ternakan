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
    public partial class frmPiquet : Form
    {
        private bool alterar = false;
        private bool mudouDeTab = false;
        public frmPiquet()
        {
            InitializeComponent();
        }

        private void voltarInicio(bool mudar)
        {
            if (mudar == true)
            {
                alterar = false;
                lblNovoNomePiquet.Visible = false;
                lblNovoNumeroPiquet.Visible = false;
                lbCancelar.Visible = false;

                txtNovoNomePiquet.Text = "";
                txtNovoNumeroPiquet.Text = "";

                txtNovoNomePiquet.Visible = false;
                txtNovoNumeroPiquet.Visible = false;

                btCancelar.Visible = false;

                dgPiquets.Height = 193;
            }
            else
            {
                txtNomePiquet.Text = "";
                txtNumeroPiquet.Text = "";
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (alterar == false)
            {
                alterar = true;
                lblNovoNomePiquet.Visible = true;
                lblNovoNumeroPiquet.Visible = true;
                lbCancelar.Visible = true;

                txtNovoNomePiquet.Visible = true;
                txtNovoNumeroPiquet.Visible = true;

                btCancelar.Visible = true;

                dgPiquets.Height = 150;
            }
            else
            {
                if (txtNovoNomePiquet.Text == "" || txtNovoNumeroPiquet.Text == "")
                    MessageBox.Show("Favor preencher todos os campos.");
                else
                {
                    //commit
                    voltarInicio(true);
                }
            }
        }

        private void btCadastrarPiquet_Click(object sender, EventArgs e)
        {
            if (txtNomePiquet.Text == "" || txtNumeroPiquet.Text == "")
                MessageBox.Show("Favor preencher todos os campos.");
            else
            {
                //commit
                voltarInicio(false);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            voltarInicio(true);
        }

        private void frmPiquet_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
