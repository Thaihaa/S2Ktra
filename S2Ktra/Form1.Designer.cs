namespace S2Ktra
{
    partial class Form1
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassWord = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(110, 76);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(107, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(231, 81);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(110, 154);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(231, 151);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(333, 27);
            txtPassWord.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(234, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(txtPassWord);
            Controls.Add(lblPassword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassWord;

        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnLogin;
    }
}
