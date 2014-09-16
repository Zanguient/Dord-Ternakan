namespace Ternakan
{
    partial class frmAdicionarVacaLactacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNomegadoLactacao = new System.Windows.Forms.ComboBox();
            this.btSairAdicionarVacaLactacao = new System.Windows.Forms.Button();
            this.btAdicionarVacaLactacao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNomegadoLactacao);
            this.groupBox1.Controls.Add(this.btSairAdicionarVacaLactacao);
            this.groupBox1.Controls.Add(this.btAdicionarVacaLactacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Vaca na Lactação";
            // 
            // cbNomegadoLactacao
            // 
            this.cbNomegadoLactacao.FormattingEnabled = true;
            this.cbNomegadoLactacao.Location = new System.Drawing.Point(9, 51);
            this.cbNomegadoLactacao.Name = "cbNomegadoLactacao";
            this.cbNomegadoLactacao.Size = new System.Drawing.Size(393, 21);
            this.cbNomegadoLactacao.TabIndex = 2;
            // 
            // btSairAdicionarVacaLactacao
            // 
            this.btSairAdicionarVacaLactacao.Location = new System.Drawing.Point(113, 78);
            this.btSairAdicionarVacaLactacao.Name = "btSairAdicionarVacaLactacao";
            this.btSairAdicionarVacaLactacao.Size = new System.Drawing.Size(75, 23);
            this.btSairAdicionarVacaLactacao.TabIndex = 3;
            this.btSairAdicionarVacaLactacao.Text = "Sair";
            this.btSairAdicionarVacaLactacao.UseVisualStyleBackColor = true;
            this.btSairAdicionarVacaLactacao.Click += new System.EventHandler(this.btSairAdicionarVacaLactacao_Click);
            // 
            // btAdicionarVacaLactacao
            // 
            this.btAdicionarVacaLactacao.Location = new System.Drawing.Point(9, 78);
            this.btAdicionarVacaLactacao.Name = "btAdicionarVacaLactacao";
            this.btAdicionarVacaLactacao.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarVacaLactacao.TabIndex = 2;
            this.btAdicionarVacaLactacao.Text = "Adicionar";
            this.btAdicionarVacaLactacao.UseVisualStyleBackColor = true;
            this.btAdicionarVacaLactacao.Click += new System.EventHandler(this.btAdicionarVacaLactacao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // frmAdicionarVacaLactacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 147);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdicionarVacaLactacao";
            this.Text = "Adicionar Vacas em Lactação";
            this.Shown += new System.EventHandler(this.frmAdicionarVacaLactacao_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdicionarVacaLactacao;
        private System.Windows.Forms.Button btSairAdicionarVacaLactacao;
        private System.Windows.Forms.ComboBox cbNomegadoLactacao;
    }
}