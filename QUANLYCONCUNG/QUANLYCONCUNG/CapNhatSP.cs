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
    public partial class CapNhatSP : UserControl
    {
        public CapNhatSP()
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

        private void btnCheck_Click(object sender, EventArgs e)
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

        private void btnCapNhat_Click(object sender, EventArgs e)
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

                    string query = "UPDATE SAN_PHAM SET ";
                    int count = 0;

                    if (txtTenSP.Text != "")
                    {
                        query += "TEN_SP = N'" + txtTenSP.Text;
                        count += 1;
                    }

                    if (cbBMALH.Text != "")
                    {
                        if (count != 0)
                            query += "', MALH = N'" + cbBMALH.Text;
                        else
                            query += "MALH = N'" + cbBMALH.Text;
                        count += 1;
                    }

                    if (cbBMATH.Text != "")
                    {
                        if (count != 0)
                            query += "', MATH = '" + cbBMATH.Text;
                        else
                            query += "MATH = '" + cbBMATH.Text;
                        count += 1;
                    }

                    if (txtHA.Text != "")
                    {
                        if (count != 0)
                            query += "', HINH_ANH = N'" + txtHA.Text;
                        else
                            query += "HINH_ANH = N'" + txtHA.Text;
                        count += 1;
                    }

                    if (txtMoTa.Text != "")
                    {
                        if (count != 0)
                            query += "', MO_TA = N'" + txtMoTa.Text;
                        else
                            query += "MO_TA = N'" + txtMoTa.Text;
                        count += 1;
                    }

                    if (txtGia.Text != "")
                    {
                        if (count != 0)
                            query += "', GIA_BAN = N'" + txtGia.Text;
                        else
                            query += "GIA_BAN = N'" + txtGia.Text;
                        count += 1;
                    }

                    if (count != 0)
                    {
                        query += "'";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtTenSP.Clear();
            txtMoTa.Clear();
            txtHA.Clear();
            txtGia.Clear();
            cbBMALH.Text = "1";
            cbBMATH.Text = "1";
        }

        private void CapNhatSP_Load(object sender, EventArgs e)
        {
            ComboBox_Load();
        }
    }
}
