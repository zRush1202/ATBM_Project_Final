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

            // Tạo OracleCommand
            OracleCommand command = new OracleCommand(query, con);

            // Tạo OracleDataAdapter để điền dữ liệu vào DataTable
            OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            dgvNotifi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Điền dữ liệu vào DataTable
            dataAdapter.Fill(dataTable);

            // Thiết lập DataSource của DataGridView thành DataTable
            dgvNotifi.DataSource = dataTable;
        }
    }
}
