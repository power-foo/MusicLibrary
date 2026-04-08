namespace MusicLibrary
{
    partial class frmLogin
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
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblLoginCaption = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.lblRegisterPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginTitle.Location = new System.Drawing.Point(65, 18);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(383, 33);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Welcome to the Music Player";
            // 
            // lblLoginCaption
            // 
            this.lblLoginCaption.AutoSize = true;
            this.lblLoginCaption.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginCaption.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginCaption.Location = new System.Drawing.Point(139, 51);
            this.lblLoginCaption.Name = "lblLoginCaption";
            this.lblLoginCaption.Size = new System.Drawing.Size(219, 20);
            this.lblLoginCaption.TabIndex = 1;
            this.lblLoginCaption.Text = "Please enter your credentials.";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUser.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginUser.Location = new System.Drawing.Point(50, 100);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(111, 23);
            this.lblLoginUser.TabIndex = 2;
            this.lblLoginUser.Text = "Username:";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginPassword.Location = new System.Drawing.Point(50, 144);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(105, 23);
            this.lblLoginPassword.TabIndex = 3;
            this.lblLoginPassword.Text = "Password:";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(173, 103);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(283, 22);
            this.txtLoginUser.TabIndex = 4;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(173, 147);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(283, 22);
            this.txtLoginPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Navy;
            this.btnLogin.Location = new System.Drawing.Point(105, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 44);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExitLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitLogin.ForeColor = System.Drawing.Color.Navy;
            this.btnExitLogin.Location = new System.Drawing.Point(268, 199);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(112, 44);
            this.btnExitLogin.TabIndex = 7;
            this.btnExitLogin.Text = "Exit";
            this.btnExitLogin.UseVisualStyleBackColor = false;
            // 
            // lblRegisterPrompt
            // 
            this.lblRegisterPrompt.AutoSize = true;
            this.lblRegisterPrompt.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPrompt.ForeColor = System.Drawing.Color.Navy;
            this.lblRegisterPrompt.Location = new System.Drawing.Point(67, 268);
            this.lblRegisterPrompt.Name = "lblRegisterPrompt";
            this.lblRegisterPrompt.Size = new System.Drawing.Size(367, 20);
            this.lblRegisterPrompt.TabIndex = 8;
            this.lblRegisterPrompt.Text = "Don\'t have an account? Click here to register here.";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(518, 313);
            this.Controls.Add(this.lblRegisterPrompt);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUser);
            this.Controls.Add(this.lblLoginCaption);
            this.Controls.Add(this.lblLoginTitle);
            this.Name = "frmLogin";
            this.Text = "Music Library - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblLoginCaption;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.Label lblRegisterPrompt;
    }
}

