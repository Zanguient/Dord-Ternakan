namespace Ternakan
{
    partial class frmEsqueceuSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEsqueceuSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNomeDica = new System.Windows.Forms.Label();
            this.txtRespostaDica = new System.Windows.Forms.TextBox();
            this.btVerSenha = new System.Windows.Forms.Button();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // lbNomeDica
            // 
            this.lbNomeDica.AutoSize = true;
            this.lbNomeDica.Location = new System.Drawing.Point(12, 58);
            this.lbNomeDica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeDica.Name = "lbNomeDica";
            this.lbNomeDica.Size = new System.Drawing.Size(44, 16);
            this.lbNomeDica.TabIndex = 1;
            this.lbNomeDica.Text = "Dica:";
            // 
            // txtRespostaDica
            // 
            this.txtRespostaDica.Location = new System.Drawing.Point(16, 78);
            this.txtRespostaDica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRespostaDica.Name = "txtRespostaDica";
            this.txtRespostaDica.Size = new System.Drawing.Size(396, 22);
            this.txtRespostaDica.TabIndex = 2;
            // 
            // btVerSenha
            // 
            this.btVerSenha.Image = ((System.Drawing.Image)(resources.GetObject("btVerSenha.Image")));
            this.btVerSenha.Location = new System.Drawing.Point(189, 110);
            this.btVerSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVerSenha.Name = "btVerSenha";
            this.btVerSenha.Size = new System.Drawing.Size(50, 50);
            this.btVerSenha.TabIndex = 3;
            this.btVerSenha.UseVisualStyleBackColor = true;
            this.btVerSenha.Click += new System.EventHandler(this.btVerSenha_Click);
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(16, 29);
            this.cbUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(396, 24);
            this.cbUsuarios.TabIndex = 1;
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);
            this.cbUsuarios.SelectionChangeCommitted += new System.EventHandler(this.cbUsuarios_SelectionChangeCommitted);
            this.cbUsuarios.SelectedValueChanged += new System.EventHandler(this.cbUsuarios_SelectedValueChanged);
            this.cbUsuarios.TextChanged += new System.EventHandler(this.cbUsuarios_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirma";
            // 
            // frmEsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.btVerSenha);
            this.Controls.Add(this.txtRespostaDica);
            this.Controls.Add(this.lbNomeDica);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 230);
            this.MinimumSize = new System.Drawing.Size(442, 230);
            this.Name = "frmEsqueceuSenha";
            this.Text = "Esqueceu Senha";
            this.Load += new System.EventHandler(this.frmEsqueceuSenha_Load);
            this.Shown += new System.EventHandler(this.frmEsqueceuSenha_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNomeDica;
        private System.Windows.Forms.TextBox txtRespostaDica;
        private System.Windows.Forms.Button btVerSenha;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label label2;
    }
}