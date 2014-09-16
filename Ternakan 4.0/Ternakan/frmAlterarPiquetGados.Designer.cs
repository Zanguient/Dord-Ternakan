namespace Ternakan
{
    partial class frmAlterarPiquetGados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarPiquetGados));
            this.lblPiquet = new System.Windows.Forms.Label();
            this.cbPiquet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPiquet
            // 
            this.lblPiquet.AutoSize = true;
            this.lblPiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiquet.Location = new System.Drawing.Point(0, 0);
            this.lblPiquet.Name = "lblPiquet";
            this.lblPiquet.Size = new System.Drawing.Size(278, 16);
            this.lblPiquet.TabIndex = 0;
            this.lblPiquet.Text = "Voce vai alterar o piquet de 0 animiais.";
            // 
            // cbPiquet
            // 
            this.cbPiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPiquet.FormattingEnabled = true;
            this.cbPiquet.Location = new System.Drawing.Point(3, 44);
            this.cbPiquet.Name = "cbPiquet";
            this.cbPiquet.Size = new System.Drawing.Size(273, 24);
            this.cbPiquet.TabIndex = 60;
            this.cbPiquet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPiquet_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Novo piquet:";
            // 
            // btOK
            // 
            this.btOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOK.BackgroundImage")));
            this.btOK.Location = new System.Drawing.Point(312, 8);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(50, 50);
            this.btOK.TabIndex = 62;
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Confirmar";
            // 
            // frmAlterarPiquetGados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 82);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbPiquet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPiquet);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 120);
            this.MinimumSize = new System.Drawing.Size(389, 120);
            this.Name = "frmAlterarPiquetGados";
            this.Text = "Alterar o piquet";
            this.Shown += new System.EventHandler(this.frmAlterarPiquetGados_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPiquet;
        private System.Windows.Forms.ComboBox cbPiquet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label1;
    }
}