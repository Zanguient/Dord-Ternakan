namespace Ternakan
{
    partial class frmSemensCadastrados
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
            this.dgvSemens = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSemens
            // 
            this.dgvSemens.AllowUserToAddRows = false;
            this.dgvSemens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSemens.Location = new System.Drawing.Point(0, 0);
            this.dgvSemens.Name = "dgvSemens";
            this.dgvSemens.Size = new System.Drawing.Size(685, 396);
            this.dgvSemens.TabIndex = 0;
            this.dgvSemens.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dgvSemens.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvSemens_RowsRemoved);
            this.dgvSemens.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSemens_RowValidated);
            this.dgvSemens.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvSemens_UserDeletingRow);
            // 
            // frmSemensCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 396);
            this.Controls.Add(this.dgvSemens);
            this.Name = "frmSemensCadastrados";
            this.Text = "Semens Cadastrados";
            this.Shown += new System.EventHandler(this.frmSemensCadastrados_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSemens;
    }
}