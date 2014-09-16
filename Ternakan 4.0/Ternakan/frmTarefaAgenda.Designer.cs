namespace Ternakan
{
    partial class frmTarefaAgenda
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
            this.lbDataAgenda = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btAdicionarAgenda = new System.Windows.Forms.Button();
            this.btSairTarefaAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDataAgenda
            // 
            this.lbDataAgenda.AutoSize = true;
            this.lbDataAgenda.Location = new System.Drawing.Point(12, 9);
            this.lbDataAgenda.Name = "lbDataAgenda";
            this.lbDataAgenda.Size = new System.Drawing.Size(30, 13);
            this.lbDataAgenda.TabIndex = 0;
            this.lbDataAgenda.Text = "Data";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 188);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btAdicionarAgenda
            // 
            this.btAdicionarAgenda.Location = new System.Drawing.Point(32, 220);
            this.btAdicionarAgenda.Name = "btAdicionarAgenda";
            this.btAdicionarAgenda.Size = new System.Drawing.Size(117, 23);
            this.btAdicionarAgenda.TabIndex = 2;
            this.btAdicionarAgenda.Text = "Adicionar na agenda";
            this.btAdicionarAgenda.UseVisualStyleBackColor = true;
            this.btAdicionarAgenda.Click += new System.EventHandler(this.btAdicionarAgenda_Click);
            // 
            // btSairTarefaAgenda
            // 
            this.btSairTarefaAgenda.Location = new System.Drawing.Point(167, 220);
            this.btSairTarefaAgenda.Name = "btSairTarefaAgenda";
            this.btSairTarefaAgenda.Size = new System.Drawing.Size(75, 23);
            this.btSairTarefaAgenda.TabIndex = 3;
            this.btSairTarefaAgenda.Text = "Sair";
            this.btSairTarefaAgenda.UseVisualStyleBackColor = true;
            this.btSairTarefaAgenda.Click += new System.EventHandler(this.btSairTarefaAgenda_Click);
            // 
            // frmTarefaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btSairTarefaAgenda);
            this.Controls.Add(this.btAdicionarAgenda);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbDataAgenda);
            this.Name = "frmTarefaAgenda";
            this.Text = "Tarefa da Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDataAgenda;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btAdicionarAgenda;
        private System.Windows.Forms.Button btSairTarefaAgenda;
    }
}