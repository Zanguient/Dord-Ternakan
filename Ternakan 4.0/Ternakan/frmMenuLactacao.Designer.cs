namespace Ternakan
{
    partial class frmMenuLactacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuLactacao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLactacaoDiaria = new System.Windows.Forms.Button();
            this.btVacaLactacao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.txtInformacao = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btLactacaoDiaria);
            this.groupBox1.Controls.Add(this.btVacaLactacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lactação Diária";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vacas em lactação";
            // 
            // btLactacaoDiaria
            // 
            this.btLactacaoDiaria.Image = ((System.Drawing.Image)(resources.GetObject("btLactacaoDiaria.Image")));
            this.btLactacaoDiaria.Location = new System.Drawing.Point(16, 77);
            this.btLactacaoDiaria.Name = "btLactacaoDiaria";
            this.btLactacaoDiaria.Size = new System.Drawing.Size(50, 50);
            this.btLactacaoDiaria.TabIndex = 3;
            this.btLactacaoDiaria.UseVisualStyleBackColor = true;
            this.btLactacaoDiaria.Click += new System.EventHandler(this.btLactacaoDiaria_Click);
            this.btLactacaoDiaria.MouseHover += new System.EventHandler(this.btLactacaoDiaria_MouseHover);
            // 
            // btVacaLactacao
            // 
            this.btVacaLactacao.Image = ((System.Drawing.Image)(resources.GetObject("btVacaLactacao.Image")));
            this.btVacaLactacao.Location = new System.Drawing.Point(16, 21);
            this.btVacaLactacao.Name = "btVacaLactacao";
            this.btVacaLactacao.Size = new System.Drawing.Size(50, 50);
            this.btVacaLactacao.TabIndex = 0;
            this.btVacaLactacao.UseVisualStyleBackColor = true;
            this.btVacaLactacao.Click += new System.EventHandler(this.btVacaLactacao_Click);
            this.btVacaLactacao.MouseHover += new System.EventHandler(this.btVacaLactacao_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInformacoes);
            this.groupBox2.Controls.Add(this.txtInformacao);
            this.groupBox2.Location = new System.Drawing.Point(235, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.ForeColor = System.Drawing.Color.Red;
            this.lblInformacoes.Location = new System.Drawing.Point(3, 16);
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
            this.txtInformacao.Location = new System.Drawing.Point(6, 35);
            this.txtInformacao.Name = "txtInformacao";
            this.txtInformacao.Size = new System.Drawing.Size(218, 96);
            this.txtInformacao.TabIndex = 4;
            this.txtInformacao.Text = "";
            // 
            // frmMenuLactacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 165);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 203);
            this.MinimumSize = new System.Drawing.Size(499, 203);
            this.Name = "frmMenuLactacao";
            this.Text = "Controle Leiteiro";
            this.Shown += new System.EventHandler(this.frmMenuLactacao_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btLactacaoDiaria;
        private System.Windows.Forms.Button btVacaLactacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.RichTextBox txtInformacao;
    }
}