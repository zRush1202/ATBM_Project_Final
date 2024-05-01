using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_NHOM12.Forms
{
    public partial class FormNotification : Form
    {
        private string username;
        public static OracleConnection con = LoginProvider.conn;
        public FormNotification()
        {
            InitializeComponent();
        }
        public FormNotification(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FormNotification_Load(object sender, EventArgs e)
        {
            string query = "select* from ADPRO.THONGBAO";
            OracleCommand command = new OracleCommand(query, con);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            dgvNotifi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAdapter.Fill(dataTable);
            dgvNotifi.DataSource = dataTable;
        }

        private void btnAddNotify_Click(object sender, EventArgs e)
        {
            FormAddNoti addNoti = new FormAddNoti();
            addNoti.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormNotification_Load(sender, e);
        }
    }
}
