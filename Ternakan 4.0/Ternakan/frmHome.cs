using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;

namespace Ternakan
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }


        public static string strConn = ConfigurationManager.AppSettings["conexao"];
        public static int IDFazendaSelecionada;
        public static bool admin = false;
        public static bool logado = false;
        public static string NomeFazendaSelecionada;
        public static string usuarioSelecionado;
        public static int IDusuarioSelecionado;
        public static bool mandarEmail(string textoCorpo)
        {
            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            cliente.EnableSsl = true;
            MailAddress remetente = new MailAddress("ternakansystem@gmail.com", "Ternakan");
            MailAddress destinatario = new MailAddress(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["nome"]);
            MailMessage mensagem = new MailMessage(remetente, destinatario);
            mensagem.Body = textoCorpo;
            mensagem.Subject = "Alerta sistema Ternakan";
            NetworkCredential credenciais = new NetworkCredential("ternakansystem@gmail.com", "12344321", "");
            cliente.Credentials = credenciais;

            try
            {
                cliente.Send(mensagem);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tudo em c# tem quem ser instanciado antes de usar. Forms nao sao diferentes.
            frmFazendaCadastro frm = new frmFazendaCadastro();

            
            //frm.Show();//Esse mostra o formulario, e ainda permite usar o form que o instanciou.
            frm.Show(); //Esse mostra o form, e nao deixa mexer no form que o instaciou
            
        }

        private void mnsPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adicionarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto();
            frm.ShowDialog();
        }

        private void imprimirDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adicionaRemoverTrabalhadores frm = new adicionaRemoverTrabalhadores();
            frm.ShowDialog();
        }

        private void buscaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBusca frm =  new frmBusca();
            frm.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGadoCadastro frm = new frmGadoCadastro();
            frm.ShowDialog();           
        }

        private void selecionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelecionarFazenda frm = new frmSelecionarFazenda();
            frm.ShowDialog();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdicionarPiquets frm = new frmAdicionarPiquets();
            frm.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrAlterarPiquet frm = new fmrAlterarPiquet();
            frm.ShowDialog();
        }

        private void gadoRegistradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGadoRegistrado frm = new frmGadoRegistrado();
            frm.ShowDialog();
        }

        private void quantidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuantidadeGado frm = new frmQuantidadeGado();
            frm.ShowDialog();
        }

        private void vacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVacinacao frm = new frmVacinacao();
            frm.ShowDialog();
        }

        private void mortalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMortalidade frm = new frmMortalidade();
            frm.ShowDialog();
        }

        private void natalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGadoCadastro frm = new frmGadoCadastro();
            frm.rbCompra.Checked = true;
            frm.ShowDialog();
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaidaAnimais frm = new frmSaidaAnimais();
            frm.ShowDialog();
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioEntrada frm = new frmRelatorioEntrada();
            frm.ShowDialog();
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioSaida frm = new frmRelatorioSaida();
            frm.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda frm = new frmAgenda();
            frm.ShowDialog();
        }

        private void adicionarVacaNasLactaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reproduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inclluirLactaçãoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLactacaoDia frm = new frmLactacaoDia();
            frm.ShowDialog();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarVacaLactacao frm = new frmAdicionarVacaLactacao();
            frm.ShowDialog();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevomerVacaLactacao frm = new frmRevomerVacaLactacao();
            frm.ShowDialog();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncluirCruzamento frm = new frmIncluirCruzamento();
            frm.ShowDialog();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRemoverCruzamento frm = new frmRemoverCruzamento();
            frm.ShowDialog();
        }

        private void previsãoParaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrevisaoNascimento frm = new frmPrevisaoNascimento();
            frm.ShowDialog();
        }

        private void imprimirTodosOsPerfisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem ceteza que deseja imprimir todos os perfis?\nIsso pode demorar alguns instantes", "Imprimir perfis", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //dsTernakan.GetChanges();
                VerRelatorio frm = new VerRelatorio();
                frm.carregarRelatorioPerfilGado();
                frm.ShowDialog();
            }
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscolherPiquet frm = new frmEscolherPiquet();
            frm.ShowDialog();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntervaloDe_Lactacao frm = new frmIntervaloDe_Lactacao();
            frm.ShowDialog();
        }

        private void fazendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sememToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   frmSemem frm = new frmSemem();
           // frm.Show();
        }

        private void frmFazendaCadastrar_Load(object sender, EventArgs e)
        {
            
        }
        private void aletarEventosAngenda()
        {
            try
            {
                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                //Firebird
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT ID, EVENTO, DATA_ALERTA FROM AGENDA WHERE ((DATA_ALERTA = '{0}') AND (ALERTADO = 0) )",
                DateTime.Today.ToString("MM/dd/yyyy"));


                FbCommand fbCmd = new FbCommand(query, fbConn);
                FbCommand fbCmdUpdate;
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();
                    while (r.Read())
                    {
                        mandarEmail(string.Format("Olá,\nHoje será o evento {0}",
                             r[1]));
                        MessageBox.Show(string.Format("Olá, Hoje será o evento {0}",r[1]));
                        fbCmdUpdate = new FbCommand(string.Format("UPDATE AGENDA SET ALERTADO = 1 WHERE ID = {0}", r[0]), fbConn);
                        fbCmdUpdate.ExecuteNonQuery();
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
            catch (Exception ee)
            {
                MessageBox.Show("Erro:\n" + ee.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void alertarAniversarioTrabalhadores()
        {
            try
            {
                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                //Firebird
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT NOME, DATA_NASCIMENTO FROM TRABALHADOR WHERE ((ID_FAZENDA = {0}) AND (ATIVIDADE = 1))",
                   frmHome.IDFazendaSelecionada);
                

                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();
                    while (r.Read())
                    {
                        int dia, mes;
                        if (!(r[1] is DBNull))
                        {
                            dia = Convert.ToDateTime(r[1]).Day;
                            mes = Convert.ToDateTime(r[1]).Month;
                            if ((dia == DateTime.Today.Day) && (mes == DateTime.Today.Month))
                            {
                                mandarEmail(string.Format("Olá,\nHoje é aniversário do(a) funcionario(a) {0}",
                            r[0]));
                            }
                        }
                       
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
            catch (Exception ee)
            {
                MessageBox.Show("Erro:\n" + ee.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            alertarAniversarioTrabalhadores();
            aletarEventosAngenda();
            timer1.Enabled = false;
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGadoCadastro frm = new frmGadoCadastro();
            frm.rbNascido.Checked = true;
            frm.ShowDialog();
        }

        private void relatórioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
                frmIntervaloNascimento frm = new frmIntervaloNascimento();
                frm.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAgenda frm = new frmAgenda();
            frm.ShowDialog();
        }

        private void alterarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarEmail frm = new frmAlterarEmail();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFazendaCadastro frm = new frmFazendaCadastro();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios frm = new frmCadastroUsuarios();
            frm.ShowDialog();
        }

        private void permissao()
        {
            usuáriosToolStripMenuItem.Visible = admin;
            configuraçõesToolStripMenuItem.Visible = admin;
            mortalidadeToolStripMenuItem.Visible = admin;
            saídaToolStripMenuItem.Visible = admin;
            cadastrarToolStripMenuItem.Visible = admin;
            trabalhadoresInativosToolStripMenuItem.Visible = admin;
            trabalhadoresToolStripMenuItem.Visible = admin;
        }

        private void frmHome_Shown(object sender, EventArgs e)
        {
            mnsPrincipal.Visible = false;
            frmSelecionarFazenda frm = new frmSelecionarFazenda();
            frm.ShowDialog();
            mnsPrincipal.Visible = true;
            permissao();
            adicionar_campo();
            timer1.Enabled = true;

            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void adicionar_campo()
        {
                //Firebird
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query = "ALTER TABLE saida_animais ADD observacao VARCHAR(100);";
                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();
                    fbCmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    if (fbex.ErrorCode != 335544351) // Ja existe
                        MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");
                }
                finally
                {
                    fbConn.Close();
                }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrRemoverUsuario frm = new fmrRemoverUsuario();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void cadastrarSemensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadSemem frm = new frmCadSemem();
            frm.ShowDialog();
        }

        private void trabalhadoresInativosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrabalhadoresInativos frm = new frmTrabalhadoresInativos();
            frm.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox frm = new frmAboutBox();
            frm.ShowDialog();
        }

        private void trocarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelecionarFazenda frm = new frmSelecionarFazenda();
            frm.ShowDialog();
        }

        private void semensCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSemensCadastrados frm = new frmSemensCadastrados();
            frm.ShowDialog();
        }

        private void frmHome_Activated(object sender, EventArgs e)
        {
            permissao();
        }

        private void lactaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLactacaoDg frm = new frmLactacaoDg();
            frm.ShowDialog();
        }

        private void lactaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerRelatorio vr = new VerRelatorio();
            vr.relatorioEmBranco(0);
            vr.Show();
        }

        private void cruzamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerRelatorio vr = new VerRelatorio();
            vr.relatorioEmBranco(2);
            vr.Show();
        }

        private void vacinaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerRelatorio vr = new VerRelatorio();
            vr.relatorioEmBranco(1);
            vr.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMudarSenha frm = new frmMudarSenha();
            frm.ShowDialog();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome2 frm = new frmHome2();
            frm.ShowDialog();
        }

      
    }
}