namespace Ternakan
{
    partial class fmrAlterarPiquet
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
            this.label1 = new System.Windows.Forms.Label();
            this.btAlterarPiquet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovoNumeroPiquet = new System.Windows.Forms.TextBox();
            this.txtNovoNomePiquet = new System.Windows.Forms.TextBox();
            this.dgPiquets = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiquets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgPiquets);
            this.groupBox1.Controls.Add(this.txtNovoNomePiquet);
            this.groupBox1.Controls.Add(this.txtNovoNumeroPiquet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btAlterarPiquet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alteração de Piquet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Piquet";
            // 
            // btAlterarPiquet
            // 
            this.btAlterarPiquet.Location = new System.Drawing.Point(4, 263);
            this.btAlterarPiquet.Name = "btAlterarPiquet";
            this.btAlterarPiquet.Size = new System.Drawing.Size(75, 23);
            this.btAlterarPiquet.TabIndex = 3;
            this.btAlterarPiquet.Text = "Alterar";
            this.btAlterarPiquet.UseVisualStyleBackColor = true;
            this.btAlterarPiquet.Click += new System.EventHandler(this.btAlterarPiquet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Novo Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Novo Número:";
            // 
            // txtNovoNumeroPiquet
            // 
            this.txtNovoNumeroPiquet.Location = new System.Drawing.Point(4, 227);
            this.txtNovoNumeroPiquet.Name = "txtNovoNumeroPiquet";
            this.txtNovoNumeroPiquet.Size = new System.Drawing.Size(71, 20);
            this.txtNovoNumeroPiquet.TabIndex = 1;
            // 
            // txtNovoNomePiquet
            // 
            this.txtNovoNomePiquet.Location = new System.Drawing.Point(87, 227);
            this.txtNovoNomePiquet.Name = "txtNovoNomePiquet";
            this.txtNovoNomePiquet.Size = new System.Drawing.Size(490, 20);
            this.txtNovoNomePiquet.TabIndex = 2;
            // 
            // dgPiquets
            // 
            this.dgPiquets.AllowUserToAddRows = false;
            this.dgPiquets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPiquets.Location = new System.Drawing.Point(16, 44);
            this.dgPiquets.MultiSelect = false;
            this.dgPiquets.Name = "dgPiquets";
            this.dgPiquets.ReadOnly = true;
            this.dgPiquets.Size = new System.Drawing.Size(561, 150);
            this.dgPiquets.TabIndex = 43;
            this.dgPiquets.SelectionChanged += new System.EventHandler(this.fmrAlterarPiquet_Activated);
            this.dgPiquets.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgPiquets_UserDeletingRow);
            // 
            // fmrAlterarPiquet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ternakan.Properties.Resources.fundo_do_programa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmrAlterarPiquet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Piquet";
            this.Activated += new System.EventHandler(this.fmrAlterarPiquet_Activated);
            this.Load += new System.EventHandler(this.fmrAlterarPiquet_Load);
            this.Shown += new System.EventHandler(this.fmrAlterarPiquet_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiquets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgPiquets;
        private System.Windows.Forms.TextBox txtNovoNomePiquet;
        private System.Windows.Forms.TextBox txtNovoNumeroPiquet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAlterarPiquet;
        private System.Windows.Forms.Label label1;
    }
}