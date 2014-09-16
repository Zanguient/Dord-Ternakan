namespace Ternakan
{
    partial class frmVerHistorico
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
            this.dgVerHistorico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVerHistorico
            // 
            this.dgVerHistorico.AllowUserToAddRows = false;
            this.dgVerHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVerHistorico.Location = new System.Drawing.Point(0, -1);
            this.dgVerHistorico.Name = "dgVerHistorico";
            this.dgVerHistorico.ReadOnly = true;
            this.dgVerHistorico.Size = new System.Drawing.Size(703, 396);
            this.dgVerHistorico.TabIndex = 0;
            this.dgVerHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVerHistorico_CellContentClick);
            this.dgVerHistorico.Click += new System.EventHandler(this.dgVerHistorico_Click);
            // 
            // frmVerHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 407);
            this.Controls.Add(this.dgVerHistorico);
            this.Name = "frmVerHistorico";
            this.Text = "Relatorio";
            this.Shown += new System.EventHandler(this.frmVerHistorico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgVerHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVerHistorico;
    }
}