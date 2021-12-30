using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYCONCUNG
{
    public partial class datagridviewXEMSP : UserControl
    {
        public datagridviewXEMSP()
        {
            InitializeComponent();
        }

        void Data_Load()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    var query = "SELECT * FROM SAN_PHAM";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dataGridViewSP.DataSource = dt;
                    dataGridViewSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datagridviewXEMSP_Load(object sender, EventArgs e)
        {
            Data_Load();
        }
    }
}
