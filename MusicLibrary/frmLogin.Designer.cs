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
            this.lblRegisterPrompt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.lblLoginCaption = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegisterPrompt
            // 
            this.lblRegisterPrompt.AutoSize = true;
            this.lblRegisterPrompt.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPrompt.ForeColor = System.Drawing.Color.Navy;
            this.lblRegisterPrompt.Location = new System.Drawing.Point(120, 264);
            this.lblRegisterPrompt.Name = "lblRegisterPrompt";
            this.lblRegisterPrompt.Size = new System.Drawing.Size(330, 20);
            this.lblRegisterPrompt.TabIndex = 17;
            this.lblRegisterPrompt.Text = "Don\'t have an account? Click here to register.";
            this.lblRegisterPrompt.Click += new System.EventHandler(this.lblRegisterPrompt_Click);
            this.lblRegisterPrompt.MouseEnter += new System.EventHandler(this.lblRegisterPrompt_MouseEnter);
            this.lblRegisterPrompt.MouseLeave += new System.EventHandler(this.lblRegisterPrompt_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(315, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 46);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Navy;
            this.btnLogin.Location = new System.Drawing.Point(140, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 46);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(220, 152);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(267, 22);
            this.txtLoginPassword.TabIndex = 14;
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(220, 107);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(267, 22);
            this.txtLoginUser.TabIndex = 13;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginPassword.Location = new System.Drawing.Point(90, 149);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(105, 23);
            this.lblLoginPassword.TabIndex = 12;
            this.lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUser.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginUser.Location = new System.Drawing.Point(90, 105);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(111, 23);
            this.lblLoginUser.TabIndex = 11;
            this.lblLoginUser.Text = "Username:";
            // 
            // lblLoginCaption
            // 
            this.lblLoginCaption.AutoSize = true;
            this.lblLoginCaption.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginCaption.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginCaption.Location = new System.Drawing.Point(160, 67);
            this.lblLoginCaption.Name = "lblLoginCaption";
            this.lblLoginCaption.Size = new System.Drawing.Size(265, 20);
            this.lblLoginCaption.TabIndex = 10;
            this.lblLoginCaption.Text = "Please enter your credentials below.";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginTitle.Location = new System.Drawing.Point(100, 30);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(383, 33);
            this.lblLoginTitle.TabIndex = 9;
            this.lblLoginTitle.Text = "Welcome to the Music Player";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.Navy;
            this.lblHint.Location = new System.Drawing.Point(121, 309);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(333, 17);
            this.lblHint.TabIndex = 18;
            this.lblHint.Text = "Hint: For easier testing, User=christolis, PW=gobirds";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(582, 328);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblRegisterPrompt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUser);
            this.Controls.Add(this.lblLoginCaption);
            this.Controls.Add(this.lblLoginTitle);
            this.Name = "frmLogin";
            this.Text = "Music Library - Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterPrompt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Label lblLoginCaption;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblHint;
    }
}

