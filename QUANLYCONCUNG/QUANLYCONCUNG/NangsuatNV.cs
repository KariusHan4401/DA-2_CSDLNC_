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
    public partial class NangsuatNV : UserControl
    {
        public NangsuatNV()
        {
            InitializeComponent();
        }
        public DataTable dataTable { get; set; }

        private void NangsuatNV_Load(object sender, EventArgs e)
        {
            LoadNangSuat("");
        }
         
        void LoadNangSuat(string dieuKien)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();

                    string query = "SELECT MANV, TEN_NV, CN.MACN, CN.QUAN_TP + ', ' + CN.TP_TINH AS DIA_CHI_CN, TONG_DON_BAN, TONG_TIEN_BAN FROM NHAN_VIEN NV JOIN CHI_NHANH CN ON NV.MACN = CN.MACN " + dieuKien;

                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable  dt = new DataTable();
                    data.Fill(dt);
                    gridViewNangSuat.DataSource = dt;
                    gridViewNangSuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dk = "WHERE TEN_NV LIKE N'%" + txtTen.Text + "%'";
            LoadNangSuat(dk);
        }
    }
}
