namespace Ternakan
{
    partial class frmSelecionarFazenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionarFazenda));
            this.cbListaFazendasCadastradas = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirma = new System.Windows.Forms.Button();
            this.btConfirmarFazenda = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btConfirmarFazenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbListaFazendasCadastradas
            // 
            this.cbListaFazendasCadastradas.DisplayMember = "ID";
            this.cbListaFazendasCadastradas.FormattingEnabled = true;
            this.cbListaFazendasCadastradas.Location = new System.Drawing.Point(6, 19);
            this.cbListaFazendasCadastradas.Name = "cbListaFazendasCadastradas";
            this.cbListaFazendasCadastradas.Size = new System.Drawing.Size(289, 24);
            this.cbListaFazendasCadastradas.TabIndex = 1;
            this.cbListaFazendasCadastradas.ValueMember = "ID";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 69);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(289, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 116);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(289, 22);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // btConfirma
            // 
            this.btConfirma.BackColor = System.Drawing.Color.White;
            this.btConfirma.Image = ((System.Drawing.Image)(resources.GetObject("btConfirma.Image")));
            this.btConfirma.Location = new System.Drawing.Point(59, 144);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(50, 50);
            this.btConfirma.TabIndex = 6;
            this.btConfirma.UseVisualStyleBackColor = false;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // btConfirmarFazenda
            // 
            this.btConfirmarFazenda.Controls.Add(this.label4);
            this.btConfirmarFazenda.Controls.Add(this.label3);
            this.btConfirmarFazenda.Controls.Add(this.button1);
            this.btConfirmarFazenda.Controls.Add(this.btConfirma);
            this.btConfirmarFazenda.Controls.Add(this.label2);
            this.btConfirmarFazenda.Controls.Add(this.label1);
            this.btConfirmarFazenda.Controls.Add(this.txtSenha);
            this.btConfirmarFazenda.Controls.Add(this.txtUsuario);
            this.btConfirmarFazenda.Controls.Add(this.cbListaFazendasCadastradas);
            this.btConfirmarFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarFazenda.Location = new System.Drawing.Point(12, 12);
            this.btConfirmarFazenda.Name = "btConfirmarFazenda";
            this.btConfirmarFazenda.Size = new System.Drawing.Size(306, 228);
            this.btConfirmarFazenda.TabIndex = 1;
            this.btConfirmarFazenda.TabStop = false;
            this.btConfirmarFazenda.Text = "Selecione a Fazenda";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(168, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Esqueci a senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar";
            // 
            // frmSelecionarFazenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(328, 248);
            this.Controls.Add(this.btConfirmarFazenda);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 286);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(344, 286);
            this.Name = "frmSelecionarFazenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelecionarFazenda_FormClosed);
            this.Shown += new System.EventHandler(this.frmSelecionarFazenda_Shown);
            this.btConfirmarFazenda.ResumeLayout(false);
            this.btConfirmarFazenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListaFazendasCadastradas;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.GroupBox btConfirmarFazenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}