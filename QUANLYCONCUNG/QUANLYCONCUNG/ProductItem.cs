using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYCONCUNG
{
    public partial class ProductItem : UserControl
    {
        public ProductItem()
        {
            InitializeComponent();
        }

        private void Comment_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public int _maSP;
        public int _maTH;
        public int _maLH;
        public string _tenSP;
        public decimal _gia;
        public string _anh;
        public int _yeuThich;
        public int _binhLuan;
        public string _moTa;
        public Panel _mainPanel;

        public int MaLH
        {
            get { return _maLH; }
            set { _maLH = value; }
        }

        public int MaTH
        {
            get { return _maTH; }
            set { _maTH = value; }
        }

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        public int MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }


        public Panel MainPanel
        {
            get { return _mainPanel; }
            set { _mainPanel = value; }
        }


        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; lbl_name.Text = value; }
        }

        public decimal GiaBan
        {
           
            get { return this._gia; }
            set { _gia = value;
                lbl_Price.Text = "₫" + value.ToString();
            }
        }


        public string HinhAnh
        {
            get { return _anh; }
            set { _anh = value;  
                pic_product.ImageLocation = value;

            }
        }

        public int BinhLuan
        {
            get { return _binhLuan; }
            set { _binhLuan = value; lbl_comment.Text = value.ToString(); }
        }


        public int YeuThich
        {
            get { return _yeuThich; }
            set { _yeuThich = value;
                lbl_love.Text = value.ToString();
            }
        }
        public Image LoadImageFromFileAsync(string url)
        {
            return Image.FromFile(url);
        }
        public void LoadImageAsync()
        {
            var image = LoadImageFromFileAsync(this.HinhAnh);
            pic_product.BackgroundImage = image;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void ProductItem_Load(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void pic_product_DoubleClick(object sender, EventArgs e)
        {
            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(new ChiTietSanPham(this));
        }

        private void pic_product_Click(object sender, EventArgs e)
        {

        }
    }
}
