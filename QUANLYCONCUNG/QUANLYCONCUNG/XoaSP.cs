using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace QUANLYCONCUNG
{
    public partial class XoaSP : UserControl
    {
        public XoaSP()
        {
            InitializeComponent();
        }

        void Data_Load()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    string query = "SELECT * FROM SAN_PHAM WHERE MASP = '" + txtMaSP.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);
                    dataGridViewSP.DataSource = dataTable;
                    dataGridViewSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!");
                return;
            }

            Data_Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM SAN_PHAM WHERE MASP = " + txtMaSP.Text, connection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd1);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    //kiem tra ma hoa don co ton tai khong
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã sản phẩm không tồn tại");
                        connection.Close();
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("EXEC USP_XOA_SP " + txtMaSP.Text, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa sản phẩm thành công!");

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Data_Load();
        }
    }
}
