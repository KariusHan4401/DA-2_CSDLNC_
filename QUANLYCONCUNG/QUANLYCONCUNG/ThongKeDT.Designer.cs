
namespace QUANLYCONCUNG
{
    partial class ThongKeDT
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
            this.dataGridViewDTCN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtNAM1 = new System.Windows.Forms.TextBox();
            this.txtNAM2 = new System.Windows.Forms.TextBox();
            this.btnXemTKNg = new System.Windows.Forms.Button();
            this.btnXemTKTh = new System.Windows.Forms.Button();
            this.btnXemTKN = new System.Windows.Forms.Button();
            this.dataGridViewDTTong = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTTong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDTCN
            // 
            this.dataGridViewDTCN.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewDTCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDTCN.Location = new System.Drawing.Point(354, 228);
            this.dataGridViewDTCN.Name = "dataGridViewDTCN";
            this.dataGridViewDTCN.RowHeadersWidth = 51;
            this.dataGridViewDTCN.RowTemplate.Height = 29;
            this.dataGridViewDTCN.Size = new System.Drawing.Size(514, 141);
            this.dataGridViewDTCN.TabIndex = 0;
            this.dataGridViewDTCN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(144, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theo ngày (mm/dd/yyyy)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(172, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Theo tháng trong năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(291, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Theo năm";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM - yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(417, 78);
            this.dateTimePicker.MaxDate = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(318, 27);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNAM1
            // 
            this.txtNAM1.Location = new System.Drawing.Point(417, 127);
            this.txtNAM1.Name = "txtNAM1";
            this.txtNAM1.Size = new System.Drawing.Size(318, 27);
            this.txtNAM1.TabIndex = 5;
            // 
            // txtNAM2
            // 
            this.txtNAM2.Location = new System.Drawing.Point(417, 180);
            this.txtNAM2.Name = "txtNAM2";
            this.txtNAM2.Size = new System.Drawing.Size(318, 27);
            this.txtNAM2.TabIndex = 6;
            // 
            // btnXemTKNg
            // 
            this.btnXemTKNg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXemTKNg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemTKNg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemTKNg.Location = new System.Drawing.Point(759, 76);
            this.btnXemTKNg.Name = "btnXemTKNg";
            this.btnXemTKNg.Size = new System.Drawing.Size(90, 29);
            this.btnXemTKNg.TabIndex = 7;
            this.btnXemTKNg.Text = "Xem";
            this.btnXemTKNg.UseVisualStyleBackColor = false;
            this.btnXemTKNg.Click += new System.EventHandler(this.btnXemTKNg_Click);
            // 
            // btnXemTKTh
            // 
            this.btnXemTKTh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXemTKTh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemTKTh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemTKTh.Location = new System.Drawing.Point(759, 127);
            this.btnXemTKTh.Name = "btnXemTKTh";
            this.btnXemTKTh.Size = new System.Drawing.Size(90, 29);
            this.btnXemTKTh.TabIndex = 8;
            this.btnXemTKTh.Text = "Xem";
            this.btnXemTKTh.UseVisualStyleBackColor = false;
            this.btnXemTKTh.Click += new System.EventHandler(this.btnXemTKTh_Click);
            // 
            // btnXemTKN
            // 
            this.btnXemTKN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXemTKN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemTKN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemTKN.Location = new System.Drawing.Point(759, 178);
            this.btnXemTKN.Name = "btnXemTKN";
            this.btnXemTKN.Size = new System.Drawing.Size(90, 29);
            this.btnXemTKN.TabIndex = 9;
            this.btnXemTKN.Text = "Xem";
            this.btnXemTKN.UseVisualStyleBackColor = false;
            this.btnXemTKN.Click += new System.EventHandler(this.btnXemTKN_Click);
            // 
            // dataGridViewDTTong
            // 
            this.dataGridViewDTTong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewDTTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDTTong.Location = new System.Drawing.Point(354, 395);
            this.dataGridViewDTTong.Name = "dataGridViewDTTong";
            this.dataGridViewDTTong.RowHeadersWidth = 51;
            this.dataGridViewDTTong.RowTemplate.Height = 29;
            this.dataGridViewDTTong.Size = new System.Drawing.Size(514, 81);
            this.dataGridViewDTTong.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(123, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Doanh thu chi nhánh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(172, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doanh thu tổng:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ThongKeDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewDTTong);
            this.Controls.Add(this.btnXemTKN);
            this.Controls.Add(this.btnXemTKTh);
            this.Controls.Add(this.btnXemTKNg);
            this.Controls.Add(this.txtNAM2);
            this.Controls.Add(this.txtNAM1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDTCN);
            this.Name = "ThongKeDT";
            this.Size = new System.Drawing.Size(1263, 662);
            this.Load += new System.EventHandler(this.ThongKeDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTTong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDTCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtNAM1;
        private System.Windows.Forms.TextBox txtNAM2;
        internal System.Windows.Forms.Button btnXemTKNg;
        internal System.Windows.Forms.Button btnXemTKTh;
        internal System.Windows.Forms.Button btnXemTKN;
        private System.Windows.Forms.DataGridView dataGridViewDTTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
