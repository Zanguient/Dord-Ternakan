using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Ternakan
{
    public partial class frmGadoCadastro : Form
    {


        private bool ehAlteracao = false;
        private int IDGado;
        public frmGadoCadastro()
        {
            InitializeComponent();
        }

        private bool updateGado(int ID)
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert;
            byte[] foto1;
            byte[] foto2;
            FbParameter[] prmParametro;
            string imgL1, imgL2;
            if (pctGado1.ImageLocation != null)
                imgL1 = pctGado1.ImageLocation.ToString();
            else
                imgL1 = "";

            if (pctGado2.ImageLocation != null)
                imgL2 = pctGado2.ImageLocation.ToString();
            else
                imgL2 = "";


            if ((imgL1 != "") && (imgL2 != ""))
            {
                queryInsert = string.Format("UPDATE GADO SET ID_PIQUET = {0},NUMERO = @NUMERO,NOME = @NOME,DATA_NASCIMENTO_GADO = @DATA_NASCIMENTO_GADO,SEXO = @SEXO,PAI = @PAI,MAE = @MAE,RACA = @RACA, NUMERO_FILHO = @NUMERO_FILHO, " +
                    "NUMERO_DONOS = @NUMERO_DONOS, NUMERO_REGISTRO = @NUMERO_REGISTRO, FOTO1 = @FOTO1, FOTO2 = @FOTO2, LACTACAO_MEDIA = @LACTACAO_MEDIA, PELAGEM = @PELAGEM, TIPO_CADASTRO = @TIPO_CADASTRO, PRECO = @PRECO, DATA_ENTRADA = @DATA_ENTRADA, OBS = @OBS WHERE (ID = {1})",
                    Convert.ToInt32(cbPiquet.SelectedValue), ID);
                foto1 = imageToByteArray(pctGado1.ImageLocation);
                foto2 = imageToByteArray(pctGado2.ImageLocation);
                prmParametro = new FbParameter[17];
                prmParametro[15] = new FbParameter("@FOTO1", foto1);
                prmParametro[16] = new FbParameter("@FOTO2", foto2);
            }
            else if ((imgL1 != "") && (imgL2 == ""))
            {
                queryInsert = string.Format("UPDATE GADO SET ID_PIQUET = {0},NUMERO = @NUMERO,NOME = @NOME,DATA_NASCIMENTO_GADO = @DATA_NASCIMENTO_GADO,SEXO = @SEXO,PAI = @PAI,MAE = @MAE,RACA = @RACA, NUMERO_FILHO = @NUMERO_FILHO, " +
                  "NUMERO_DONOS = @NUMERO_DONOS, NUMERO_REGISTRO = @NUMERO_REGISTRO, FOTO1 = @FOTO1, LACTACAO_MEDIA = @LACTACAO_MEDIA, PELAGEM = @PELAGEM, TIPO_CADASTRO = @TIPO_CADASTRO, PRECO = @PRECO, DATA_ENTRADA = @DATA_ENTRADA, OBS = @OBS WHERE (ID = {1})",
                  Convert.ToInt32(cbPiquet.SelectedValue), ID);
                foto1 = imageToByteArray(pctGado1.ImageLocation);
                prmParametro = new FbParameter[17];
                prmParametro[15] = new FbParameter("@FOTO1", foto1);
                prmParametro[16] = new FbParameter("@OBS", txtObs.Text);
            }
            else if ((imgL1 == "") && (imgL2 != ""))
            {
                queryInsert = string.Format("UPDATE GADO SET ID_PIQUET = {0},NUMERO = @NUMERO,NOME = @NOME,DATA_NASCIMENTO_GADO = @DATA_NASCIMENTO_GADO,SEXO = @SEXO,PAI = @PAI,MAE = @MAE,RACA = @RACA, NUMERO_FILHO = @NUMERO_FILHO, " +
                  "NUMERO_DONOS = @NUMERO_DONOS, NUMERO_REGISTRO = @NUMERO_REGISTRO, FOTO2 = @FOTO2, LACTACAO_MEDIA = @LACTACAO_MEDIA, PELAGEM = @PELAGEM, TIPO_CADASTRO = @TIPO_CADASTRO, PRECO = @PRECO, DATA_ENTRADA = @DATA_ENTRADA, OBS = @OBS WHERE (ID = {1})",
                  Convert.ToInt32(cbPiquet.SelectedValue), ID);
                foto2 = imageToByteArray(pctGado2.ImageLocation);
                prmParametro = new FbParameter[17];
                prmParametro[15] = new FbParameter("@FOTO2", foto2);
                prmParametro[16] = new FbParameter("@OBS", txtObs.Text);
            }
            else
            {
                queryInsert = string.Format("UPDATE GADO SET ID_PIQUET = {0},NUMERO = @NUMERO,NOME = @NOME,DATA_NASCIMENTO_GADO = @DATA_NASCIMENTO_GADO,SEXO = @SEXO,PAI = @PAI,MAE = @MAE,RACA = @RACA, NUMERO_FILHO = @NUMERO_FILHO, " +
                  "NUMERO_DONOS = @NUMERO_DONOS, NUMERO_REGISTRO = @NUMERO_REGISTRO, LACTACAO_MEDIA = @LACTACAO_MEDIA, PELAGEM = @PELAGEM, TIPO_CADASTRO = @TIPO_CADASTRO, PRECO = @PRECO, DATA_ENTRADA = @DATA_ENTRADA, OBS = @OBS WHERE (ID = {1})",
                  Convert.ToInt32(cbPiquet.SelectedValue), ID);
                prmParametro = new FbParameter[16];
                prmParametro[15] = new FbParameter("@OBS", txtObs.Text);
            }


            FbCommand fbCmdInsert = new FbCommand();


            string tipo;
            if (rbCompra.Checked == true)
            {
                tipo = "Compra";
            }
            else if (rbJaPossui.Checked == true)
            {
                tipo = "Ja possui";
            }
            else if (rbNascido.Checked == true)
            {
                tipo = "Nascido";
            }
            else
            {
                tipo = "Troca";
            }
            DateTime dtentrada;
            if (txtDataEntradaGado.Text == "  /  /")
                dtentrada = DateTime.Today;
            else
                dtentrada = Convert.ToDateTime(txtDataEntradaGado.Text);

            DateTime dtNasc;
            if (txtDataNascimentoGado.Text == "  /  /")
                dtNasc = DateTime.Today;
            else
                dtNasc = Convert.ToDateTime(txtDataNascimentoGado.Text);

            double preco;
            if (txtPrecoCompraGado.Text == "")
                preco = 0;
            else
                preco = Convert.ToDouble(txtPrecoCompraGado.Text);

            //PARAMETROS



            prmParametro[0] = new FbParameter("@NUMERO", txtNumeroGado.Text);
            prmParametro[1] = new FbParameter("@NOME", txtNomeGado.Text);
            prmParametro[2] = new FbParameter("@DATA_NASCIMENTO_GADO", dtNasc);
            if (rbSexoFemea.Checked)
            {
                prmParametro[3] = new FbParameter("@SEXO", "F");
            }
            else
            {
                prmParametro[3] = new FbParameter("@SEXO", "M");
            }
            prmParametro[4] = new FbParameter("@PAI", txtNomePai.Text);
            prmParametro[5] = new FbParameter("@MAE", txtNomeMae.Text);
            prmParametro[6] = new FbParameter("@RACA", txtRacaGado.Text);
            prmParametro[7] = new FbParameter("@NUMERO_FILHO", txtNumeroFilhosGado.Text);
            prmParametro[8] = new FbParameter("@NUMERO_DONOS", txtQuantidadeDonodGado.Text);
            prmParametro[9] = new FbParameter("@NUMERO_REGISTRO", txtNumeroRegistro.Text);
            prmParametro[10] = new FbParameter("@LACTACAO_MEDIA", txtLactacaoGado.Text);
            prmParametro[11] = new FbParameter("@PELAGEM", txtPelagemGado.Text);
            prmParametro[12] = new FbParameter("@TIPO_CADASTRO", tipo);
            prmParametro[13] = new FbParameter("@PRECO", preco);
            prmParametro[14] = new FbParameter("@DATA_ENTRADA", dtentrada);


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

        public string redimensionarImagem(Image imagem, int param)
        {
            int larguraOrigem = imagem.Width;
            int alturaOrigem = imagem.Height;

            //float nPercent = 0.6;
  

            int larguraDestino = (int)(larguraOrigem * 0.6);
            int alturaDestino = (int)(alturaOrigem * 0.5);

            Bitmap b = new Bitmap(larguraDestino, alturaDestino);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imagem, 0, 0, larguraDestino, alturaDestino);
            g.Dispose();
            if (param == 1)
            {
                saveJpeg("fttemp1.jpeg", b, 80);
                b.Dispose();
                return "fttemp1.jpeg";
            }
            else
            {
                saveJpeg("fttemp2.jpeg", b, 80);
                b.Dispose();    
                return "fttemp2.jpeg";
            }
        }

        private void saveJpeg(string path, Bitmap img, long quality)
        {
            // Encoder parameter for image quality
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

            // Jpeg image codec
            ImageCodecInfo jpegCodec = this.getEncoderInfo("image/jpeg");

            if (jpegCodec == null)
                return;

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;

            img.Save(path, jpegCodec, encoderParams);
        }

        private ImageCodecInfo getEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];
            return null;
        }

        private bool cadastrarGado()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO GADO (ID_PIQUET,ID_FAZENDA,NUMERO,NOME,DATA_NASCIMENTO_GADO,SEXO,PAI,MAE,RACA, LACTACAO, NUMERO_FILHO, NUMERO_DONOS, NUMERO_REGISTRO, FOTO1, FOTO2, LACTACAO_MEDIA, PELAGEM, TIPO_CADASTRO, PRECO, DATA_ENTRADA, CIO, VENDEDOR, OBS)" +
                "VALUES ({0},{1},@NUMERO,@NOME,@DATA_NASCIMENTO_GADO,@SEXO,@PAI,@MAE,@RACA, 0, @NUMERO_FILHO, @NUMERO_DONOS, @NUMERO_REGISTRO, @FOTO1, @FOTO2, @LACTACAO_MEDIA, @PELAGEM, @TIPO_CADASTRO, @PRECO, @DATA_ENTRADA, 0, @VENDEDOR,@OBS)",
                Convert.ToInt32(cbPiquet.SelectedValue), frmHome.IDFazendaSelecionada);

            FbCommand fbCmdInsert = new FbCommand();
            byte[] foto1;
            byte[] foto2;

            if (pctGado1.Image != null)
                foto1 = imageToByteArray(redimensionarImagem(pctGado1.Image, 1));
            else
                foto1 = null;

            if (pctGado2.Image != null)
                foto2 = imageToByteArray(redimensionarImagem(pctGado2.Image, 2));
            else
                foto2 = null;

            string tipo;
            if (rbCompra.Checked == true)
            {
                tipo = "Compra";
            }
            else if (rbJaPossui.Checked == true)
            {
                tipo = "Ja possui";
            }
            else if (rbNascido.Checked == true)
            {
                tipo = "Nascido";
            }
            else
            {
                tipo = "Troca";
            }
            DateTime dtentrada;
            if (txtDataEntradaGado.Text == "  /  /")
                dtentrada = DateTime.Today;
            else
                dtentrada = Convert.ToDateTime(txtDataEntradaGado.Text);

            DateTime dtNasc;
            if (txtDataNascimentoGado.Text == "  /  /")
                dtNasc = DateTime.Today;
            else
                dtNasc = Convert.ToDateTime(txtDataNascimentoGado.Text);

            double preco;
            if (txtPrecoCompraGado.Text == "")
                preco = 0;
            else
                preco = Convert.ToDouble(txtPrecoCompraGado.Text);

            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[19];

            prmParametro[0] = new FbParameter("@NUMERO", txtNumeroGado.Text);
            prmParametro[1] = new FbParameter("@NOME", txtNomeGado.Text);
            prmParametro[2] = new FbParameter("@DATA_NASCIMENTO_GADO", dtNasc);
            if (rbSexoFemea.Checked)
            {
                prmParametro[3] = new FbParameter("@SEXO", "F");
            }
            else
            {
                prmParametro[3] = new FbParameter("@SEXO", "M");
            }
            prmParametro[4] = new FbParameter("@PAI", txtNomePai.Text);
            prmParametro[5] = new FbParameter("@MAE", txtNomeMae.Text);
            prmParametro[6] = new FbParameter("@RACA", txtRacaGado.Text);
            //  prmParametro[7] = new FbParameter("@LACTACAO", 0);
            prmParametro[7] = new FbParameter("@NUMERO_FILHO", txtNumeroFilhosGado.Text);
            prmParametro[8] = new FbParameter("@NUMERO_DONOS", txtQuantidadeDonodGado.Text);
            prmParametro[9] = new FbParameter("@NUMERO_REGISTRO", txtNumeroRegistro.Text);
            //Ver Fotos depois
            prmParametro[10] = new FbParameter("@FOTO1", foto1);
            prmParametro[11] = new FbParameter("@FOTO2", foto2);
            prmParametro[12] = new FbParameter("@LACTACAO_MEDIA", txtLactacaoGado.Text);
            prmParametro[13] = new FbParameter("@PELAGEM", txtPelagemGado.Text);
            prmParametro[14] = new FbParameter("@TIPO_CADASTRO", tipo);
            prmParametro[15] = new FbParameter("@PRECO", preco);
            prmParametro[16] = new FbParameter("@DATA_ENTRADA", dtentrada);
            prmParametro[17] = new FbParameter("@VENDEDOR", txtNomeVendedor.Text);
            prmParametro[18] = new FbParameter("@OBS", txtObs.Text);


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
        private void limparCampos()
        {
            txtNomeGado.Clear();
            txtDataEntradaGado.Clear();
            txtDataNascimentoGado.Clear();
            txtLactacaoGado.Clear();
            txtNomeGado.Clear();
            txtNomeMae.Clear();
            txtNomePai.Clear();
            txtNomeVendedor.Clear();
            txtNumeroFilhosGado.Clear();
            txtNumeroGado.Clear();
            txtNumeroRegistro.Clear();
            txtPelagemGado.Clear();
            txtPrecoCompraGado.Clear();
            txtQuantidadeDonodGado.Clear();
            txtRacaGado.Clear();
            txtObs.Clear();
            cxGadoRegistrado.Checked = false;
            pctGado1.Image = null;
            pctGado2.Image = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (cxGadoRegistrado.Checked == true && txtNumeroRegistro.Text == "")
                MessageBox.Show("Favor preencher o numero do registro ou desmarcá-lo");
            else if (rbSexoFemea.Checked == false && rbSexoMasculino.Checked == false)
                MessageBox.Show("Favor preencher o sexo do animal");
            else if (txtNumeroGado.Text == "")
                MessageBox.Show("Favor informar o número do animal");
            else if (txtNomeGado.Text == "")
                MessageBox.Show("Favor informar o nome do animal");
            else if (rbCompra.Checked == true && (txtPrecoCompraGado.Text == "" || txtNomeVendedor.Text == ""))
                MessageBox.Show("Favor colocar o preço e/ou Nome do Vendedor");
            else if (txtPrecoCompraGado.Text != "" && rbCompra.Checked == false)
                MessageBox.Show("Favor marcar a entrada como compra");
            else if (rbCompra.Checked == false && rbJaPossui.Checked == false && rbNascido.Checked == false && rbTroca.Checked == false)
                MessageBox.Show("Favor marcar o tipo de entrada");
            else if ((rbCompra.Checked == true || rbTroca.Checked == true) && (txtDataEntradaGado.Text == "  /  /"))
                MessageBox.Show("Preencher a data que esse gado foi comprado ou trocado");
            else
            {


                string mensagem = "";
                try
                {
                    if (!ehAlteracao)
                    {
                        if (cadastrarGado())
                        {
                            mensagem = "Gado cadastrado com sucesso";
                            limparCampos();
                        }
                    }
                    else
                    {

                        if (updateGado(IDGado))
                        {
                            mensagem = "Gado alterado com sucesso";
                            Close();
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Erro ao armazenar no banco de dados\n" + ee.Message);
                }
                MessageBox.Show(mensagem);


            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public byte[] imageToByteArray(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            return (br.ReadBytes(Convert.ToInt32(br.BaseStream.Length)));
        }

        private void btVoltarGadocadastro_Click(object sender, EventArgs e)
        {
            limparCampos();
        }


       

        private Image bytetoImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);


            ms.Write(bytes, 0, bytes.Length);

            return Image.FromStream(ms, true);



        }

        public void ehUpdate(int ID)
        {
            ehAlteracao = true;
            IDGado = ID;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID,NUMERO,NOME,DATA_NASCIMENTO_GADO,VENDEDOR,SEXO,PAI,MAE,RACA, LACTACAO, NUMERO_FILHO, NUMERO_DONOS, NUMERO_REGISTRO, FOTO1, FOTO2, LACTACAO_MEDIA, PELAGEM, TIPO_CADASTRO, PRECO, DATA_ENTRADA, CIO, OBS FROM GADO WHERE ID = {0}", ID);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                if (r.Read())
                {
                    txtNomeGado.Text = r["NOME"].ToString();
                    if (r["DATA_NASCIMENTO_GADO"].ToString() != "")
                        txtDataNascimentoGado.Text = Convert.ToDateTime(r["DATA_NASCIMENTO_GADO"]).ToString("dd/MM/yyyy");


                    rbSexoMasculino.Checked = (r["SEXO"].ToString() == "M");
                    rbSexoFemea.Checked = (r["SEXO"].ToString() == "F");

                    txtNomePai.Text = r["PAI"].ToString();
                    txtNomeMae.Text = r["MAE"].ToString();
                    txtRacaGado.Text = r["RACA"].ToString();
                    txtNumeroFilhosGado.Text = r["NUMERO_FILHO"].ToString();
                    txtQuantidadeDonodGado.Text = r["NUMERO_DONOS"].ToString();
                    txtLactacaoGado.Text = r["LACTACAO_MEDIA"].ToString();
                    txtPelagemGado.Text = r["PELAGEM"].ToString();
                    txtNumeroRegistro.Text = r["NUMERO_REGISTRO"].ToString();
                    txtNumeroGado.Text = r["NUMERO"].ToString();
                    txtObs.Text = r["OBS"].ToString();

                    if (r["PRECO"].ToString() == "0")
                        txtPrecoCompraGado.Text = "";
                    else
                        txtPrecoCompraGado.Text = r["PRECO"].ToString();

                    if (r["DATA_ENTRADA"].ToString() != "")
                        txtDataEntradaGado.Text = Convert.ToDateTime(r["DATA_ENTRADA"]).ToString("dd/MM/yyyy");

                    rbCompra.Checked = (r["TIPO_CADASTRO"].ToString() == "Compra");
                    rbJaPossui.Checked = (r["TIPO_CADASTRO"].ToString() == "Ja possui");
                    rbNascido.Checked = (r["TIPO_CADASTRO"].ToString() == "Nascido");
                    rbTroca.Checked = (r["TIPO_CADASTRO"].ToString() == "Troca");

                    txtNomeVendedor.Text = r["VENDEDOR"].ToString();
                    if (!((r["FOTO1"]) is DBNull))
                        pctGado1.Image = bytetoImage((byte[])(r["FOTO1"]));
                    if (!((r["FOTO2"]) is DBNull))
                        pctGado2.Image = bytetoImage((byte[])r["FOTO2"]);
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

        private void frmGadoCadastro_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada;

            //atualizacb
            atualizarCbPiquet();


            txtNomeVendedor.Visible = rbCompra.Checked;
            lbVendedor.Visible = rbCompra.Checked;
        }

        private void atualizarCbPiquet()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID, NOME, NUMERO FROM PIQUET WHERE ID_FAZENDA = {0}", frmHome.IDFazendaSelecionada);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    string s = r[1].ToString() + " - " + r[2].ToString();
                    retorno.Add(Convert.ToInt32(r[0].ToString()), s);
                }
                if (retorno.Count != 0)
                {
                    cbPiquet.DataSource = new BindingSource(retorno, null);
                    cbPiquet.DisplayMember = "Value";
                    cbPiquet.ValueMember = "Key";
                    cbPiquet.Refresh();
                }
                else
                {
                    MessageBox.Show("Não há piquets cadastrados para esta fazenda.\nCadastre um piquet primeiro");
                    Close();
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


        private void pctGado1_Click(object sender, EventArgs e)
        {

            dlgImagem.Filter = "Imagens (*.png; *.jpg; *.gif; *.jpeg; *.bmp)|*.png; *.jpg; *.gif; *.jpeg; *.bmp";//|gif(*.gif)|*.gif|jpeg(*.jpeg)|*.jpeg |Bitmap (*.bmp)|*.bmp";
            if (dlgImagem.ShowDialog(this) == DialogResult.OK)
            {
                pctGado1.ImageLocation = dlgImagem.FileName;
            }


        }

        private void pctGado2_Click(object sender, EventArgs e)
        {
            dlgImagem.Filter = "Imagens (*.png; *.jpg; *.gif; *.jpeg; *.bmp)|*.png; *.jpg; *.gif; *.jpeg; *.bmp";//|gif(*.gif)|*.gif|jpeg(*.jpeg)|*.jpeg |Bitmap (*.bmp)|*.bmp";
            if (dlgImagem.ShowDialog(this) == DialogResult.OK)
            {
                pctGado2.ImageLocation = dlgImagem.FileName;
            }
        }

        private void rbCompra_Click(object sender, EventArgs e)
        {
            txtNomeVendedor.Visible = rbCompra.Checked;
            lbVendedor.Visible = rbCompra.Checked;
        }






    }
}

