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
            lblMatKhau = new Label();
            txtmatkhau = new TextBox();
            SuspendLayout();
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(163, 151);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(73, 20);
            lblMatKhau.TabIndex = 0;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(258, 151);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(333, 27);
            txtmatkhau.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtmatkhau);
            Controls.Add(lblMatKhau);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatKhau;
        private TextBox txtmatkhau;
    }
}
