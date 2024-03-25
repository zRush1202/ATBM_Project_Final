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
    public partial class Revoke_Privilege : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public Revoke_Privilege()
        {
            InitializeComponent();
        }
        private bool check_lbur = false;
        private void txt_ur_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null)
            {
                string input = textBox.Text;
                if (input.Contains(" ") || !System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-zA-Z0-9_#]*$"))
                {
                    MessageBox.Show("Dữ liệu nhập không được chứa ký tự đặc biệt");
                    //textBox.Text = System.Text.RegularExpressions.Regex.Replace(input, @"[^a-zA-Z0-9_#]", "");
                    check_lbur = false;
                }
                else
                {
                    check_lbur = true;
                }
            }
        }
        private void cb_table_Load(object sender, EventArgs e)
        {
            using (OracleCommand cmd = new OracleCommand("SELECT table_name FROM user_tables where TABLE_NAME LIKE 'BH_%' OR TABLE_NAME LIKE 'UV_BH_%'", con))
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cb_table.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void btt_rev_Click(object sender, EventArgs e)
        {
            OracleCommand schema_n = con.CreateCommand();
            schema_n.CommandText = "select owner from dba_tables where table_name = \'" + cb_table.Text.ToString() + '\'';
            OracleDataReader reader = schema_n.ExecuteReader();
            reader.Read();
            string schema_name = reader.GetString(0);
            using (OracleCommand cmd = new OracleCommand())
            {
                cmd.Connection = con; // Assuming conNow is your OracleConnection object
                cmd.CommandText = "REVOKE " + cb_priv.Text.ToString() + " ON " + schema_name + "." + cb_table.Text.ToString() + " FROM " + txt_ur.Text.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã thu hồi quyền");
        }

        private void btt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
