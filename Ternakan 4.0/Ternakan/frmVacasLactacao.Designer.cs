namespace Ternakan
{
    partial class frmVacasLactacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacasLactacao));
            this.tcVacasLactacao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbVacasLactacao = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbNomegadoLactacao = new System.Windows.Forms.ComboBox();
            this.btAdicionarVacaLactacao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRemover = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.dgVacasLactacao = new System.Windows.Forms.DataGridView();
            this.valido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tcVacasLactacao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbVacasLactacao.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacasLactacao)).BeginInit();
            this.SuspendLayout();
            // 
            // tcVacasLactacao
            // 
            this.tcVacasLactacao.Controls.Add(this.tabPage1);
            this.tcVacasLactacao.Controls.Add(this.tabPage2);
            this.tcVacasLactacao.Location = new System.Drawing.Point(13, 13);
            this.tcVacasLactacao.Margin = new System.Windows.Forms.Padding(4);
            this.tcVacasLactacao.Name = "tcVacasLactacao";
            this.tcVacasLactacao.SelectedIndex = 0;
            this.tcVacasLactacao.Size = new System.Drawing.Size(445, 205);
            this.tcVacasLactacao.TabIndex = 0;
            this.tcVacasLactacao.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcVacasLactacao_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbVacasLactacao);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(437, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbVacasLactacao
            // 
            this.gbVacasLactacao.Controls.Add(this.label3);
            this.gbVacasLactacao.Controls.Add(this.comboBox1);
            this.gbVacasLactacao.Controls.Add(this.cbNomegadoLactacao);
            this.gbVacasLactacao.Controls.Add(this.btAdicionarVacaLactacao);
            this.gbVacasLactacao.Controls.Add(this.label2);
            this.gbVacasLactacao.Controls.Add(this.label1);
            this.gbVacasLactacao.Location = new System.Drawing.Point(7, 7);
            this.gbVacasLactacao.Name = "gbVacasLactacao";
            this.gbVacasLactacao.Size = new System.Drawing.Size(420, 154);
            this.gbVacasLactacao.TabIndex = 2;
            this.gbVacasLactacao.TabStop = false;
            this.gbVacasLactacao.Text = "Adicionar Vaca na Lactação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adicionar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // cbNomegadoLactacao
            // 
            this.cbNomegadoLactacao.FormattingEnabled = true;
            this.cbNomegadoLactacao.Location = new System.Drawing.Point(81, 39);
            this.cbNomegadoLactacao.Name = "cbNomegadoLactacao";
            this.cbNomegadoLactacao.Size = new System.Drawing.Size(330, 24);
            this.cbNomegadoLactacao.TabIndex = 2;
            // 
            // btAdicionarVacaLactacao
            // 
            this.btAdicionarVacaLactacao.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionarVacaLactacao.Image")));
            this.btAdicionarVacaLactacao.Location = new System.Drawing.Point(179, 69);
            this.btAdicionarVacaLactacao.Name = "btAdicionarVacaLactacao";
            this.btAdicionarVacaLactacao.Size = new System.Drawing.Size(50, 50);
            this.btAdicionarVacaLactacao.TabIndex = 2;
            this.btAdicionarVacaLactacao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRemover);
            this.tabPage2.Controls.Add(this.btRemover);
            this.tabPage2.Controls.Add(this.dgVacasLactacao);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(437, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remover";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.Location = new System.Drawing.Point(176, 318);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(71, 16);
            this.lblRemover.TabIndex = 38;
            this.lblRemover.Text = "Remover";
            // 
            // btRemover
            // 
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.Location = new System.Drawing.Point(186, 265);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(50, 50);
            this.btRemover.TabIndex = 37;
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // dgVacasLactacao
            // 
            this.dgVacasLactacao.AllowUserToAddRows = false;
            this.dgVacasLactacao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgVacasLactacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVacasLactacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valido});
            this.dgVacasLactacao.Location = new System.Drawing.Point(7, 7);
            this.dgVacasLactacao.Name = "dgVacasLactacao";
            this.dgVacasLactacao.Size = new System.Drawing.Size(423, 252);
            this.dgVacasLactacao.TabIndex = 36;
            // 
            // valido
            // 
            this.valido.HeaderText = "";
            this.valido.Name = "valido";
            this.valido.Width = 20;
            // 
            // frmVacasLactacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 231);
            this.Controls.Add(this.tcVacasLactacao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(486, 269);
            this.MinimumSize = new System.Drawing.Size(486, 269);
            this.Name = "frmVacasLactacao";
            this.Text = "Vacas em Lactação";
            this.Shown += new System.EventHandler(this.frmVacasLactacao_Shown);
            this.tcVacasLactacao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbVacasLactacao.ResumeLayout(false);
            this.gbVacasLactacao.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacasLactacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcVacasLactacao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbVacasLactacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbNomegadoLactacao;
        private System.Windows.Forms.Button btAdicionarVacaLactacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridView dgVacasLactacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valido;
    }
}