namespace Ternakan
{
    partial class frmVisualizarHistorico
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pctHist = new System.Windows.Forms.PictureBox();
            this.lbObs = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctHist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(68, 216);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(51, 16);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "OBS:";
            // 
            // pctHist
            // 
            this.pctHist.Location = new System.Drawing.Point(12, 1);
            this.pctHist.Name = "pctHist";
            this.pctHist.Size = new System.Drawing.Size(289, 212);
            this.pctHist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHist.TabIndex = 4;
            this.pctHist.TabStop = false;
            this.pctHist.Click += new System.EventHandler(this.pctHist_Click);
            // 
            // lbObs
            // 
            this.lbObs.Enabled = false;
            this.lbObs.Location = new System.Drawing.Point(58, 240);
            this.lbObs.Name = "lbObs";
            this.lbObs.Size = new System.Drawing.Size(243, 96);
            this.lbObs.TabIndex = 5;
            this.lbObs.Text = "";
            // 
            // frmVisualizarHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 356);
            this.Controls.Add(this.lbObs);
            this.Controls.Add(this.pctHist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(329, 394);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 394);
            this.Name = "frmVisualizarHistorico";
            this.Text = "Visualização do Historico";
            this.Shown += new System.EventHandler(this.frmVisualizarHistorico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pctHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctHist;
        private System.Windows.Forms.RichTextBox lbObs;
    }
}