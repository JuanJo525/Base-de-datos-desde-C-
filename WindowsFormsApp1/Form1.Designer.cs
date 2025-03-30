namespace WindowsFormsApp1
{
    partial class frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_usu = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_FRMregister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_usu
            // 
            this.lbl_usu.AutoSize = true;
            this.lbl_usu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usu.Location = new System.Drawing.Point(55, 80);
            this.lbl_usu.Name = "lbl_usu";
            this.lbl_usu.Size = new System.Drawing.Size(61, 16);
            this.lbl_usu.TabIndex = 0;
            this.lbl_usu.Text = "Usuario";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(30, 128);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(86, 16);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Contraseña";
            // 
            // txt_usu
            // 
            this.txt_usu.Location = new System.Drawing.Point(122, 80);
            this.txt_usu.MaxLength = 30;
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(211, 20);
            this.txt_usu.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(122, 124);
            this.txt_pass.MaxLength = 8;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(211, 20);
            this.txt_pass.TabIndex = 3;
            // 
            // btn_continuar
            // 
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.Location = new System.Drawing.Point(242, 212);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(107, 26);
            this.btn_continuar.TabIndex = 4;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(85, 212);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(107, 26);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancel";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(146, 22);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(138, 25);
            this.lbl_Login.TabIndex = 6;
            this.lbl_Login.Text = "Iniciar sesion";
            // 
            // lbl_FRMregister
            // 
            this.lbl_FRMregister.AutoSize = true;
            this.lbl_FRMregister.Location = new System.Drawing.Point(176, 170);
            this.lbl_FRMregister.Name = "lbl_FRMregister";
            this.lbl_FRMregister.Size = new System.Drawing.Size(91, 13);
            this.lbl_FRMregister.TabIndex = 7;
            this.lbl_FRMregister.TabStop = true;
            this.lbl_FRMregister.Text = "CREAR CUENTA";
            this.lbl_FRMregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_FRMregister_LinkClicked);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(421, 268);
            this.Controls.Add(this.lbl_FRMregister);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_usu);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usu;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.LinkLabel lbl_FRMregister;
        public System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.TextBox txt_pass;
    }
}

