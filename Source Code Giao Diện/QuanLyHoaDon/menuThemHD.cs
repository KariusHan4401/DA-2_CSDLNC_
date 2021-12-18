using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHoaDon
{
    public partial class menuThemHD : UserControl
    {
        public menuThemHD()
        {
            InitializeComponent();
        }

        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            panelMenuThemHD.Controls.Clear();
            panelMenuThemHD.Controls.Add(new ThemHDControl());
        }

        private void buttonThemCTHD_Click(object sender, EventArgs e)
        {
            panelMenuThemHD.Controls.Clear();
            panelMenuThemHD.Controls.Add(new ThemCTHD());
        }
    }
}
