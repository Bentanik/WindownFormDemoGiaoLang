namespace BookManagement_HoangNgocTrinh
{
    partial class LoginForm
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
            txtEmail = new TextBox();
            txtPass = new TextBox();
            lblLogin = new Label();
            btnQuit = new Button();
            btnLogin = new Button();
            textEmail = new Label();
            txtPassword = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(235, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(234, 194);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(222, 27);
            txtPass.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Red;
            lblLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Yellow;
            lblLogin.Location = new Point(235, 66);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(125, 31);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login Info";
            lblLogin.Click += lblDescription_Click;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(460, 275);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(200, 42);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Yellow;
            btnLogin.Location = new Point(241, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textEmail
            // 
            textEmail.AutoSize = true;
            textEmail.BackColor = Color.Red;
            textEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textEmail.ForeColor = Color.Yellow;
            textEmail.Location = new Point(90, 133);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(73, 31);
            textEmail.TabIndex = 6;
            textEmail.Text = "Email";
            textEmail.Click += lblBookName_Click;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.Red;
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Yellow;
            txtPassword.Location = new Point(89, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(114, 31);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1342, 676);
            Controls.Add(txtPassword);
            Controls.Add(textEmail);
            Controls.Add(btnQuit);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Controls.Add(txtPass);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private Label lblLogin;
        private TextBox txtPass;
        private Button btnQuit;
        private Button btnLogin;
        private Label textEmail;
        private Label txtPassword;
    }
}