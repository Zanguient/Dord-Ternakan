namespace Ternakan
{
    partial class frmMenuReproducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuReproducao));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.txtInformacao = new System.Windows.Forms.RichTextBox();
            this.btSemens = new System.Windows.Forms.Button();
            this.brPrevisaoNascimento = new System.Windows.Forms.Button();
            this.btCruzamento = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(743, 221);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btSemens);
            this.groupBox1.Controls.Add(this.brPrevisaoNascimento);
            this.groupBox1.Controls.Add(this.btCruzamento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Banco de Sêmens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Previsão de Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cruzamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInformacoes);
            this.groupBox2.Controls.Add(this.txtInformacao);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 193);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.ForeColor = System.Drawing.Color.Red;
            this.lblInformacoes.Location = new System.Drawing.Point(6, 19);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(97, 16);
            this.lblInformacoes.TabIndex = 5;
            this.lblInformacoes.Text = "Informações:";
            // 
            // txtInformacao
            // 
            this.txtInformacao.BackColor = System.Drawing.Color.White;
            this.txtInformacao.Enabled = false;
            this.txtInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacao.ForeColor = System.Drawing.Color.Red;
            this.txtInformacao.Location = new System.Drawing.Point(6, 38);
            this.txtInformacao.Name = "txtInformacao";
            this.txtInformacao.Size = new System.Drawing.Size(423, 96);
            this.txtInformacao.TabIndex = 4;
            this.txtInformacao.Text = "";
            // 
            // btSemens
            // 
            this.btSemens.Image = ((System.Drawing.Image)(resources.GetObject("btSemens.Image")));
            this.btSemens.Location = new System.Drawing.Point(6, 131);
            this.btSemens.Name = "btSemens";
            this.btSemens.Size = new System.Drawing.Size(50, 50);
            this.btSemens.TabIndex = 0;
            this.btSemens.UseVisualStyleBackColor = true;
            this.btSemens.Click += new System.EventHandler(this.btSemens_Click);
            this.btSemens.MouseHover += new System.EventHandler(this.btSemens_MouseHover);
            // 
            // brPrevisaoNascimento
            // 
            this.brPrevisaoNascimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brPrevisaoNascimento.BackgroundImage")));
            this.brPrevisaoNascimento.Image = ((System.Drawing.Image)(resources.GetObject("brPrevisaoNascimento.Image")));
            this.brPrevisaoNascimento.Location = new System.Drawing.Point(6, 75);
            this.brPrevisaoNascimento.Name = "brPrevisaoNascimento";
            this.brPrevisaoNascimento.Size = new System.Drawing.Size(50, 50);
            this.brPrevisaoNascimento.TabIndex = 0;
            this.brPrevisaoNascimento.UseVisualStyleBackColor = true;
            this.brPrevisaoNascimento.Click += new System.EventHandler(this.brPrevisaoNascimento_Click);
            this.brPrevisaoNascimento.MouseHover += new System.EventHandler(this.brPrevisaoNascimento_MouseHover);
            // 
            // btCruzamento
            // 
            this.btCruzamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCruzamento.BackgroundImage")));
            this.btCruzamento.Location = new System.Drawing.Point(6, 19);
            this.btCruzamento.Name = "btCruzamento";
            this.btCruzamento.Size = new System.Drawing.Size(50, 50);
            this.btCruzamento.TabIndex = 0;
            this.btCruzamento.UseVisualStyleBackColor = true;
            this.btCruzamento.Click += new System.EventHandler(this.btCruzamento_Click);
            this.btCruzamento.MouseHover += new System.EventHandler(this.btCruzamento_MouseHover);
            // 
            // frmMenuReproducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 221);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(759, 259);
            this.MinimumSize = new System.Drawing.Size(759, 259);
            this.Name = "frmMenuReproducao";
            this.Text = "Reprodução";
            this.Shown += new System.EventHandler(this.frmMenuReproducao_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSemens;
        private System.Windows.Forms.Button brPrevisaoNascimento;
        private System.Windows.Forms.Button btCruzamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.RichTextBox txtInformacao;
    }
}