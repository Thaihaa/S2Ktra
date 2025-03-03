namespace S2Ktra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textboxUserName.Text.Trim();  // Đọc giá trị từ textbox
            string password = textboxmatkhau.Text.Trim();

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển sang form khác (FormSuccess) sau khi đăng nhập thành công
                Login successForm = new Login();
                successForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
