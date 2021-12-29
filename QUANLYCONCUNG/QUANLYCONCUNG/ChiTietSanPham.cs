using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QUANLYCONCUNG
{
    public partial class ChiTietSanPham : UserControl
    {
        ProductItem _item;
        public ChiTietSanPham(ProductItem item)
        {
            _item = item;
            InitializeComponent();
            NameField.Text = item._tenSP;
            priceLabel.Text = item._gia.ToString() + "đ";
            brandLabel.Text = getBrand(item._maTH);
            productPicture.ImageLocation = item._anh;
            typeLabel.Text = getProductType(item._maLH);
            pdIdLabel.Text = "MSP: " + item._maSP.ToString();
            cmtCountLabel.Text = item._binhLuan.ToString();
            loveCountLabel.Text = item._yeuThich.ToString();
            descriptionField.Text = item._moTa;
            LoadComment(item._maSP);
        }

        public String getBrand(int brandID) {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    
                    string proc  = "USP_TIM_TEN_THUONG_HIEU";

                    SqlCommand cmd = new SqlCommand(proc, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MATH", brandID);

                    var returnParam = cmd.Parameters.Add("@TEN_TH", SqlDbType.NVarChar,20);
                    returnParam.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    String result = returnParam.Value.ToString();
                    connection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Không có";
            }
        }

        public String getProductType(int typeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();

                    string proc = "USP_TIM_LOAI_HANG";

                    SqlCommand cmd = new SqlCommand(proc, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MALH", typeID);

                    var returnParam = cmd.Parameters.Add("@TEN_LH", SqlDbType.NVarChar, 30);
                    returnParam.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    String result = returnParam.Value.ToString();
                    connection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Không có";
            }
        }

        public void LoadComment(int pdID) {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();

                    string query = "SELECT MAKH, NOI_DUNG, NGAY_DANG FROM BINH_LUAN WHERE MASP = "+pdID;
                  
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    commentGridView.DataSource = dt;
                    commentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
