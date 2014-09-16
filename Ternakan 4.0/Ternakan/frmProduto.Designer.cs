namespace Ternakan
{
    partial class frmProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btAdicionarLista = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorProdutoUnitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btImprimirRelatorioProdutos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btVoltarProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(9, 47);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(305, 20);
            this.txtEmpresa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Número da nota fiscal:";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Location = new System.Drawing.Point(328, 47);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(133, 20);
            this.txtNotaFiscal.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDataCompra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btAdicionarLista);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtValorProdutoUnitario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNomeProduto);
            this.groupBox1.Controls.Add(this.txtQuantidadeProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNotaFiscal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incluir Produtos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Location = new System.Drawing.Point(98, 70);
            this.txtDataCompra.Mask = "00/00/0000";
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(67, 20);
            this.txtDataCompra.TabIndex = 3;
            this.txtDataCompra.ValidatingType = typeof(System.DateTime);
            this.txtDataCompra.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Data de compra:";
            // 
            // btAdicionarLista
            // 
            this.btAdicionarLista.Location = new System.Drawing.Point(211, 142);
            this.btAdicionarLista.Name = "btAdicionarLista";
            this.btAdicionarLista.Size = new System.Drawing.Size(61, 23);
            this.btAdicionarLista.TabIndex = 7;
            this.btAdicionarLista.Text = "Adicionar";
            this.btAdicionarLista.UseVisualStyleBackColor = true;
            this.btAdicionarLista.Click += new System.EventHandler(this.btAdicionarLista_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "R$-";
            // 
            // txtValorProdutoUnitario
            // 
            this.txtValorProdutoUnitario.Location = new System.Drawing.Point(104, 144);
            this.txtValorProdutoUnitario.Name = "txtValorProdutoUnitario";
            this.txtValorProdutoUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtValorProdutoUnitario.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Valor unitário:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(77, 114);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(389, 20);
            this.txtNomeProduto.TabIndex = 5;
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(9, 114);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(62, 20);
            this.txtQuantidadeProduto.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nome do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Quantidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "De:";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(9, 33);
            this.txtDataInicio.Mask = "00/00/0000";
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(68, 20);
            this.txtDataInicio.TabIndex = 2;
            this.txtDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(102, 33);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(68, 20);
            this.txtDataFinal.TabIndex = 3;
            this.txtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Até:";
            // 
            // btImprimirRelatorioProdutos
            // 
            this.btImprimirRelatorioProdutos.Location = new System.Drawing.Point(58, 77);
            this.btImprimirRelatorioProdutos.Name = "btImprimirRelatorioProdutos";
            this.btImprimirRelatorioProdutos.Size = new System.Drawing.Size(75, 23);
            this.btImprimirRelatorioProdutos.TabIndex = 4;
            this.btImprimirRelatorioProdutos.Text = "Imprimir";
            this.btImprimirRelatorioProdutos.UseVisualStyleBackColor = true;
            this.btImprimirRelatorioProdutos.Click += new System.EventHandler(this.btImprimirRelatorioProdutos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btImprimirRelatorioProdutos);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDataFinal);
            this.groupBox2.Controls.Add(this.txtDataInicio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório";
            // 
            // btVoltarProduto
            // 
            this.btVoltarProduto.Location = new System.Drawing.Point(70, 358);
            this.btVoltarProduto.Name = "btVoltarProduto";
            this.btVoltarProduto.Size = new System.Drawing.Size(75, 23);
            this.btVoltarProduto.TabIndex = 3;
            this.btVoltarProduto.Text = "Voltar";
            this.btVoltarProduto.UseVisualStyleBackColor = true;
            this.btVoltarProduto.Click += new System.EventHandler(this.btVoltarProduto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 173);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ternakan.Properties.Resources.fundo_do_programa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btVoltarProduto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProduto";
            this.Text = "Controle de Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.Shown += new System.EventHandler(this.frmProduto_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduto_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdicionarLista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorProdutoUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDataCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btImprimirRelatorioProdutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btVoltarProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}