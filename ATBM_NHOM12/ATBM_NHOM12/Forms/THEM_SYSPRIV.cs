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
    public partial class THEM_SYSPRIV : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public THEM_SYSPRIV()
        {
            InitializeComponent();
        }
        private void THEM_SYSPRIV_Load(object sender, EventArgs e)
        {
            try
            {
                string selectTsql = "select * from session_privs order by PRIVILEGE ASC";
                OracleCommand comm = new OracleCommand(selectTsql,con);
                OracleDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cb_quyen.Items.Add(reader[0]);
                };
                reader.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btt_thuchien_Click(object sender, EventArgs e)
        {
            if (cb_quyen.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn quyền");
            }

            if (txt_doituong.Text.Length == 0)
            {
                MessageBox.Show("Chưa có thông tin đối tượng");
            }

            if (cb_thaotac.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn thao tác");
            }
            try
            {
                string sql = "";
                if (cb_thaotac.Text == "GRANT")
                {
                    sql = $"GRANT {cb_quyen.Text} TO {txt_doituong.Text} {checkwgo.Text}";
                    MessageBox.Show(sql);
                }
                if (cb_thaotac.Text == "REVOKE")
                {
                    sql = $"REVOKE {cb_quyen.Text} FROM {txt_doituong.Text}";
                }
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thực hiện thao tác " + cb_thaotac.Text + " thành công");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkwgo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_thaotac.Text == "REVOKE")
            {
                checkwgo.Enabled = false;
            }    
            else if(cb_thaotac.Text == "GRANT")
            {
                checkwgo.Enabled = true;
            }    
        }
    }
}
