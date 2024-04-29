using ATBM_NHOM12.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM_NHOM12
{
    public partial class FormMainMenu : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public string username = "";
        public string role = "";
        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            //btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(82, 109, 130);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        //private void btnCloseChildForm_Click(object sender, EventArgs e)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    Reset();
        //}
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(82, 109, 130);
            panelLogo.BackColor = Color.FromArgb(39, 55, 77);
            currentButton = null;
            CenterLabelInPanel(lblTitle, panelTitleBar);
            //btnCloseChildForm.Visible = false;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            button1.Visible = false; 
            button2.Visible = false;
            btnLogout.Visible = false;
            btnGrantPriv.Visible = false;
            btnDangKy.Visible = false;
            btnDonVi.Visible = false;
            btnHocPhan.Visible = false;
            btnKHMo.Visible = false;
            btnNhanSu.Visible = false;
            btnSinhVien.Visible = false;
            btnPhanCong.Visible = false;
            btnTTCNNS.Visible = false;
            btnTTCNSV.Visible = false;
            btnNhatKy.Visible = false;
            ptbxNotify.Image = Properties.Resources.png_clipart_school_district_computer_icons_education_school_angle_text;
            ptbxNotify.Enabled = false;
            panelLogo.Enabled = false;
            ActivateButton(btnLogin);
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            CenterLabelInPanel(lblTitle, panelTitleBar);
            LoginUI loginUI = new LoginUI();
            loginUI.ButtonClicked += ChildForm_ButtonClicked;
            loginUI.TopLevel = false;
            loginUI.FormBorderStyle= FormBorderStyle.None;
            loginUI.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(loginUI);
            loginUI.Show();
        }

        private void ChildForm_ButtonClicked(object sender, EventArgs e)
        {
            ptbxNotify.Image = Properties.Resources.notification_bell_5743;
            ptbxNotify.Enabled = true;
            panelLogo.Enabled = true;
            if (e is RoleEventArgs roleEventArgs)
            {
                role = roleEventArgs.Role.Trim();
                username = roleEventArgs.username.Trim();
            }
            if (role == "SYSDBA" || role == "ADMIN")
            {
                panelDesktopPane.Controls.Clear();
                // Hiển thị lại MainForm
                lblTitle.Text = "HOME";
                CenterLabelInPanel(lblTitle, panelTitleBar);
                button1.Visible = true;
                button2.Visible = true;
                btnLogout.Visible = true;
                btnLogin.Visible = false;
                btnGrantPriv.Visible = true;
                btnDangKy.Visible = false;
                btnDonVi.Visible = false;
                btnHocPhan.Visible = false;
                btnKHMo.Visible = false;
                btnNhanSu.Visible = false;
                btnPhanCong.Visible = false;
                btnSinhVien.Visible = false;
                btnTTCNNS.Visible = false;
                btnTTCNSV.Visible = false;
                btnNhatKy.Visible = true;
                Home home = new Home();
                home.TopLevel = false;
                home.FormBorderStyle = FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(home);
                home.Show();
            }
            if (role == "RL_NVCOBAN")
            {
                panelDesktopPane.Controls.Clear();
                // Hiển thị lại MainForm
                lblTitle.Text = "HOME";
                CenterLabelInPanel(lblTitle, panelTitleBar);
                btnLogin.Visible = false;
                btnTTCNNS.Visible = true;
                btnSinhVien.Visible=true;
                btnDonVi.Visible=true;
                btnHocPhan.Visible=true;
                btnKHMo.Visible=true;
                btnLogout.Visible = true;
                Home home = new Home();
                home.TopLevel = false;
                home.FormBorderStyle = FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(home);
                home.Show();
            }
            if (role == "RL_GIANGVIEN")
            {
                panelDesktopPane.Controls.Clear();
                // Hiển thị lại MainForm
                lblTitle.Text = "HOME";
                CenterLabelInPanel(lblTitle, panelTitleBar);
                btnLogin.Visible = false;
                btnTTCNNS.Visible = true;
                btnSinhVien.Visible = true;
                btnDonVi.Visible = true;
                btnHocPhan.Visible = true;
                btnKHMo.Visible = true;
                btnLogout.Visible = true;
                btnPhanCong.Visible = true;
                btnDangKy.Visible = true;
                Home home = new Home();
                home.TopLevel = false;
                home.FormBorderStyle = FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(home);
                home.Show();
            }
            if (role == "RL_GIAOVU")
            {
                panelDesktopPane.Controls.Clear();
                // Hiển thị lại MainForm
                lblTitle.Text = "HOME";
                CenterLabelInPanel(lblTitle, panelTitleBar);
                btnLogin.Visible = false;
                btnTTCNNS.Visible = true;
                btnSinhVien.Visible = true;
                btnDonVi.Visible = true;
                btnHocPhan.Visible = true;
                btnKHMo.Visible = true;
                btnLogout.Visible = true;
                btnSinhVien.Visible= true;
                btnDonVi.Visible= true;
                btnHocPhan.Visible= true;
                btnKHMo.Visible = true;
                btnPhanCong.Visible= true;
                Home home = new Home();
                home.TopLevel = false;
                home.FormBorderStyle = FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(home);
                home.Show();
            }
            if (role == "RL_TRUONGDV")
            {
                panelDesktopPane.Controls.Clear();
                // Hiển thị lại MainForm
                lblTitle.Text = "HOME";
                CenterLabelInPanel(lblTitle, panelTitleBar);
                btnLogin.Visible = false;
                btnTTCNNS.Visible = true;
                btnSinhVien.Visible = true;
                btnDonVi.Visible = true;
                btnHocPhan.Visible = true;
                btnKHMo.Visible = true;
                btnLogout.Visible = true;
                btnPhanCong.Visible = true;
                btnDangKy.Visible = true;
                Home home = new Home();
                home.TopLevel = false;
                home.FormBorderStyle = FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(home);
                home.Show();
            }
            if (role == "RL_TRUONGKHOA")
            {
                panelDesktopPane.Controls.Clear();
                // Hiển thị lại MainForm
                lblTitle.Text = "HOME";
                CenterLabelInPanel(lblTitle, panelTitleBar);
                btnLogin.Visible = false;
                btnTTCNNS.Visible = true;
                btnSinhVien.Visible = true;
                btnDonVi.Visible = true;
                btnHocPhan.Visible = true;
                btnKHMo.Visible = true;
                btnLogout.Visible = true;
                btnPhanCong.Visible = true;
                btnDangKy.Visible = true;
                btnNhanSu.Visible = true;
                Home home = new Home();
                home.TopLevel = false;
                home.FormBorderStyle = FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(home);
                home.Show();
            }
            if (role == "RL_SINHVIEN")
            {
                panelDesktopPane.Controls.Clear();
                // Hiển thị lại MainForm
                lblTitle.Text = "HOME";
                CenterLabelInPanel(lblTitle, panelTitleBar);
                btnLogin.Visible = false;
                btnTTCNSV.Visible = true;
                btnHocPhan.Visible = true;
                btnKHMo.Visible = true;
                btnDangKy.Visible = true;
                btnLogout.Visible = true;
                Home home = new Home();
                home.TopLevel = false;
                home.FormBorderStyle = FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(home);
                home.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User_and_Role(), sender);
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Privilege(), sender);
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Grant_Revoke_Privilege(), sender);
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(btnLogin);
            con.Close();
            panelDesktopPane.Controls.Clear();
            button1.Visible = false;
            button2.Visible = false;
            btnLogout.Visible = false;
            btnGrantPriv.Visible = false;
            btnLogin.Visible = true;
            btnDonVi.Visible = false;
            btnHocPhan.Visible = false;
            btnTTCNNS.Visible = false;
            btnTTCNSV.Visible = false;
            btnSinhVien.Visible = false;
            btnNhanSu.Visible = false;
            btnKHMo.Visible = false;
            btnDangKy.Visible = false;
            btnPhanCong.Visible = false;
            btnNhatKy.Visible = false;
            ptbxNotify.Image = Properties.Resources.png_clipart_school_district_computer_icons_education_school_angle_text;
            ptbxNotify.Enabled = false;
            panelLogo.Enabled = false;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            CenterLabelInPanel(lblTitle, panelTitleBar);
            LoginUI loginUI = new LoginUI();
            loginUI.ButtonClicked += ChildForm_ButtonClicked;
            loginUI.TopLevel = false;
            loginUI.FormBorderStyle = FormBorderStyle.None;
            loginUI.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(loginUI);
            loginUI.Show();

        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void CenterLabelInPanel(System.Windows.Forms.Label lblTitle, Panel panelTitleBar)
        {
            int centerX = (panelTitleBar.Width - lblTitle.Width) / 2;
            int centerY = (panelTitleBar.Height - lblTitle.Height) / 2;
            lblTitle.Location = new Point(centerX, centerY);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoginUI(), sender);
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_DSSINHVIEN_TABLE(), sender);
            lblTitle.Text = "QUẢN LÝ SINH VIÊN";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_NHANSU_TABLE(), sender); ;
            lblTitle.Text = "QUẢN LÝ NHÂN SỰ";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnKHMo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KHMO_TABLE(role, username), sender);
            lblTitle.Text = "KẾ HOẠCH MỞ MÔN";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnTTCNNS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TTCANHAN_NHANSU(), sender);
            lblTitle.Text = "THÔNG TIN CÁ NHÂN";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnTTCNSV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TTCN_SINHVIEN(), sender);
            lblTitle.Text = "THÔNG TIN CÁ NHÂN";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnDonVi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DONVI_TABLE(role,username), sender);
            lblTitle.Text = "QUẢN LÝ ĐƠN VỊ";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnHocPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HOCPHAN_TABLE(role, username), sender);
            lblTitle.Text = "QUẢN LÝ HỌC PHẦN";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PHANCONG_TABLE(role, username), sender);
            lblTitle.Text = "QUẢN LÝ PHÂN CÔNG";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void OpenNotification(Form childForm, object btnSender)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ptbxNotify_Click(object sender, EventArgs e)
        {
            OpenNotification(new FormNotification(this.username), sender);
            lblTitle.Text = "THÔNG BÁO";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }

        private void btnNhatKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAudit(), sender);
            lblTitle.Text = "NHẬT KÝ";
            CenterLabelInPanel(lblTitle, panelTitleBar);
        }
    }
}
