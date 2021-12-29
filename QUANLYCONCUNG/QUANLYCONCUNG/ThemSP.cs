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
    public partial class ThemSP : UserControl
    {
        public ThemSP()
        {
            InitializeComponent();
        }

        private void ComboBox_Load()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    var query = "SELECT MALH FROM LOAI_HANG";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader read;
                    read = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("MALH", typeof(string));
                    dataTable.Load(read);
                    cbBMALH.ValueMember = "MALH";
                    cbBMALH.DataSource = dataTable;

                    query = "SELECT MATH FROM THUONG_HIEU";
                    cmd = new SqlCommand(query, connection);
                    read = cmd.ExecuteReader();
                    DataTable dataTable_2 = new DataTable();
                    dataTable_2.Columns.Add("MATH", typeof(string));
                    dataTable_2.Load(read);
                    cbBMATH.ValueMember = "MATH";
                    cbBMATH.DataSource = dataTable_2;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" || txtHA.Text == "" || txtMoTa.Text == "" ||txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    string query = "INSERT SAN_PHAM (MALH, MATH, TEN_SP, HINH_ANH, MO_TA, GIA_BAN) VALUES (" + cbBMALH.Text + ", " + cbBMATH.Text + ", N'" + txtTenSP.Text + "', '" + txtHA.Text + "', N'" + txtMoTa.Text + "', " + txtGia.Text + ")";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm sản phẩm thành công!");

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtTenSP.Clear();
            txtHA.Clear();
            txtMoTa.Clear();
            txtGia.Clear();
            cbBMATH.Text = "1";
            cbBMALH.Text = "1";
        }

        private void ThemSP_Load(object sender, EventArgs e)
        {
            ComboBox_Load();
        }

        private void cbBMATH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
