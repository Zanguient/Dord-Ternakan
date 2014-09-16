namespace Ternakan
{
    partial class frmCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuarios));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btConfirmarFazenda = new System.Windows.Forms.GroupBox();
            this.txtConfirmacaoSenhaCadastro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRespostaDica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDicas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btConfirmarFazenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 78);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(289, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(289, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(126, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btConfirmarFazenda
            // 
            this.btConfirmarFazenda.Controls.Add(this.label6);
            this.btConfirmarFazenda.Controls.Add(this.txtConfirmacaoSenhaCadastro);
            this.btConfirmarFazenda.Controls.Add(this.label5);
            this.btConfirmarFazenda.Controls.Add(this.txtRespostaDica);
            this.btConfirmarFazenda.Controls.Add(this.label4);
            this.btConfirmarFazenda.Controls.Add(this.cbbDicas);
            this.btConfirmarFazenda.Controls.Add(this.label3);
            this.btConfirmarFazenda.Controls.Add(this.cbAdmin);
            this.btConfirmarFazenda.Controls.Add(this.label2);
            this.btConfirmarFazenda.Controls.Add(this.label1);
            this.btConfirmarFazenda.Controls.Add(this.txtSenha);
            this.btConfirmarFazenda.Controls.Add(this.txtUsuario);
            this.btConfirmarFazenda.Controls.Add(this.button1);
            this.btConfirmarFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarFazenda.Location = new System.Drawing.Point(12, 12);
            this.btConfirmarFazenda.MaximumSize = new System.Drawing.Size(303, 340);
            this.btConfirmarFazenda.MinimumSize = new System.Drawing.Size(303, 340);
            this.btConfirmarFazenda.Name = "btConfirmarFazenda";
            this.btConfirmarFazenda.Size = new System.Drawing.Size(303, 340);
            this.btConfirmarFazenda.TabIndex = 2;
            this.btConfirmarFazenda.TabStop = false;
            this.btConfirmarFazenda.Text = "Cadastro de Usuários";
            // 
            // txtConfirmacaoSenhaCadastro
            // 
            this.txtConfirmacaoSenhaCadastro.Location = new System.Drawing.Point(6, 118);
            this.txtConfirmacaoSenhaCadastro.Name = "txtConfirmacaoSenhaCadastro";
            this.txtConfirmacaoSenhaCadastro.PasswordChar = '*';
            this.txtConfirmacaoSenhaCadastro.Size = new System.Drawing.Size(289, 22);
            this.txtConfirmacaoSenhaCadastro.TabIndex = 3;
            this.txtConfirmacaoSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmação de Senha.";
            this.label5.UseWaitCursor = true;
            // 
            // txtRespostaDica
            // 
            this.txtRespostaDica.Location = new System.Drawing.Point(6, 198);
            this.txtRespostaDica.Name = "txtRespostaDica";
            this.txtRespostaDica.Size = new System.Drawing.Size(289, 22);
            this.txtRespostaDica.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resposta:";
            // 
            // cbbDicas
            // 
            this.cbbDicas.FormattingEnabled = true;
            this.cbbDicas.Items.AddRange(new object[] {
            "Nome da mãe.",
            "Nome do pai.",
            "Data de nascimento da mãe (sem \"/\").",
            "Data de nascimento do pai (sem \"/\").",
            "Programa preferido.",
            "Nome da primeira professora.",
            "Outros."});
            this.cbbDicas.Location = new System.Drawing.Point(6, 158);
            this.cbbDicas.Name = "cbbDicas";
            this.cbbDicas.Size = new System.Drawing.Size(289, 24);
            this.cbbDicas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dica para sua senha.";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(6, 221);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(123, 20);
            this.cbAdmin.TabIndex = 6;
            this.cbAdmin.Text = "Administrador";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cadastrar";
            // 
            // frmCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(324, 360);
            this.Controls.Add(this.btConfirmarFazenda);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 398);
            this.MinimumSize = new System.Drawing.Size(340, 398);
            this.Name = "frmCadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastroUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastroUsuarios_Load);
            this.Shown += new System.EventHandler(this.frmCadastroUsuarios_Shown);
            this.btConfirmarFazenda.ResumeLayout(false);
            this.btConfirmarFazenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox btConfirmarFazenda;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.TextBox txtRespostaDica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDicas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmacaoSenhaCadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}