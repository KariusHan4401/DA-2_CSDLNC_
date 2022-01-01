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
    public partial class ThongKeDT : UserControl
    {
        public ThongKeDT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThongKeDT_Load(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXemTKTh_Click(object sender, EventArgs e)
        {
            if (txtNAM1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm cần thống kê!");
                return;
            }

            int nam = int.Parse(txtNAM1.Text);
            if (nam < 0)
            {
                MessageBox.Show("Năm không hợp lệ!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();

                    SqlCommand cmd1 = new SqlCommand("EXEC USP_THONGKE_THANG_CN " + nam, connection);
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd1);
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapter1.Fill(dataTable1);
                    dataGridViewDTCN.DataSource = dataTable1;
                    dataGridViewDTCN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    SqlCommand cmd2 = new SqlCommand("EXEC USP_THONGKE_THANG_TONG " + nam, connection);
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
                    DataTable dataTable2 = new DataTable();
                    sqlDataAdapter2.Fill(dataTable2);
                    dataGridViewDTTong.DataSource = dataTable2;
                    dataGridViewDTTong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtNAM1.Clear();
            txtNAM2.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnXemTKN_Click(object sender, EventArgs e)
        {
            if (txtNAM2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm cần thống kê!");
                return;
            }

            int nam = int.Parse(txtNAM2.Text);
            if (nam < 0)
            {
                MessageBox.Show("Năm không hợp lệ!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();

                    SqlCommand cmd1 = new SqlCommand("EXEC USP_THONGKE_NAM_CN " + nam, connection);
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd1);
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapter1.Fill(dataTable1);
                    dataGridViewDTCN.DataSource = dataTable1;
                    dataGridViewDTCN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    SqlCommand cmd2 = new SqlCommand("EXEC USP_THONGKE_NAM_TONG " + nam, connection);
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
                    DataTable dataTable2 = new DataTable();
                    sqlDataAdapter2.Fill(dataTable2);
                    dataGridViewDTTong.DataSource = dataTable2;
                    dataGridViewDTTong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtNAM1.Clear();
            txtNAM2.Clear();
        }

        private void btnXemTKNg_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();

                    SqlCommand cmd1 = new SqlCommand("EXEC USP_THONGKE_NGAY_CN '" + dateTimePicker.Text + "'", connection);
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd1);
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapter1.Fill(dataTable1);
                    dataGridViewDTCN.DataSource = dataTable1;
                    dataGridViewDTCN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    SqlCommand cmd2 = new SqlCommand("EXEC USP_THONGKE_NGAY_TONG '" + dateTimePicker.Text + "'", connection);
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
                    DataTable dataTable2 = new DataTable();
                    sqlDataAdapter2.Fill(dataTable2);
                    dataGridViewDTTong.DataSource = dataTable2;
                    dataGridViewDTTong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
