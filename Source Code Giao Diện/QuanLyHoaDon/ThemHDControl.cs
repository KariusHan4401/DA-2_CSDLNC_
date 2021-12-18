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
    public partial class ThemHDControl : UserControl
    {
        public ThemHDControl()
        {
            InitializeComponent();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonTaoHD_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(ConnectionString.connection))
            {
                string maHD, maKH;
                DateTime ngay = dateTimePickerNgay.Value;
                maHD = textBoxMaHD.Text;
                maKH = textBoxMaKH.Text;

                if (maKH.Length != 8)
                {
                    MessageBox.Show("Ma khach hang khong hop le");
                    textBoxMaKH.Clear();
                    return;
                }

                if (maHD.Length != 8)
                {
                    MessageBox.Show("Ma hoa don khong hop le");
                    textBoxMaHD.Clear();
                    return;
                }

                connection.Open();
                string sqlHD = "SELECT* FROM HOADON WHERE HOADON.MAHD = '" + textBoxMaHD.Text + "'";
                string sqlKH = "SELECT* FROM KHACHHANG WHERE KHACHHANG.MAKH = '" + textBoxMaKH.Text + "'";

                SqlCommand cmd1 = new SqlCommand(sqlHD, connection);
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd1);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter1.Fill(dataTable1);

                //kiem tra ma hoa don co ton tai khong
                if (dataTable1.Rows.Count > 0)
                {
                    MessageBox.Show("MaHD da ton tai");
                    connection.Close();
                    return;
                }

                //kiem tra ma khach hang co ton tai khong
                SqlCommand cmd2 = new SqlCommand(sqlKH, connection);
                SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
                DataTable dataTable2 = new DataTable();
                sqlDataAdapter2.Fill(dataTable2);
                if (dataTable2.Rows.Count > 0)
                {
                    SqlCommand command = new SqlCommand("insert into HOADON (MAHD, MAKH, NGAYLAP) " +
                                                         "values ('" + maHD + "', '" + maKH + "', '" + ngay + "')", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Them hoa don thanh cong!");
                }
                else
                {
                    MessageBox.Show("MaKH khong ton tai");
                    connection.Close();
                    return;
                }
                connection.Close();
            }
        }
    }
}
