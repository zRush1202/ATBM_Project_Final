using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_NHOM12
{
    public partial class LoginUI : Form
    {
        public event EventHandler ButtonClicked;
        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0)
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP không được để trống.");
                return;
            }
            if (password.Text.Length == 0)
            {
                MessageBox.Show("MẬT KHẨU không được để trống.");
                return;
            }
            if (role.Text.Length == 0)
            {
                MessageBox.Show("VAI TRÒ không được để trống.");
                return;
            }

            LoginProvider loginProvider = new LoginProvider();
            bool isValidLogin = loginProvider.CheckLogin(username.Text, password.Text, role.Text);
            if (isValidLogin)
            {
                //FormMainMenu fmm = new FormMainMenu();
                //this.Hide();
                //fmm.ShowDialog();
                //this.Close();
                ButtonClicked?.Invoke(this, new RoleEventArgs(loginProvider.userRole, loginProvider.username));
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin đăng nhập");
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }
}
