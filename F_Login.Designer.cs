namespace wfDoutorAuauEMiau
{
    partial class F_Login
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
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lb_userInvalido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.Location = new System.Drawing.Point(31, 45);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(215, 27);
            this.tb_login.TabIndex = 0;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_login.Location = new System.Drawing.Point(27, 22);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(49, 20);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Login";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_senha.Location = new System.Drawing.Point(27, 75);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(54, 20);
            this.lb_senha.TabIndex = 3;
            this.lb_senha.Text = "Senha";
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(31, 98);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(215, 27);
            this.tb_senha.TabIndex = 2;
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_logar.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.ForeColor = System.Drawing.Color.White;
            this.btn_logar.Location = new System.Drawing.Point(31, 150);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(214, 32);
            this.btn_logar.TabIndex = 4;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(31, 188);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(215, 32);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // lb_userInvalido
            // 
            this.lb_userInvalido.AutoSize = true;
            this.lb_userInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userInvalido.ForeColor = System.Drawing.Color.Red;
            this.lb_userInvalido.Location = new System.Drawing.Point(41, 128);
            this.lb_userInvalido.Name = "lb_userInvalido";
            this.lb_userInvalido.Size = new System.Drawing.Size(0, 13);
            this.lb_userInvalido.TabIndex = 6;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 232);
            this.Controls.Add(this.lb_userInvalido);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.tb_login);
            this.MaximizeBox = false;
            this.Name = "F_Login";
            this.Text = "Login Dr. Auau & Miau";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Login_KeyDown);
            this.Leave += new System.EventHandler(this.F_Login_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lb_userInvalido;
    }
}