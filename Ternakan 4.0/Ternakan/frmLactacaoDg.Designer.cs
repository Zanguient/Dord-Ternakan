namespace Ternakan
{
    partial class frmLactacaoDg
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
            this.dgLactacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgLactacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLactacao
            // 
            this.dgLactacao.AllowUserToAddRows = false;
            this.dgLactacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLactacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLactacao.Location = new System.Drawing.Point(0, 0);
            this.dgLactacao.Name = "dgLactacao";
            this.dgLactacao.ReadOnly = true;
            this.dgLactacao.Size = new System.Drawing.Size(611, 367);
            this.dgLactacao.TabIndex = 0;
            this.dgLactacao.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgLactacao_UserDeletingRow);
            // 
            // frmLactacaoDg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 367);
            this.Controls.Add(this.dgLactacao);
            this.Name = "frmLactacaoDg";
            this.Text = "Lactação";
            this.Shown += new System.EventHandler(this.frmLactacaoDg_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgLactacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLactacao;
    }
}