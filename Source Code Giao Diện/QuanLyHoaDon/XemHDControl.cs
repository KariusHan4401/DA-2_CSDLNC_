using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoaDon
{
    public partial class XemHDControl : UserControl
    {
        public XemHDControl()
        {
            InitializeComponent();
        }
        
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
            {
                //khởi tạo câu truy vấn từ lựa chọn của người dùng
                string query = "SELECT * FROM HOADON HD";
                string condition = " WHERE ";
                string dateCondition = "";
                DateTime date = dateTimePicker1.Value;
                if (textBoxMaHD.Text != "")
                {
                    condition += " HD.MAHD="+"'"+textBoxMaHD.Text+"'"+" AND ";
                }
                if (textBoxMaKH.Text != "")
                {
                    condition += " HD.MAKH=" + "'" + textBoxMaKH.Text + "'" + " AND ";
                }
                foreach (RadioButton item in panelDate.Controls)
                {
                    if(item!=null)
                    if (item.Checked)
                    {
                        if(item == radioButtonThang)
                        {
                                dateCondition = "(DATEPART(MONTH,HD.NGAYLAP)="+date.Month+")"+" AND ";
                        }
                        if (item == radioButtonNam)
                        {
                                dateCondition = "(DATEPART(YEAR,HD.NGAYLAP)=" + date.Year+ ")" + " AND ";
                            }
                        if (item == radioButtonNamThang)
                        {
                                dateCondition = "(DATEPART(YEAR,HD.NGAYLAP)=" + date.Year + ")"  + " AND "+"(DATEPART(MONTH,HD.NGAYLAP)=" + date.Month + ")" + " AND ";
                        }
                        if(item == radioButtonNTN)
                        {
                            dateCondition = "(HD.NGAYLAP = "+"'"+date.ToShortDateString()+"'"+")" + " AND ";
                        }
                    }
                }
                condition += dateCondition;
                condition += " (HD.MAHD IS NOT NULL)";
                query = query + condition;
                
                //clear lựa chọn thời gian
                //foreach(RadioButton item in panelDate.Controls)
                //{
                    //item.Checked = false;
                //}

                //load lại bảng dữ liệu
                LoadData(query);
            }
        }


        void LoadData(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
        }

        private void XemHDControl_Load(object sender, EventArgs e)
        {
            //load toàn bộ dữ liệu cho người dùng
            LoadData("SELECT* FROM HOADON");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //trống
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
