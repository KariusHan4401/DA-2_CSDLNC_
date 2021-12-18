
namespace QuanLyHoaDon
{
    partial class XemHDControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.labelMaHD = new System.Windows.Forms.Label();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButtonThang = new System.Windows.Forms.RadioButton();
            this.panelDate = new System.Windows.Forms.Panel();
            this.radioButtonNTN = new System.Windows.Forms.RadioButton();
            this.radioButtonNamThang = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(290, 76);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(321, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Xem danh sách hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 293);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(555, 321);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(625, 143);
            this.buttonLoadData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(82, 32);
            this.buttonLoadData.TabIndex = 2;
            this.buttonLoadData.Text = "Xem";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // labelMaHD
            // 
            this.labelMaHD.AutoSize = true;
            this.labelMaHD.Location = new System.Drawing.Point(161, 155);
            this.labelMaHD.Name = "labelMaHD";
            this.labelMaHD.Size = new System.Drawing.Size(59, 20);
            this.labelMaHD.TabIndex = 3;
            this.labelMaHD.Text = "MaHD: ";
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Location = new System.Drawing.Point(161, 193);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(57, 20);
            this.labelMaKH.TabIndex = 4;
            this.labelMaKH.Text = "MaKH: ";
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(222, 144);
            this.textBoxMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(114, 27);
            this.textBoxMaHD.TabIndex = 5;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(222, 189);
            this.textBoxMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(114, 27);
            this.textBoxMaKH.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 143);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 14, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(3, 33);
            this.radioButtonNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(62, 24);
            this.radioButtonNam.TabIndex = 15;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonThang
            // 
            this.radioButtonThang.AutoSize = true;
            this.radioButtonThang.Location = new System.Drawing.Point(3, 0);
            this.radioButtonThang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonThang.Name = "radioButtonThang";
            this.radioButtonThang.Size = new System.Drawing.Size(71, 24);
            this.radioButtonThang.TabIndex = 16;
            this.radioButtonThang.TabStop = true;
            this.radioButtonThang.Text = "Thang";
            this.radioButtonThang.UseVisualStyleBackColor = true;
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.radioButtonNTN);
            this.panelDate.Controls.Add(this.radioButtonNamThang);
            this.panelDate.Controls.Add(this.radioButtonNam);
            this.panelDate.Controls.Add(this.radioButtonThang);
            this.panelDate.Location = new System.Drawing.Point(368, 189);
            this.panelDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(257, 92);
            this.panelDate.TabIndex = 17;
            // 
            // radioButtonNTN
            // 
            this.radioButtonNTN.AutoSize = true;
            this.radioButtonNTN.Location = new System.Drawing.Point(106, 33);
            this.radioButtonNTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNTN.Name = "radioButtonNTN";
            this.radioButtonNTN.Size = new System.Drawing.Size(150, 24);
            this.radioButtonNTN.TabIndex = 17;
            this.radioButtonNTN.TabStop = true;
            this.radioButtonNTN.Text = "Ngay-Thang-Nam";
            this.radioButtonNTN.UseVisualStyleBackColor = true;
            // 
            // radioButtonNamThang
            // 
            this.radioButtonNamThang.AutoSize = true;
            this.radioButtonNamThang.Location = new System.Drawing.Point(106, 1);
            this.radioButtonNamThang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNamThang.Name = "radioButtonNamThang";
            this.radioButtonNamThang.Size = new System.Drawing.Size(109, 24);
            this.radioButtonNamThang.TabIndex = 14;
            this.radioButtonNamThang.TabStop = true;
            this.radioButtonNamThang.Text = "Nam-Thang";
            this.radioButtonNamThang.UseVisualStyleBackColor = true;
            // 
            // XemHDControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.labelMaKH);
            this.Controls.Add(this.labelMaHD);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XemHDControl";
            this.Size = new System.Drawing.Size(797, 711);
            this.Load += new System.EventHandler(this.XemHDControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Label labelMaHD;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.RadioButton radioButtonThang;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.RadioButton radioButtonNamThang;
        private System.Windows.Forms.RadioButton radioButtonNTN;
    }
}
