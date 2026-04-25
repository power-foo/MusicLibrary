namespace MusicLibrary
{
    partial class frmRegister
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterUser = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterUser = new System.Windows.Forms.Label();
            this.lblRegisterCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Navy;
            this.btnClose.Location = new System.Drawing.Point(289, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 46);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Navy;
            this.btnRegister.Location = new System.Drawing.Point(114, 167);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 46);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(198, 113);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(267, 22);
            this.txtRegisterPassword.TabIndex = 21;
            // 
            // txtRegisterUser
            // 
            this.txtRegisterUser.Location = new System.Drawing.Point(198, 68);
            this.txtRegisterUser.Name = "txtRegisterUser";
            this.txtRegisterUser.Size = new System.Drawing.Size(267, 22);
            this.txtRegisterUser.TabIndex = 20;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblRegisterPassword.Location = new System.Drawing.Point(68, 110);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(105, 23);
            this.lblRegisterPassword.TabIndex = 19;
            this.lblRegisterPassword.Text = "Password:";
            // 
            // lblRegisterUser
            // 
            this.lblRegisterUser.AutoSize = true;
            this.lblRegisterUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUser.ForeColor = System.Drawing.Color.Navy;
            this.lblRegisterUser.Location = new System.Drawing.Point(68, 66);
            this.lblRegisterUser.Name = "lblRegisterUser";
            this.lblRegisterUser.Size = new System.Drawing.Size(111, 23);
            this.lblRegisterUser.TabIndex = 18;
            this.lblRegisterUser.Text = "Username:";
            // 
            // lblRegisterCaption
            // 
            this.lblRegisterCaption.AutoSize = true;
            this.lblRegisterCaption.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterCaption.ForeColor = System.Drawing.Color.Navy;
            this.lblRegisterCaption.Location = new System.Drawing.Point(68, 27);
            this.lblRegisterCaption.Name = "lblRegisterCaption";
            this.lblRegisterCaption.Size = new System.Drawing.Size(393, 20);
            this.lblRegisterCaption.TabIndex = 17;
            this.lblRegisterCaption.Text = "Please enter your new Username and Password below.";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(532, 253);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterUser);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterUser);
            this.Controls.Add(this.lblRegisterCaption);
            this.Name = "frmRegister";
            this.Text = "Music Library - Register a New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUser;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUser;
        private System.Windows.Forms.Label lblRegisterCaption;
    }
}