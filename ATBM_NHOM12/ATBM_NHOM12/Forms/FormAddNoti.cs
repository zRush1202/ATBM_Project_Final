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
    public partial class FormAddNoti : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public FormAddNoti()
        {
            InitializeComponent();
        }

        string GetSelectedValues(CheckedListBox checkedListBox)
        {
            List<string> selectedValues = new List<string>();
            foreach (var item in checkedListBox.CheckedItems)
            {
                selectedValues.Add(item.ToString());
            }
            return string.Join(",", selectedValues);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string levelValues = GetSelectedValues(clbLevel);
            string compartmentValues = GetSelectedValues(clbCompartment);
            string groupValues = GetSelectedValues(clbGroup);
            string query = $"INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL) SELECT MAX(ID) + 1, '{tbxNoiDung.Text}', CHAR_TO_LABEL('THONGBAO_POLICY', '{levelValues}:{compartmentValues}:{groupValues}') FROM ADPRO.THONGBAO";
            string query2 = "UPDATE ADPRO.THONGBAO SET NoiDung = NoiDung ";
            string query3 = "COMMIT";
            try
            {
                OracleCommand command = new OracleCommand();
                command.Connection = con;
                command.CommandText = query;
                command.ExecuteNonQuery();

                OracleCommand command2 = new OracleCommand();
                command2.Connection = con;
                command2.CommandText = query2;
                command2.ExecuteNonQuery();

                OracleCommand command4 = new OracleCommand();
                command4.Connection = con;
                command4.CommandText = query3;
                command4.ExecuteNonQuery();

                if (tbxUserID.Text != "")
                {
                    OracleCommand command3 = new OracleCommand();
                    command3.Connection = con;
                    command3.CommandText = "SA_USER_ADMIN.SET_USER_LABELS";
                    command3.CommandType = System.Data.CommandType.StoredProcedure;

                    command3.Parameters.Add(new OracleParameter("POLICY_NAME", OracleDbType.Varchar2, "THONGBAO_POLICY", System.Data.ParameterDirection.Input));
                    command3.Parameters.Add(new OracleParameter("USER_NAME", OracleDbType.Varchar2, $"{tbxUserID.Text}", System.Data.ParameterDirection.Input));
                    command3.Parameters.Add(new OracleParameter("MAX_READ_LABEL", OracleDbType.Varchar2, $"{levelValues}:{compartmentValues}:{groupValues}", System.Data.ParameterDirection.Input));

                    command3.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm thông báo thành công!!!");
                command4.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
