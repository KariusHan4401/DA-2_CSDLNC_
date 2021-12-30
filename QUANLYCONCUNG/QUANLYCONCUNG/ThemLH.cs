using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYCONCUNG
{
    public partial class ThemLH : UserControl
    {
        public ThemLH()
        {
            InitializeComponent();
        }

        void Data_Load()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    var query = "SELECT * FROM LOAI_HANG";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    showLH.DataSource = dt;
                    showLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void ThemLH_Load(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void btnThemLH_Click(object sender, EventArgs e)
        {
            if (textTenLH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại hàng cần thêm!!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    string query = "INSERT LOAI_HANG (TEN_LH) VALUES (N'" + textTenLH.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm loại hàng thành công!!");

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
