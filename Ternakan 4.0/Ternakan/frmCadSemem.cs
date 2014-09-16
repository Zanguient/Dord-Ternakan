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
    public partial class frmCadSemem : Form
    {
        public frmCadSemem()
        {
            InitializeComponent();
        }

        private void btVoltarAdicionarPiquet_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool cadastrarSemem()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO SEMEN (NOME,RACA,CANECA,QUANTIDADE,REGISTRO, ID_FAZENDA) VALUES (@NOME,@RACA,@CANECA,@QUANTIDADE,@REGISTRO, {0})",
                frmHome.IDFazendaSelecionada);

            FbCommand fbCmdInsert = new FbCommand();


            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[5];

            prmParametro[0] = new FbParameter("@NOME", txtNome.Text);
            prmParametro[1] = new FbParameter("@RACA", txtRaca.Text);
            prmParametro[2] = new FbParameter("@CANECA", txtCaneca.Text);
            if (txtQuantidade.Text != "")
                prmParametro[3] = new FbParameter("@QUANTIDADE", Convert.ToDouble(txtQuantidade.Text));
            else
                prmParametro[3] = new FbParameter("@QUANTIDADE", 0);

            prmParametro[4] = new FbParameter("@REGISTRO", txtRegistro.Text);

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

        private void btCadastrarPiquet_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtRaca.Text == "")
                MessageBox.Show("Favor preencher todos os campos");
            else
            {
                bool retorno;
                retorno = cadastrarSemem();
                if (retorno)
                {
                    MessageBox.Show("Semem cadastrado");
                    txtNome.Clear();
                    txtRaca.Clear();
                    txtNome.Focus();
                    txtCaneca.Clear();
                    txtQuantidade.Clear();
                    txtRegistro.Clear();
                }
                //Close();
            }
        }

        private void frmCadSemem_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
