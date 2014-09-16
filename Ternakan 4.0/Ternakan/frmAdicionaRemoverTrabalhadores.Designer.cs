namespace Ternakan
{
    partial class adicionaRemoverTrabalhadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adicionaRemoverTrabalhadores));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeTrabalhador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatadeNascimentoTrabalhador = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCadastrarTrabalhador = new System.Windows.Forms.Button();
            this.btRemoverTrabalhador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCartTrab = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataContrato = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgListaTrabalhadores = new System.Windows.Forms.DataGridView();
            this.btImprimirDespesastrabalhador = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtFim = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btVoltarAdicionarRemoverTrabalhador = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTrabalhadores)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome:";
            // 
            // txtNomeTrabalhador
            // 
            this.txtNomeTrabalhador.Location = new System.Drawing.Point(3, 40);
            this.txtNomeTrabalhador.Name = "txtNomeTrabalhador";
            this.txtNomeTrabalhador.Size = new System.Drawing.Size(357, 20);
            this.txtNomeTrabalhador.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Data de Nascimento:";
            // 
            // txtDatadeNascimentoTrabalhador
            // 
            this.txtDatadeNascimentoTrabalhador.Location = new System.Drawing.Point(70, 99);
            this.txtDatadeNascimentoTrabalhador.Mask = "00/00/0000";
            this.txtDatadeNascimentoTrabalhador.Name = "txtDatadeNascimentoTrabalhador";
            this.txtDatadeNascimentoTrabalhador.Size = new System.Drawing.Size(104, 20);
            this.txtDatadeNascimentoTrabalhador.TabIndex = 4;
            this.txtDatadeNascimentoTrabalhador.ValidatingType = typeof(System.DateTime);
            this.txtDatadeNascimentoTrabalhador.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDatadeNascimentoTrabalhador_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(315, 99);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "R$:";
            // 
            // btCadastrarTrabalhador
            // 
            this.btCadastrarTrabalhador.Location = new System.Drawing.Point(3, 99);
            this.btCadastrarTrabalhador.Name = "btCadastrarTrabalhador";
            this.btCadastrarTrabalhador.Size = new System.Drawing.Size(61, 27);
            this.btCadastrarTrabalhador.TabIndex = 9;
            this.btCadastrarTrabalhador.Text = "Cadastrar";
            this.btCadastrarTrabalhador.UseVisualStyleBackColor = true;
            this.btCadastrarTrabalhador.Click += new System.EventHandler(this.btCadastrarTrabalhador_Click);
            // 
            // btRemoverTrabalhador
            // 
            this.btRemoverTrabalhador.Location = new System.Drawing.Point(6, 255);
            this.btRemoverTrabalhador.Name = "btRemoverTrabalhador";
            this.btRemoverTrabalhador.Size = new System.Drawing.Size(75, 26);
            this.btRemoverTrabalhador.TabIndex = 1;
            this.btRemoverTrabalhador.Text = "Remover";
            this.btRemoverTrabalhador.UseVisualStyleBackColor = true;
            this.btRemoverTrabalhador.Click += new System.EventHandler(this.btRemoverTrabalhador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCartTrab);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.txtRg);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDataContrato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btCadastrarTrabalhador);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSalario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDatadeNascimentoTrabalhador);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeTrabalhador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Trabalhadores";
            // 
            // txtCartTrab
            // 
            this.txtCartTrab.Location = new System.Drawing.Point(581, 79);
            this.txtCartTrab.Name = "txtCartTrab";
            this.txtCartTrab.Size = new System.Drawing.Size(169, 20);
            this.txtCartTrab.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Carteira de Trabalho:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(423, 79);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(152, 40);
            this.txtObs.TabIndex = 7;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(562, 40);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(192, 20);
            this.txtCpf.TabIndex = 3;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(366, 40);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(178, 20);
            this.txtRg.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "CPF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "RG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Obs:";
            // 
            // txtDataContrato
            // 
            this.txtDataContrato.Location = new System.Drawing.Point(183, 99);
            this.txtDataContrato.Mask = "00/00/0000";
            this.txtDataContrato.Name = "txtDataContrato";
            this.txtDataContrato.Size = new System.Drawing.Size(100, 20);
            this.txtDataContrato.TabIndex = 5;
            this.txtDataContrato.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Data de Contrato:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btAlterar);
            this.groupBox2.Controls.Add(this.dgListaTrabalhadores);
            this.groupBox2.Controls.Add(this.btRemoverTrabalhador);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 286);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remover Trabalhadores";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(439, 254);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 26);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dgListaTrabalhadores
            // 
            this.dgListaTrabalhadores.AllowUserToAddRows = false;
            this.dgListaTrabalhadores.AllowUserToDeleteRows = false;
            this.dgListaTrabalhadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaTrabalhadores.Location = new System.Drawing.Point(6, 18);
            this.dgListaTrabalhadores.MultiSelect = false;
            this.dgListaTrabalhadores.Name = "dgListaTrabalhadores";
            this.dgListaTrabalhadores.ReadOnly = true;
            this.dgListaTrabalhadores.Size = new System.Drawing.Size(508, 231);
            this.dgListaTrabalhadores.TabIndex = 8;
            this.dgListaTrabalhadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaTrabalhadores_CellContentClick);
            // 
            // btImprimirDespesastrabalhador
            // 
            this.btImprimirDespesastrabalhador.BackColor = System.Drawing.Color.White;
            this.btImprimirDespesastrabalhador.Location = new System.Drawing.Point(26, 79);
            this.btImprimirDespesastrabalhador.Name = "btImprimirDespesastrabalhador";
            this.btImprimirDespesastrabalhador.Size = new System.Drawing.Size(194, 23);
            this.btImprimirDespesastrabalhador.TabIndex = 3;
            this.btImprimirDespesastrabalhador.Text = "Imprimir Lista de Trabalhadores";
            this.btImprimirDespesastrabalhador.UseVisualStyleBackColor = false;
            this.btImprimirDespesastrabalhador.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtInicio);
            this.groupBox3.Controls.Add(this.txtFim);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btImprimirDespesastrabalhador);
            this.groupBox3.Location = new System.Drawing.Point(542, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relatório";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "De:";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(14, 35);
            this.txtInicio.Mask = "00/00/0000";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 1;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(120, 35);
            this.txtFim.Mask = "00/00/0000";
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(100, 20);
            this.txtFim.TabIndex = 2;
            this.txtFim.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Até:";
            // 
            // btVoltarAdicionarRemoverTrabalhador
            // 
            this.btVoltarAdicionarRemoverTrabalhador.BackColor = System.Drawing.SystemColors.Control;
            this.btVoltarAdicionarRemoverTrabalhador.Location = new System.Drawing.Point(12, 504);
            this.btVoltarAdicionarRemoverTrabalhador.Name = "btVoltarAdicionarRemoverTrabalhador";
            this.btVoltarAdicionarRemoverTrabalhador.Size = new System.Drawing.Size(75, 23);
            this.btVoltarAdicionarRemoverTrabalhador.TabIndex = 4;
            this.btVoltarAdicionarRemoverTrabalhador.Text = "Voltar";
            this.btVoltarAdicionarRemoverTrabalhador.UseVisualStyleBackColor = false;
            this.btVoltarAdicionarRemoverTrabalhador.Click += new System.EventHandler(this.btVoltarAdicionarRemoverTrabalhador_Click);
            // 
            // adicionaRemoverTrabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btVoltarAdicionarRemoverTrabalhador);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "adicionaRemoverTrabalhadores";
            this.Text = "frmt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adicionaRemoverTrabalhadores_FormClosed);
            this.Load += new System.EventHandler(this.adicionaRemoverTrabalhadores_Load);
            this.Shown += new System.EventHandler(this.adicionaRemoverTrabalhadores_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTrabalhadores)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeTrabalhador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDatadeNascimentoTrabalhador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCadastrarTrabalhador;
        private System.Windows.Forms.Button btRemoverTrabalhador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btImprimirDespesastrabalhador;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btVoltarAdicionarRemoverTrabalhador;
        private System.Windows.Forms.DataGridView dgListaTrabalhadores;
        private System.Windows.Forms.MaskedTextBox txtDataContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.MaskedTextBox txtFim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCartTrab;
        private System.Windows.Forms.Label label11;
    }
}