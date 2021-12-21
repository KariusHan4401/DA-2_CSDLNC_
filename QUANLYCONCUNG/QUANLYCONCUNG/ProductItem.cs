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

        public string _tenSP;
        public decimal _gia;
        public string _anh;
        public int _yeuThich;
        public int _binhLuan;



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
    }
}
