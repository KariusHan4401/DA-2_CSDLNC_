using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHoaDon
{
    public partial class ThemCTHD : UserControl
    {
        public ThemCTHD()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void buttonThemCTHD_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(ConnectionString.connection))
            {
                string maSP, maHD;
                maSP = textBoxMaSP.Text;
                maHD = textBoxMaHD.Text;
                int slg = ((int)numericUpDownSlg.Value);
                uint giaBan = ((uint)numericUpDownGiaBan.Value);
                uint giaGiam = ((uint)numericUpDownGiaGiam.Value);


                if (maSP.Length != 8)
                {
                    MessageBox.Show("Ma san pham khong hop le");
                    textBoxMaSP.Clear();
                    return;
                }

                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT* FROM SANPHAM WHERE SANPHAM.MASP = '" + textBoxMaSP.Text + "'", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    SqlCommand command = new SqlCommand("insert into CT_HOADON (MAHD, MASP, SOLUONG, GIABAN, GIAGIAM) " +
                                                         "values ('" + maHD + "', '" + maSP + "', " + slg + ", " + giaBan + ", " + giaGiam + ");", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Ma san pham khong ton tai");
                }
                connection.Close();
            }
        }

        private void ThemCTHD_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
