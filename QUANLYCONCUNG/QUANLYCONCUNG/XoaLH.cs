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
    public partial class XoaLH : UserControl
    {
        public XoaLH()
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

                    query = "SELECT MALH FROM LOAI_HANG";
                    cmd = new SqlCommand(query, connection);
                    SqlDataReader read;
                    read = cmd.ExecuteReader();
                    DataTable dataTable_2 = new DataTable();
                    dataTable_2.Columns.Add("MALH", typeof(string));
                    dataTable_2.Load(read);
                    cbMALH.ValueMember = "MALH";
                    cbMALH.DataSource = dataTable_2;
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

        private void XoaLH_Load(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbMALH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã loại hàng!!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_HANG WHERE MALH = " + cbMALH.Text, connection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    //KIỂM TRA MÃ LOẠI HÀNG TỒN TẠI
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã loại hàng chưa tồn tại!!");
                        connection.Close();
                        return;
                    }
                    DialogResult noti;
                    noti = MessageBox.Show("Bạn có chắc là muốn xóa loại hàng không? (Kiểm tra các sản phẩm liên quan đến loại hàng này)", "Thông báo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (noti == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("EXEC USP_XOA_LH " + cbMALH.Text, connection);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa loại hàng thành công!! Cập nhật lại sản phẩm (MALH = -1) của loại hàng vừa xóa!!");
                    }
                    

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMALH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    var query = "SELECT * FROM LOAI_HANG WHERE MALH = '" + cbMALH.Text + "'";
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
    }
}
