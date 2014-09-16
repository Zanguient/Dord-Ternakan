namespace Ternakan
{
    partial class frmMudarSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAlterarSenha = new System.Windows.Forms.Button();
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha Antiga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirme Sua Nova Senha:";
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.Location = new System.Drawing.Point(73, 149);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(75, 23);
            this.btAlterarSenha.TabIndex = 7;
            this.btAlterarSenha.Text = "Alterar";
            this.btAlterarSenha.UseVisualStyleBackColor = true;
            this.btAlterarSenha.Click += new System.EventHandler(this.btAlterarSenha_Click);
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Location = new System.Drawing.Point(15, 25);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.Size = new System.Drawing.Size(206, 20);
            this.txtSenhaAntiga.TabIndex = 4;
            this.txtSenhaAntiga.UseSystemPasswordChar = true;
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(15, 75);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(206, 20);
            this.txtSenhaNova.TabIndex = 5;
            this.txtSenhaNova.UseSystemPasswordChar = true;
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(15, 123);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(206, 20);
            this.txtConfirmacaoSenha.TabIndex = 6;
            this.txtConfirmacaoSenha.UseSystemPasswordChar = true;
            // 
            // frmMudarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 207);
            this.Controls.Add(this.txtConfirmacaoSenha);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.txtSenhaAntiga);
            this.Controls.Add(this.btAlterarSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMudarSenha";
            this.Text = "Mudar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAlterarSenha;
        private System.Windows.Forms.TextBox txtSenhaAntiga;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
    }
}