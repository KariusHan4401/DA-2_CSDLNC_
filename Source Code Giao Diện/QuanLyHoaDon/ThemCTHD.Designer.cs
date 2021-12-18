
namespace QuanLyHoaDon
{
    partial class ThemCTHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownSlg = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownGiaGiam = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThemCTHD = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlg)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaGiam)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaBan)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm chi tiết hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownSlg);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(102, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 58);
            this.panel2.TabIndex = 4;
            // 
            // numericUpDownSlg
            // 
            this.numericUpDownSlg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSlg.Location = new System.Drawing.Point(191, 12);
            this.numericUpDownSlg.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownSlg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSlg.Name = "numericUpDownSlg";
            this.numericUpDownSlg.Size = new System.Drawing.Size(262, 34);
            this.numericUpDownSlg.TabIndex = 2;
            this.numericUpDownSlg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDownGiaGiam);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(102, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 51);
            this.panel4.TabIndex = 5;
            // 
            // numericUpDownGiaGiam
            // 
            this.numericUpDownGiaGiam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownGiaGiam.Location = new System.Drawing.Point(191, 9);
            this.numericUpDownGiaGiam.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownGiaGiam.Name = "numericUpDownGiaGiam";
            this.numericUpDownGiaGiam.Size = new System.Drawing.Size(261, 34);
            this.numericUpDownGiaGiam.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giá giảm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMaSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(102, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 58);
            this.panel1.TabIndex = 3;
            // 
            // textBoxMaSP
            // 
            this.textBoxMaSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaSP.Location = new System.Drawing.Point(191, 12);
            this.textBoxMaSP.Name = "textBoxMaSP";
            this.textBoxMaSP.Size = new System.Drawing.Size(262, 34);
            this.textBoxMaSP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDownGiaBan);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(102, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 51);
            this.panel3.TabIndex = 4;
            // 
            // numericUpDownGiaBan
            // 
            this.numericUpDownGiaBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownGiaBan.Location = new System.Drawing.Point(192, 10);
            this.numericUpDownGiaBan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownGiaBan.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownGiaBan.Name = "numericUpDownGiaBan";
            this.numericUpDownGiaBan.Size = new System.Drawing.Size(261, 34);
            this.numericUpDownGiaBan.TabIndex = 3;
            this.numericUpDownGiaBan.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá bán:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonThemCTHD
            // 
            this.buttonThemCTHD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonThemCTHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonThemCTHD.Location = new System.Drawing.Point(293, 335);
            this.buttonThemCTHD.Name = "buttonThemCTHD";
            this.buttonThemCTHD.Size = new System.Drawing.Size(113, 38);
            this.buttonThemCTHD.TabIndex = 6;
            this.buttonThemCTHD.Text = "Thêm";
            this.buttonThemCTHD.UseVisualStyleBackColor = false;
            this.buttonThemCTHD.Click += new System.EventHandler(this.buttonThemCTHD_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxMaHD);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(102, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 57);
            this.panel6.TabIndex = 6;
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaHD.Location = new System.Drawing.Point(191, 12);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(262, 34);
            this.textBoxMaHD.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.buttonThemCTHD);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(642, 507);
            this.panel5.TabIndex = 7;
            // 
            // ThemCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemCTHD";
            this.Size = new System.Drawing.Size(648, 555);
            this.Load += new System.EventHandler(this.ThemCTHD_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlg)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaGiam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiaBan)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownSlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDownGiaGiam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThemCTHD;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
    }
}
