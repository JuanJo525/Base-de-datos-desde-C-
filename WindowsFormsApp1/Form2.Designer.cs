namespace WindowsFormsApp1
{
    partial class frm_Saludo
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
            this.lbl_bien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bien
            // 
            this.lbl_bien.AutoSize = true;
            this.lbl_bien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bien.Location = new System.Drawing.Point(33, 105);
            this.lbl_bien.Name = "lbl_bien";
            this.lbl_bien.Size = new System.Drawing.Size(85, 29);
            this.lbl_bien.TabIndex = 0;
            this.lbl_bien.Text = "label1";
            this.lbl_bien.Click += new System.EventHandler(this.lbl_bienvenido_Click);
            // 
            // frm_Saludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(460, 246);
            this.Controls.Add(this.lbl_bien);
            this.Name = "frm_Saludo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_bien;
    }
}