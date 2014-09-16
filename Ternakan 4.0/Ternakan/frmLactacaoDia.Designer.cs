namespace Ternakan
{
    partial class frmLactacaoDia
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
            this.cbVaca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTirada = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbVaca
            // 
            this.cbVaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVaca.FormattingEnabled = true;
            this.cbVaca.Location = new System.Drawing.Point(47, 25);
            this.cbVaca.Name = "cbVaca";
            this.cbVaca.Size = new System.Drawing.Size(299, 21);
            this.cbVaca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(47, 58);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 1;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produção:";
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(215, 58);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(53, 20);
            this.txtProducao.TabIndex = 2;
            this.txtProducao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducao_KeyPress);
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(145, 103);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 4;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tirada:";
            // 
            // cbTirada
            // 
            this.cbTirada.FormattingEnabled = true;
            this.cbTirada.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbTirada.Location = new System.Drawing.Point(317, 58);
            this.cbTirada.Name = "cbTirada";
            this.cbTirada.Size = new System.Drawing.Size(37, 21);
            this.cbTirada.TabIndex = 3;
            // 
            // frmLactacaoDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(361, 138);
            this.Controls.Add(this.cbTirada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVaca);
            this.Name = "frmLactacaoDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lactação do dia";
            this.Shown += new System.EventHandler(this.frmLactacaoDia_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTirada;
    }
}