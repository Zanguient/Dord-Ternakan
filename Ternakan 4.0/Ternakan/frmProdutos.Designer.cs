namespace Ternakan
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btLimparCampos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btAdicionarLista = new System.Windows.Forms.Button();
            this.txtValorProdutoUnitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.txtDatCompraAE = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCompraAE = new System.Windows.Forms.Label();
            this.txtValorUnitarioAE = new System.Windows.Forms.TextBox();
            this.lblValorUnitarioAE = new System.Windows.Forms.Label();
            this.txtNomeProdutoAE = new System.Windows.Forms.TextBox();
            this.txtQuantidadeAE = new System.Windows.Forms.TextBox();
            this.lblNomeProdutoAE = new System.Windows.Forms.Label();
            this.lblQuantidadeAE = new System.Windows.Forms.Label();
            this.txtNotaFiscalAE = new System.Windows.Forms.TextBox();
            this.lblNotaFiscalAE = new System.Windows.Forms.Label();
            this.txtEmpresaAE = new System.Windows.Forms.TextBox();
            this.lblEmpresaAE = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btLimparCampos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDataCompra);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btAdicionarLista);
            this.tabPage1.Controls.Add(this.txtValorProdutoUnitario);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtNomeProduto);
            this.tabPage1.Controls.Add(this.txtQuantidadeProduto);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNotaFiscal);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEmpresa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar Compra de Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Limpar Campos";
            // 
            // btLimparCampos
            // 
            this.btLimparCampos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLimparCampos.BackgroundImage")));
            this.btLimparCampos.Location = new System.Drawing.Point(328, 147);
            this.btLimparCampos.Name = "btLimparCampos";
            this.btLimparCampos.Size = new System.Drawing.Size(50, 50);
            this.btLimparCampos.TabIndex = 8;
            this.btLimparCampos.UseVisualStyleBackColor = true;
            this.btLimparCampos.Click += new System.EventHandler(this.btLimparCampos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Adicionar";
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCompra.Location = new System.Drawing.Point(466, 23);
            this.txtDataCompra.Mask = "00/00/0000";
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(105, 22);
            this.txtDataCompra.TabIndex = 3;
            this.txtDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 81;
            this.label10.Text = "Data de compra:";
            // 
            // btAdicionarLista
            // 
            this.btAdicionarLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdicionarLista.BackgroundImage")));
            this.btAdicionarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarLista.Location = new System.Drawing.Point(200, 147);
            this.btAdicionarLista.Name = "btAdicionarLista";
            this.btAdicionarLista.Size = new System.Drawing.Size(50, 50);
            this.btAdicionarLista.TabIndex = 7;
            this.btAdicionarLista.UseVisualStyleBackColor = true;
            this.btAdicionarLista.Click += new System.EventHandler(this.btAdicionarLista_Click);
            // 
            // txtValorProdutoUnitario
            // 
            this.txtValorProdutoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProdutoUnitario.Location = new System.Drawing.Point(466, 64);
            this.txtValorProdutoUnitario.Name = "txtValorProdutoUnitario";
            this.txtValorProdutoUnitario.Size = new System.Drawing.Size(105, 22);
            this.txtValorProdutoUnitario.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Valor unitário:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(94, 64);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(364, 22);
            this.txtNomeProduto.TabIndex = 5;
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(6, 64);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(82, 22);
            this.txtQuantidadeProduto.TabIndex = 4;
            this.txtQuantidadeProduto.TextChanged += new System.EventHandler(this.txtQuantidadeProduto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Nome do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Quantidade:";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaFiscal.Location = new System.Drawing.Point(309, 23);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(149, 22);
            this.txtNotaFiscal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Número da nota fiscal:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(6, 23);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(294, 22);
            this.txtEmpresa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Empresa:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCancelar);
            this.tabPage2.Controls.Add(this.txtDatCompraAE);
            this.tabPage2.Controls.Add(this.lblDataCompraAE);
            this.tabPage2.Controls.Add(this.txtValorUnitarioAE);
            this.tabPage2.Controls.Add(this.lblValorUnitarioAE);
            this.tabPage2.Controls.Add(this.txtNomeProdutoAE);
            this.tabPage2.Controls.Add(this.txtQuantidadeAE);
            this.tabPage2.Controls.Add(this.lblNomeProdutoAE);
            this.tabPage2.Controls.Add(this.lblQuantidadeAE);
            this.tabPage2.Controls.Add(this.txtNotaFiscalAE);
            this.tabPage2.Controls.Add(this.lblNotaFiscalAE);
            this.tabPage2.Controls.Add(this.txtEmpresaAE);
            this.tabPage2.Controls.Add(this.lblEmpresaAE);
            this.tabPage2.Controls.Add(this.btCancelar);
            this.tabPage2.Controls.Add(this.lblAlterar);
            this.tabPage2.Controls.Add(this.btAlterar);
            this.tabPage2.Controls.Add(this.dgProdutos);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar ou Excluir Compras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Location = new System.Drawing.Point(219, 336);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(70, 16);
            this.lblCancelar.TabIndex = 125;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            // 
            // txtDatCompraAE
            // 
            this.txtDatCompraAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatCompraAE.Location = new System.Drawing.Point(466, 212);
            this.txtDatCompraAE.Mask = "00/00/0000";
            this.txtDatCompraAE.Name = "txtDatCompraAE";
            this.txtDatCompraAE.Size = new System.Drawing.Size(105, 22);
            this.txtDatCompraAE.TabIndex = 3;
            this.txtDatCompraAE.ValidatingType = typeof(System.DateTime);
            this.txtDatCompraAE.Visible = false;
            // 
            // lblDataCompraAE
            // 
            this.lblDataCompraAE.AutoSize = true;
            this.lblDataCompraAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompraAE.Location = new System.Drawing.Point(463, 196);
            this.lblDataCompraAE.Name = "lblDataCompraAE";
            this.lblDataCompraAE.Size = new System.Drawing.Size(123, 16);
            this.lblDataCompraAE.TabIndex = 124;
            this.lblDataCompraAE.Text = "Data de compra:";
            this.lblDataCompraAE.Visible = false;
            // 
            // txtValorUnitarioAE
            // 
            this.txtValorUnitarioAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitarioAE.Location = new System.Drawing.Point(466, 253);
            this.txtValorUnitarioAE.Name = "txtValorUnitarioAE";
            this.txtValorUnitarioAE.Size = new System.Drawing.Size(105, 22);
            this.txtValorUnitarioAE.TabIndex = 6;
            this.txtValorUnitarioAE.Visible = false;
            // 
            // lblValorUnitarioAE
            // 
            this.lblValorUnitarioAE.AutoSize = true;
            this.lblValorUnitarioAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitarioAE.Location = new System.Drawing.Point(467, 237);
            this.lblValorUnitarioAE.Name = "lblValorUnitarioAE";
            this.lblValorUnitarioAE.Size = new System.Drawing.Size(104, 16);
            this.lblValorUnitarioAE.TabIndex = 122;
            this.lblValorUnitarioAE.Text = "Valor unitário:";
            this.lblValorUnitarioAE.Visible = false;
            // 
            // txtNomeProdutoAE
            // 
            this.txtNomeProdutoAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProdutoAE.Location = new System.Drawing.Point(101, 253);
            this.txtNomeProdutoAE.Name = "txtNomeProdutoAE";
            this.txtNomeProdutoAE.Size = new System.Drawing.Size(357, 22);
            this.txtNomeProdutoAE.TabIndex = 5;
            this.txtNomeProdutoAE.Visible = false;
            this.txtNomeProdutoAE.TextChanged += new System.EventHandler(this.txtNomeProdutoAE_TextChanged);
            // 
            // txtQuantidadeAE
            // 
            this.txtQuantidadeAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeAE.Location = new System.Drawing.Point(6, 253);
            this.txtQuantidadeAE.Name = "txtQuantidadeAE";
            this.txtQuantidadeAE.Size = new System.Drawing.Size(87, 22);
            this.txtQuantidadeAE.TabIndex = 4;
            this.txtQuantidadeAE.Visible = false;
            // 
            // lblNomeProdutoAE
            // 
            this.lblNomeProdutoAE.AutoSize = true;
            this.lblNomeProdutoAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoAE.Location = new System.Drawing.Point(99, 237);
            this.lblNomeProdutoAE.Name = "lblNomeProdutoAE";
            this.lblNomeProdutoAE.Size = new System.Drawing.Size(132, 16);
            this.lblNomeProdutoAE.TabIndex = 121;
            this.lblNomeProdutoAE.Text = "Nome do produto:";
            this.lblNomeProdutoAE.Visible = false;
            // 
            // lblQuantidadeAE
            // 
            this.lblQuantidadeAE.AutoSize = true;
            this.lblQuantidadeAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeAE.Location = new System.Drawing.Point(3, 237);
            this.lblQuantidadeAE.Name = "lblQuantidadeAE";
            this.lblQuantidadeAE.Size = new System.Drawing.Size(92, 16);
            this.lblQuantidadeAE.TabIndex = 120;
            this.lblQuantidadeAE.Text = "Quantidade:";
            this.lblQuantidadeAE.Visible = false;
            // 
            // txtNotaFiscalAE
            // 
            this.txtNotaFiscalAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaFiscalAE.Location = new System.Drawing.Point(307, 212);
            this.txtNotaFiscalAE.Name = "txtNotaFiscalAE";
            this.txtNotaFiscalAE.Size = new System.Drawing.Size(151, 22);
            this.txtNotaFiscalAE.TabIndex = 2;
            this.txtNotaFiscalAE.Visible = false;
            // 
            // lblNotaFiscalAE
            // 
            this.lblNotaFiscalAE.AutoSize = true;
            this.lblNotaFiscalAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFiscalAE.Location = new System.Drawing.Point(302, 196);
            this.lblNotaFiscalAE.Name = "lblNotaFiscalAE";
            this.lblNotaFiscalAE.Size = new System.Drawing.Size(163, 16);
            this.lblNotaFiscalAE.TabIndex = 119;
            this.lblNotaFiscalAE.Text = "Número da nota fiscal:";
            this.lblNotaFiscalAE.Visible = false;
            // 
            // txtEmpresaAE
            // 
            this.txtEmpresaAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresaAE.Location = new System.Drawing.Point(6, 212);
            this.txtEmpresaAE.Name = "txtEmpresaAE";
            this.txtEmpresaAE.Size = new System.Drawing.Size(292, 22);
            this.txtEmpresaAE.TabIndex = 1;
            this.txtEmpresaAE.Visible = false;
            // 
            // lblEmpresaAE
            // 
            this.lblEmpresaAE.AutoSize = true;
            this.lblEmpresaAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaAE.Location = new System.Drawing.Point(3, 196);
            this.lblEmpresaAE.Name = "lblEmpresaAE";
            this.lblEmpresaAE.Size = new System.Drawing.Size(74, 16);
            this.lblEmpresaAE.TabIndex = 118;
            this.lblEmpresaAE.Text = "Empresa:";
            this.lblEmpresaAE.Visible = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancelar.BackgroundImage")));
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(229, 283);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(50, 50);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblAlterar
            // 
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Location = new System.Drawing.Point(270, 336);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(54, 16);
            this.lblAlterar.TabIndex = 12;
            this.lblAlterar.Text = "Alterar";
            // 
            // btAlterar
            // 
            this.btAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAlterar.BackgroundImage")));
            this.btAlterar.Location = new System.Drawing.Point(271, 283);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(50, 50);
            this.btAlterar.TabIndex = 8;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(6, 6);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(569, 269);
            this.dgProdutos.TabIndex = 9;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 412);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(629, 450);
            this.MinimumSize = new System.Drawing.Size(629, 450);
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            this.Shown += new System.EventHandler(this.frmProdutos_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox txtDataCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btAdicionarLista;
        private System.Windows.Forms.TextBox txtValorProdutoUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btLimparCampos;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.DataGridView dgProdutos;
        protected System.Windows.Forms.Label lblAlterar;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.MaskedTextBox txtDatCompraAE;
        protected System.Windows.Forms.Label lblDataCompraAE;
        protected System.Windows.Forms.TextBox txtValorUnitarioAE;
        protected System.Windows.Forms.Label lblValorUnitarioAE;
        protected System.Windows.Forms.TextBox txtNomeProdutoAE;
        protected System.Windows.Forms.TextBox txtQuantidadeAE;
        protected System.Windows.Forms.Label lblNomeProdutoAE;
        protected System.Windows.Forms.Label lblQuantidadeAE;
        protected System.Windows.Forms.TextBox txtNotaFiscalAE;
        protected System.Windows.Forms.Label lblNotaFiscalAE;
        protected System.Windows.Forms.TextBox txtEmpresaAE;
        protected System.Windows.Forms.Label lblEmpresaAE;
        protected System.Windows.Forms.Label lblCancelar;
    }
}