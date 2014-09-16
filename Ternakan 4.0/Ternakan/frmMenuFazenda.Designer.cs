namespace Ternakan
{
    partial class frmMenuFazenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuFazenda));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCadastrarFazenda = new System.Windows.Forms.Label();
            this.lblPiquetes = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.btCadastroFazenda = new System.Windows.Forms.Button();
            this.btPiquetes = new System.Windows.Forms.Button();
            this.btDespesas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDespesas = new System.Windows.Forms.GroupBox();
            this.btTrabalhadores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btProdutos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInformacao = new System.Windows.Forms.RichTextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDespesas.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(515, 302);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCadastrarFazenda);
            this.groupBox2.Controls.Add(this.lblPiquetes);
            this.groupBox2.Controls.Add(this.lblDespesas);
            this.groupBox2.Controls.Add(this.btCadastroFazenda);
            this.groupBox2.Controls.Add(this.btPiquetes);
            this.groupBox2.Controls.Add(this.btDespesas);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 288);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lblCadastrarFazenda
            // 
            this.lblCadastrarFazenda.AutoSize = true;
            this.lblCadastrarFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarFazenda.Location = new System.Drawing.Point(62, 133);
            this.lblCadastrarFazenda.Name = "lblCadastrarFazenda";
            this.lblCadastrarFazenda.Size = new System.Drawing.Size(76, 32);
            this.lblCadastrarFazenda.TabIndex = 3;
            this.lblCadastrarFazenda.Text = "Cadastrar\r\nFazenda";
            // 
            // lblPiquetes
            // 
            this.lblPiquetes.AutoSize = true;
            this.lblPiquetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiquetes.Location = new System.Drawing.Point(62, 84);
            this.lblPiquetes.Name = "lblPiquetes";
            this.lblPiquetes.Size = new System.Drawing.Size(69, 16);
            this.lblPiquetes.TabIndex = 3;
            this.lblPiquetes.Text = "Piquetes";
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesas.Location = new System.Drawing.Point(62, 28);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(79, 16);
            this.lblDespesas.TabIndex = 3;
            this.lblDespesas.Text = "Despesas";
            // 
            // btCadastroFazenda
            // 
            this.btCadastroFazenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadastroFazenda.BackgroundImage")));
            this.btCadastroFazenda.Location = new System.Drawing.Point(6, 123);
            this.btCadastroFazenda.Name = "btCadastroFazenda";
            this.btCadastroFazenda.Size = new System.Drawing.Size(50, 50);
            this.btCadastroFazenda.TabIndex = 3;
            this.btCadastroFazenda.UseVisualStyleBackColor = true;
            this.btCadastroFazenda.Click += new System.EventHandler(this.btCadastroFazenda_Click);
            this.btCadastroFazenda.MouseHover += new System.EventHandler(this.btCadastroFazenda_MouseHover);
            // 
            // btPiquetes
            // 
            this.btPiquetes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPiquetes.BackgroundImage")));
            this.btPiquetes.Location = new System.Drawing.Point(6, 67);
            this.btPiquetes.Name = "btPiquetes";
            this.btPiquetes.Size = new System.Drawing.Size(50, 50);
            this.btPiquetes.TabIndex = 3;
            this.btPiquetes.UseVisualStyleBackColor = true;
            this.btPiquetes.Click += new System.EventHandler(this.btPiquetes_Click);
            this.btPiquetes.MouseHover += new System.EventHandler(this.btPiquetes_MouseHover);
            // 
            // btDespesas
            // 
            this.btDespesas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDespesas.BackgroundImage")));
            this.btDespesas.Location = new System.Drawing.Point(6, 11);
            this.btDespesas.Name = "btDespesas";
            this.btDespesas.Size = new System.Drawing.Size(50, 50);
            this.btDespesas.TabIndex = 2;
            this.btDespesas.UseVisualStyleBackColor = true;
            this.btDespesas.Click += new System.EventHandler(this.btDespesas_Click);
            this.btDespesas.MouseHover += new System.EventHandler(this.btDespesas_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbDespesas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInformacao);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gbDespesas
            // 
            this.gbDespesas.Controls.Add(this.btTrabalhadores);
            this.gbDespesas.Controls.Add(this.label2);
            this.gbDespesas.Controls.Add(this.label1);
            this.gbDespesas.Controls.Add(this.btProdutos);
            this.gbDespesas.Location = new System.Drawing.Point(6, 9);
            this.gbDespesas.Name = "gbDespesas";
            this.gbDespesas.Size = new System.Drawing.Size(166, 135);
            this.gbDespesas.TabIndex = 3;
            this.gbDespesas.TabStop = false;
            this.gbDespesas.Visible = false;
            // 
            // btTrabalhadores
            // 
            this.btTrabalhadores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTrabalhadores.BackgroundImage")));
            this.btTrabalhadores.Location = new System.Drawing.Point(6, 20);
            this.btTrabalhadores.Name = "btTrabalhadores";
            this.btTrabalhadores.Size = new System.Drawing.Size(50, 50);
            this.btTrabalhadores.TabIndex = 1;
            this.btTrabalhadores.UseVisualStyleBackColor = true;
            this.btTrabalhadores.Click += new System.EventHandler(this.btTrabalhadores_Click);
            this.btTrabalhadores.MouseHover += new System.EventHandler(this.btTrabalhadores_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trabalhador";
            // 
            // btProdutos
            // 
            this.btProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btProdutos.BackgroundImage")));
            this.btProdutos.Location = new System.Drawing.Point(6, 76);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(50, 50);
            this.btProdutos.TabIndex = 2;
            this.btProdutos.UseVisualStyleBackColor = true;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            this.btProdutos.MouseHover += new System.EventHandler(this.btProdutos_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Informação:";
            // 
            // txtInformacao
            // 
            this.txtInformacao.Enabled = false;
            this.txtInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacao.ForeColor = System.Drawing.Color.Red;
            this.txtInformacao.Location = new System.Drawing.Point(6, 171);
            this.txtInformacao.Name = "txtInformacao";
            this.txtInformacao.Size = new System.Drawing.Size(314, 96);
            this.txtInformacao.TabIndex = 0;
            this.txtInformacao.Text = "";
            // 
            // frmMenuFazenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 302);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(531, 340);
            this.MinimumSize = new System.Drawing.Size(531, 340);
            this.Name = "frmMenuFazenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fazenda";
            this.Shown += new System.EventHandler(this.frmMenuFazenda_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDespesas.ResumeLayout(false);
            this.gbDespesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTrabalhadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtInformacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDespesas;
        private System.Windows.Forms.Button btPiquetes;
        private System.Windows.Forms.Button btCadastroFazenda;
        protected System.Windows.Forms.GroupBox gbDespesas;
        private System.Windows.Forms.Label lblCadastrarFazenda;
        private System.Windows.Forms.Label lblPiquetes;
        private System.Windows.Forms.Label lblDespesas;



    }
}