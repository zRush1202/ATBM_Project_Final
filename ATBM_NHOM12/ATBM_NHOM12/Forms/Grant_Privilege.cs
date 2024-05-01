using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM_NHOM12.Forms
{
    public partial class Grant_Privilege : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public Grant_Privilege()
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
                    btt_check.Enabled = false;
                }
                else
                {
                    check_lbur = true;
                    btt_check.Enabled = true;
                }
            }
        }

        private void btt_check_Click(object sender, EventArgs e)
        {
            string userOrRoleName = txt_ur.Text; // Thay thế bằng tên người dùng hoặc vai trò bạn muốn kiểm tra

            using (OracleCommand cmd = new OracleCommand("ADPRO.check_user_or_role", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                // Thêm tham số đầu vào
                cmd.Parameters.Add("p_name", OracleDbType.Char).Value = userOrRoleName;
                // Thêm tham số đầu ra
                OracleParameter outParam = new OracleParameter("p_result", OracleDbType.Varchar2, 255, null, ParameterDirection.Output);
                cmd.Parameters.Add(outParam);
                try
                {
                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();
                    // Lấy giá trị trả về từ tham số đầu ra
                    txt_check.Text = outParam.Value.ToString();
                    if (txt_check.Text == "User")
                    {
                        rd_option.Enabled = true;
                    }
                    else { rd_option.Enabled = false; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void cb_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Xóa tất cả các mục hiện tại trong ComboBox column
                clb_col.Items.Clear();

                // Tạo truy vấn SQL để lấy tất cả các cột của bảng được chọn
                string query = "SELECT COLUMN_NAME FROM dba_tab_columns WHERE table_name = '" + cb_table.SelectedItem.ToString() + "'";

                // Thực hiện truy vấn và lấy kết quả
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Thêm tất cả các cột vào ComboBox column
                foreach (DataRow row in dataTable.Rows)
                {
                    clb_col.Items.Add(row["COLUMN_NAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cb_table_Load(object sender, EventArgs e)
        {
            using (OracleCommand cmd = new OracleCommand("SELECT view_name AS object_name FROM all_views WHERE owner = 'ADPRO' UNION ALL SELECT table_name AS object_name FROM all_tables WHERE owner = 'ADPRO'", con))
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

        private void btt_grant_Click(object sender, EventArgs e)
        {
            if (txt_ur.Text.Length == 0)
            {
                MessageBox.Show("Nhập đầy đủ username/role");
                return;
            }
            if (txt_check.Text.Length == 0)
            {
                MessageBox.Show("Nhấn vào nút phân loại để phân loại đối tượng");
                return;
            }
            if (cb_priv.Text.Length == 0)
            {
                MessageBox.Show("Chọn quyền muốn cấp");
                return;
            }
            if (cb_table.Text.Length == 0)
            {
                MessageBox.Show("Chọn bảng muốn phân quyền");
                return;
            }
            try
            {
                // Lấy tên người dùng hoặc vai trò từ txt_ur
                string userOrRoleName = txt_ur.Text.ToString();

                // Lấy tên bảng từ cb_table
                string tableName = cb_table.SelectedItem.ToString();

                string col_list = "";
                // lấy tên cột
                for (int i = 0; i < clb_col.Items.Count; i++)
                {
                    if (clb_col.GetItemChecked(i) == true)
                    {
                        col_list += clb_col.Items[i].ToString() + ",";
                    }
                }
                if (col_list.Length > 0)
                {
                    // Xóa dấu "," cuối chuỗi
                    col_list = col_list.Substring(0, col_list.Length - 1);
                }

                string option = "";
                if (rd_option.Checked == true)
                {
                    option = "WITH GRANT OPTION";
                }
                else option = "";


                OracleCommand schema_n = con.CreateCommand();
                schema_n.CommandText = "SELECT OWNER FROM ALL_OBJECTS WHERE OBJECT_TYPE IN ('TABLE', 'VIEW') and object_name = \'" + cb_table.Text.ToString() + '\'';
                OracleDataReader reader = schema_n.ExecuteReader();
                reader.Read();
                string schema_name = reader.GetString(0);

                string privilege = cb_priv.SelectedItem.ToString();

                var cmd = new OracleCommand();
                cmd.Connection = con;
                if (privilege == "INSERT")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"GRANT INSERT ON {tableName} TO {userOrRoleName} {option}";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cấp quyền thành công!");
                }
                else if (privilege == "DELETE")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"GRANT DELETE ON {tableName} TO {userOrRoleName} {option}";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cấp quyền thành công!");
                }
                else if (privilege == "UPDATE")
                {
                    if (col_list == "")
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = $"GRANT UPDATE ON {tableName} TO {userOrRoleName} {option}";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cấp quyền thành công!");
                    }
                    else
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = $"GRANT UPDATE({col_list}) ON {tableName} TO {userOrRoleName} {option}";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cấp quyền thành công!");
                    }
                }
                else if (privilege == "SELECT")
                {
                    string v_name = "UV_" + tableName + "_" + userOrRoleName;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"SELECT COUNT(*) FROM user_views WHERE view_name = '{v_name}'";
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (col_list == "")
                    {
                        cmd.CommandText = $"GRANT SELECT ON {schema_name}.{tableName} TO {userOrRoleName} {option}";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cấp quyền thành công!");
                    }
                    else
                    {
                        if (count > 0)
                        {
                            // The view exists
                            cmd.CommandText = $"DROP VIEW {schema_name}.{v_name}";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"CREATE VIEW {schema_name}.{v_name} AS SELECT {col_list} FROM {schema_name}.{tableName}";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"GRANT SELECT ON {schema_name}.{v_name} TO {userOrRoleName} {option}";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cấp quyền thành công!");
                        }
                        else
                        {
                            // The view does not exist
                            cmd.CommandText = $"CREATE VIEW {schema_name}.{v_name} AS SELECT {col_list} FROM {schema_name}.{tableName}";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"GRANT SELECT ON {schema_name}.{v_name} TO {userOrRoleName} {option}";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cấp quyền thành công!");
                        }
                    }


                }
                //    using (OracleCommand cmd = new OracleCommand())
                //    {
                //        cmd.Connection = con;
                //        cmd.CommandType = CommandType.StoredProcedure;

                //        switch (privilege)
                //        {
                //            case "SELECT":
                //                {
                //                    if (col_list == "")
                //                    {
                //                        cmd.CommandText = "grant_select_priv";
                //                    }
                //                    else
                //                    {
                //                        cmd.CommandText = "grant_select_priv_col";
                //                        cmd.Parameters.Add("p_column", OracleDbType.Varchar2).Value = col_list;
                //                    }
                //                    break;
                //                }
                //            case "DELETE":
                //                cmd.CommandText = "grant_delete_priv";
                //                break;
                //            case "UPDATE":
                //                {
                //                    if (col_list == "")
                //                    {
                //                        cmd.CommandText = "grant_update_priv";
                //                    }
                //                    else
                //                    {
                //                        cmd.CommandText = "sys.grant_update_priv_col";
                //                        cmd.Parameters.Add("p_column", OracleDbType.Varchar2).Value = col_list;
                //                    }
                //                    break;
                //                }
                //            case "INSERT":
                //                cmd.CommandText = "grant_insert_priv";
                //                break;  
                //        } 

                //        cmd.Parameters.Add("p_principal", OracleDbType.Varchar2).Value = userOrRoleName;
                //        cmd.Parameters.Add("p_schema", OracleDbType.Varchar2).Value = schema_name;
                //        cmd.Parameters.Add("p_table", OracleDbType.Varchar2).Value = tableName;
                //        cmd.Parameters.Add("p_with_grant_option", OracleDbType.Varchar2).Value = option;
                //        string message = "p_principal: " + userOrRoleName + "\n" +
                //         "p_schema: " + schema_name + "\n" +
                //         "p_table: " + tableName + "\n" +
                //         "p_with_grant_option: " + option + "\n" + col_list;

                //        try
                //        {
                //            cmd.ExecuteNonQuery();
                //            MessageBox.Show("Quyền đã được cấp thành công!");
                //        }
                //        catch (Exception ex)
                //        {
                //            MessageBox.Show("Error: " + ex.Message);
                //        }
                //    }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clb_col_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cb_priv.Text == "INSERT" || cb_priv.Text == "DELETE")
            //{
            //    clb_col.Enabled = false;    
            //}    
            //else
            //    clb_col.Enabled=true;
        }

        private void cb_priv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_priv.Text == "INSERT" || cb_priv.Text == "DELETE")
            {
                clb_col.Enabled = false;
            }
            else
                clb_col.Enabled = true;
            for (int i = 0; i < clb_col.Items.Count; i++)
            {
                clb_col.SetItemChecked(i, false);
            }
        }

        private void btt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
