namespace ClassExample
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnLogin = new Button();
            LblUser = new Label();
            LblPassword = new Label();
            TxtUser = new TextBox();
            TxtPassword = new TextBox();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(346, 323);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(200, 73);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LblUser
            // 
            LblUser.AutoSize = true;
            LblUser.Location = new Point(40, 39);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(38, 20);
            LblUser.TabIndex = 1;
            LblUser.Text = "User";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(40, 86);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(70, 20);
            LblPassword.TabIndex = 2;
            LblPassword.Text = "Password";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(157, 32);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(172, 27);
            TxtUser.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(157, 83);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(172, 27);
            TxtPassword.TabIndex = 4;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUser);
            Controls.Add(LblPassword);
            Controls.Add(LblUser);
            Controls.Add(BtnLogin);
            Name = "LoginView";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private Label LblUser;
        private Label LblPassword;
        private TextBox TxtUser;
        private TextBox TxtPassword;
    }
}
