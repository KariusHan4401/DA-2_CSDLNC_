using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QUANLYCONCUNG
{
    public partial class QuanLy : UserControl
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            btnThemSP.Show();
            btnXoaSP.Show();
            btnCapNhatSP.Show();

            btnThemLH.Hide();
            btnXoaLH.Hide();
            btnUpdateLH.Hide();

            panelQL.Controls.Clear();
            panelQL.Controls.Add(new datagridviewXEMSP());
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            btnThemSP.Hide();
            btnXoaSP.Hide();
            btnCapNhatSP.Hide();

            btnThemLH.Hide();
            btnXoaLH.Hide();
            btnUpdateLH.Hide();

            pictureBoxCC.Show();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            panelQL.Controls.Clear();
            panelQL.Controls.Add(new ThemSP());
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            panelQL.Controls.Clear();
            panelQL.Controls.Add(new XoaSP());
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            panelQL.Controls.Clear();
            panelQL.Controls.Add(new CapNhatSP());
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            btnThemLH.Show();
            btnXoaLH.Show();
            btnUpdateLH.Show();

            btnThemSP.Hide();
            btnXoaSP.Hide();
            btnCapNhatSP.Hide();

            panelQL.Controls.Clear();
            panelQL.Controls.Add(new datagridviewXEMLH());
        }

        private void btnThemLH_Click(object sender, EventArgs e)
        {
            panelQL.Controls.Clear();
            panelQL.Controls.Add(new ThemLH());
        }

        private void btnXoaLH_Click(object sender, EventArgs e)
        {
            panelQL.Controls.Clear();
            panelQL.Controls.Add(new XoaLH());
        }

        private void btnUpdateLH_Click(object sender, EventArgs e)
        {
            panelQL.Controls.Clear();
            panelQL.Controls.Add(new CapNhatLH());
        }

        private void pictureBoxCC_Click(object sender, EventArgs e)
        {

        }
    }
}
