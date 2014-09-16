namespace Ternakan
{
    partial class frmSemens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSemens));
            this.tcBancoSemem = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCaneca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastrarSemen = new System.Windows.Forms.Button();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbListaSemem = new System.Windows.Forms.TabPage();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.gbAlterar = new System.Windows.Forms.GroupBox();
            this.txtQuantidadeAlterar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbColocar = new System.Windows.Forms.RadioButton();
            this.rbRetirar = new System.Windows.Forms.RadioButton();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgvSemens = new System.Windows.Forms.DataGridView();
            this.tcBancoSemem.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbListaSemem.SuspendLayout();
            this.gbAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemens)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBancoSemem
            // 
            this.tcBancoSemem.Controls.Add(this.tpCadastro);
            this.tcBancoSemem.Controls.Add(this.tbListaSemem);
            this.tcBancoSemem.Location = new System.Drawing.Point(18, 15);
            this.tcBancoSemem.Margin = new System.Windows.Forms.Padding(4);
            this.tcBancoSemem.Name = "tcBancoSemem";
            this.tcBancoSemem.SelectedIndex = 0;
            this.tcBancoSemem.Size = new System.Drawing.Size(524, 299);
            this.tcBancoSemem.TabIndex = 0;
            this.tcBancoSemem.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcBancoSemem_Selected);
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.groupBox1);
            this.tpCadastro.Location = new System.Drawing.Point(4, 25);
            this.tpCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.tpCadastro.Size = new System.Drawing.Size(516, 270);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCaneca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRegistro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btCadastrarSemen);
            this.groupBox1.Controls.Add(this.txtRaca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 247);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações sobre o Reprodutor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(6, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 16);
            this.label9.TabIndex = 121;
            this.label9.Text = "Os campos seguidos de * são obrigatórios.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Limpar";
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.White;
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.Location = new System.Drawing.Point(261, 126);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(50, 50);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastrar";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(394, 81);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(95, 22);
            this.txtQuantidade.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade*:";
            // 
            // txtCaneca
            // 
            this.txtCaneca.Location = new System.Drawing.Point(247, 81);
            this.txtCaneca.Name = "txtCaneca";
            this.txtCaneca.Size = new System.Drawing.Size(137, 22);
            this.txtCaneca.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Caneca*:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(287, 37);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(202, 22);
            this.txtRegistro.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registro:";
            // 
            // btCadastrarSemen
            // 
            this.btCadastrarSemen.BackColor = System.Drawing.Color.White;
            this.btCadastrarSemen.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrarSemen.Image")));
            this.btCadastrarSemen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btCadastrarSemen.Location = new System.Drawing.Point(180, 126);
            this.btCadastrarSemen.Name = "btCadastrarSemen";
            this.btCadastrarSemen.Size = new System.Drawing.Size(50, 50);
            this.btCadastrarSemen.TabIndex = 6;
            this.btCadastrarSemen.UseVisualStyleBackColor = false;
            this.btCadastrarSemen.Click += new System.EventHandler(this.btCadastrarSemen_Click);
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(9, 81);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(232, 22);
            this.txtRaca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raça*:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome*:";
            // 
            // tbListaSemem
            // 
            this.tbListaSemem.Controls.Add(this.lblAlterar);
            this.tbListaSemem.Controls.Add(this.gbAlterar);
            this.tbListaSemem.Controls.Add(this.btAlterar);
            this.tbListaSemem.Controls.Add(this.dgvSemens);
            this.tbListaSemem.Location = new System.Drawing.Point(4, 25);
            this.tbListaSemem.Margin = new System.Windows.Forms.Padding(4);
            this.tbListaSemem.Name = "tbListaSemem";
            this.tbListaSemem.Padding = new System.Windows.Forms.Padding(4);
            this.tbListaSemem.Size = new System.Drawing.Size(516, 405);
            this.tbListaSemem.TabIndex = 1;
            this.tbListaSemem.Text = "Lista de Sêmens";
            this.tbListaSemem.UseVisualStyleBackColor = true;
            // 
            // lblAlterar
            // 
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Location = new System.Drawing.Point(170, 362);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(54, 16);
            this.lblAlterar.TabIndex = 9;
            this.lblAlterar.Text = "Alterar";
            // 
            // gbAlterar
            // 
            this.gbAlterar.Controls.Add(this.txtQuantidadeAlterar);
            this.gbAlterar.Controls.Add(this.label7);
            this.gbAlterar.Controls.Add(this.rbColocar);
            this.gbAlterar.Controls.Add(this.rbRetirar);
            this.gbAlterar.Location = new System.Drawing.Point(325, 303);
            this.gbAlterar.Name = "gbAlterar";
            this.gbAlterar.Size = new System.Drawing.Size(188, 80);
            this.gbAlterar.TabIndex = 2;
            this.gbAlterar.TabStop = false;
            // 
            // txtQuantidadeAlterar
            // 
            this.txtQuantidadeAlterar.Location = new System.Drawing.Point(95, 42);
            this.txtQuantidadeAlterar.Name = "txtQuantidadeAlterar";
            this.txtQuantidadeAlterar.Size = new System.Drawing.Size(85, 22);
            this.txtQuantidadeAlterar.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Quantidade";
            // 
            // rbColocar
            // 
            this.rbColocar.AutoSize = true;
            this.rbColocar.Location = new System.Drawing.Point(6, 21);
            this.rbColocar.Name = "rbColocar";
            this.rbColocar.Size = new System.Drawing.Size(80, 20);
            this.rbColocar.TabIndex = 0;
            this.rbColocar.TabStop = true;
            this.rbColocar.Text = "Colocar";
            this.rbColocar.UseVisualStyleBackColor = true;
            // 
            // rbRetirar
            // 
            this.rbRetirar.AutoSize = true;
            this.rbRetirar.Location = new System.Drawing.Point(6, 47);
            this.rbRetirar.Name = "rbRetirar";
            this.rbRetirar.Size = new System.Drawing.Size(73, 20);
            this.rbRetirar.TabIndex = 0;
            this.rbRetirar.TabStop = true;
            this.rbRetirar.Text = "Retirar";
            this.rbRetirar.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.White;
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btAlterar.Location = new System.Drawing.Point(172, 309);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(50, 50);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dgvSemens
            // 
            this.dgvSemens.AllowUserToAddRows = false;
            this.dgvSemens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemens.Location = new System.Drawing.Point(7, 7);
            this.dgvSemens.Name = "dgvSemens";
            this.dgvSemens.Size = new System.Drawing.Size(500, 290);
            this.dgvSemens.TabIndex = 1;
            // 
            // frmSemens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 332);
            this.Controls.Add(this.tcBancoSemem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSemens";
            this.Text = "Banco de Sêmens";
            this.Shown += new System.EventHandler(this.frmSemens_Shown);
            this.tcBancoSemem.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbListaSemem.ResumeLayout(false);
            this.tbListaSemem.PerformLayout();
            this.gbAlterar.ResumeLayout(false);
            this.gbAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBancoSemem;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TabPage tbListaSemem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCaneca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCadastrarSemen;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSemens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.GroupBox gbAlterar;
        private System.Windows.Forms.TextBox txtQuantidadeAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbColocar;
        private System.Windows.Forms.RadioButton rbRetirar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}