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
    public partial class FormAudit : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public FormAudit()
        {
            InitializeComponent();
        }

        private void FormAudit_Load(object sender, EventArgs e)
        {
            string query = "select username, obj_name, action_name, TO_CHAR(extended_timestamp, 'DD/MM/YYYY HH24:MI:SS') as Time, sql_text from dba_audit_trail where owner = 'ADPRO' order by extended_timestamp desc";
            OracleCommand command = new OracleCommand(query, con);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            dgvStandardAudit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAdapter.Fill(dataTable);
            dgvStandardAudit.DataSource = dataTable;

            query = "select db_user, object_name, statement_type, sql_text, TO_CHAR(extended_timestamp, 'DD/MM/YYYY HH24:MI:SS') as Time from dba_fga_audit_trail where policy_name = 'FGA_POLICY_DIEM'";
            OracleCommand command2 = new OracleCommand(query, con);
            OracleDataAdapter dataAdapter2 = new OracleDataAdapter(command2);
            DataTable dataTable2 = new DataTable();
            dgvFGADangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAdapter2.Fill(dataTable2);
            dgvFGADangKy.DataSource = dataTable2;

            query = "select db_user, object_name, statement_type, sql_text, TO_CHAR(extended_timestamp, 'DD/MM/YYYY HH24:MI:SS') as Time from dba_fga_audit_trail where policy_name = 'FGA_POLICY_PHUCAP'";
            OracleCommand command3 = new OracleCommand(query, con);
            OracleDataAdapter dataAdapter3 = new OracleDataAdapter(command3);
            DataTable dataTable3 = new DataTable();
            dgvFGAPhuCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAdapter3.Fill(dataTable3);
            dgvFGAPhuCap.DataSource = dataTable3;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormAudit_Load(sender, e);
        }
    }
}
