namespace Ternakan
{
    partial class frmMenuUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuUsuario));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btListarUsuarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTrocarUsuario = new System.Windows.Forms.Button();
            this.btTrocarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCadastrarUsuario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInformacao = new System.Windows.Forms.RichTextBox();
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
            this.splitContainer1.Size = new System.Drawing.Size(630, 282);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btListarUsuarios);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btTrocarUsuario);
            this.groupBox1.Controls.Add(this.btTrocarSenha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btCadastrarUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btListarUsuarios
            // 
            this.btListarUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btListarUsuarios.BackgroundImage")));
            this.btListarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarUsuarios.Location = new System.Drawing.Point(6, 131);
            this.btListarUsuarios.Name = "btListarUsuarios";
            this.btListarUsuarios.Size = new System.Drawing.Size(50, 50);
            this.btListarUsuarios.TabIndex = 3;
            this.btListarUsuarios.UseVisualStyleBackColor = true;
            this.btListarUsuarios.Click += new System.EventHandler(this.btListarUsuarios_Click);
            this.btListarUsuarios.MouseHover += new System.EventHandler(this.btListarUsuarios_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Trocar de Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Alterar Senha";
            // 
            // btTrocarUsuario
            // 
            this.btTrocarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTrocarUsuario.BackgroundImage")));
            this.btTrocarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrocarUsuario.Location = new System.Drawing.Point(6, 188);
            this.btTrocarUsuario.Name = "btTrocarUsuario";
            this.btTrocarUsuario.Size = new System.Drawing.Size(50, 50);
            this.btTrocarUsuario.TabIndex = 4;
            this.btTrocarUsuario.UseVisualStyleBackColor = true;
            this.btTrocarUsuario.Click += new System.EventHandler(this.btTrocarUsuario_Click);
            this.btTrocarUsuario.MouseHover += new System.EventHandler(this.btTrocarUsuario_MouseHover);
            // 
            // btTrocarSenha
            // 
            this.btTrocarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTrocarSenha.BackgroundImage")));
            this.btTrocarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrocarSenha.Location = new System.Drawing.Point(6, 75);
            this.btTrocarSenha.Name = "btTrocarSenha";
            this.btTrocarSenha.Size = new System.Drawing.Size(50, 50);
            this.btTrocarSenha.TabIndex = 2;
            this.btTrocarSenha.UseVisualStyleBackColor = true;
            this.btTrocarSenha.Click += new System.EventHandler(this.btTrocarSenha_Click);
            this.btTrocarSenha.MouseHover += new System.EventHandler(this.btTrocarSenha_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Listar Usuários";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Cadastrar novo Usuário";
            // 
            // btCadastrarUsuario
            // 
            this.btCadastrarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadastrarUsuario.BackgroundImage")));
            this.btCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarUsuario.Location = new System.Drawing.Point(6, 19);
            this.btCadastrarUsuario.Name = "btCadastrarUsuario";
            this.btCadastrarUsuario.Size = new System.Drawing.Size(50, 50);
            this.btCadastrarUsuario.TabIndex = 1;
            this.btCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btCadastrarUsuario.Click += new System.EventHandler(this.btCadastrarUsuario_Click);
            this.btCadastrarUsuario.MouseHover += new System.EventHandler(this.btCadastrarUsuario_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtInformacao);
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informação:";
            // 
            // txtInformacao
            // 
            this.txtInformacao.Enabled = false;
            this.txtInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacao.ForeColor = System.Drawing.Color.Red;
            this.txtInformacao.Location = new System.Drawing.Point(9, 34);
            this.txtInformacao.Name = "txtInformacao";
            this.txtInformacao.Size = new System.Drawing.Size(314, 96);
            this.txtInformacao.TabIndex = 2;
            this.txtInformacao.Text = "";
            // 
            // frmMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 282);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(646, 320);
            this.MinimumSize = new System.Drawing.Size(646, 320);
            this.Name = "frmMenuUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Shown += new System.EventHandler(this.frmMenuUsuario_Shown);
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
        private System.Windows.Forms.Button btCadastrarUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btListarUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTrocarUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTrocarSenha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtInformacao;
    }
}