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
    public partial class Form1 : Form
    {
        public List<ProductItem> itemProducts;
        public List<ProductItem> itemProductsFilter;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text.ToLower();
            myFlowLayoutPanel1.Controls.Clear();
            if (string.IsNullOrEmpty(keyword))
            {
                myFlowLayoutPanel1.Controls.AddRange(itemProducts.ToArray());
            }
            else
            {
                var dataFilter = itemProductsFilter.Where(x => x.TenSP.ToLower().Contains(keyword)).ToArray();
                myFlowLayoutPanel1.Controls.AddRange(dataFilter);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            getItems();
        }
        private void getItems()
        {
            var data = SanPham.GetProducts();

            var list = new ProductItem[data.Count];
            int i = 0;
            itemProducts = new List<ProductItem>();
            itemProductsFilter = new List<ProductItem>();
            foreach (var item in data)
            {
                list[i] = new ProductItem();
                list[i].YeuThich = item.LuotYeuThich;
                list[i].BinhLuan = item.LuotBinhLuan;
                list[i].HinhAnh = item.HinhAnh;
                list[i].TenSP = item.TenSP;
                list[i].GiaBan = item.GiaBan;
                //list[i].LoadImageAsync();
                itemProducts.Add(list[i]);
                itemProductsFilter.Add(list[i]);
                i++;
            }

            myFlowLayoutPanel1.Controls.AddRange(list);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var keyword = RemoveUnicode(txtSearch.Text.ToLower());
            myFlowLayoutPanel1.Controls.Clear();
            if (string.IsNullOrEmpty(keyword))
            {
                myFlowLayoutPanel1.Controls.AddRange(itemProducts.ToArray());
            }
            else
            {
                var dataFilter = itemProductsFilter.Where(x => RemoveUnicode(x.TenSP.ToLower()).Contains(keyword)).ToArray();
                myFlowLayoutPanel1.Controls.AddRange(dataFilter);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
