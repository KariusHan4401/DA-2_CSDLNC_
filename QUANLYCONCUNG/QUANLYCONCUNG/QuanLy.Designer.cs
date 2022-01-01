
namespace QUANLYCONCUNG
{
    partial class QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.btnQLSP = new System.Windows.Forms.Button();
            this.panelQL = new System.Windows.Forms.Panel();
            this.pictureBoxCC = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateLH = new System.Windows.Forms.Button();
            this.btnXoaLH = new System.Windows.Forms.Button();
            this.btnThemLH = new System.Windows.Forms.Button();
            this.btnQLLH = new System.Windows.Forms.Button();
            this.btnCapNhatSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.intro = new System.Windows.Forms.Label();
            this.panelQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQLSP
            // 
            this.btnQLSP.BackColor = System.Drawing.Color.White;
            this.btnQLSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQLSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQLSP.Location = new System.Drawing.Point(10, 18);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(192, 56);
            this.btnQLSP.TabIndex = 0;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.UseVisualStyleBackColor = false;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // panelQL
            // 
            this.panelQL.Controls.Add(this.pictureBoxCC);
            this.panelQL.Location = new System.Drawing.Point(219, 167);
            this.panelQL.Name = "panelQL";
            this.panelQL.Size = new System.Drawing.Size(965, 466);
            this.panelQL.TabIndex = 1;
            // 
            // pictureBoxCC
            // 
            this.pictureBoxCC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCC.Image")));
            this.pictureBoxCC.InitialImage = null;
            this.pictureBoxCC.Location = new System.Drawing.Point(30, -162);
            this.pictureBoxCC.Name = "pictureBoxCC";
            this.pictureBoxCC.Size = new System.Drawing.Size(765, 668);
            this.pictureBoxCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCC.TabIndex = 1;
            this.pictureBoxCC.TabStop = false;
            this.pictureBoxCC.Click += new System.EventHandler(this.pictureBoxCC_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateLH);
            this.panel1.Controls.Add(this.btnXoaLH);
            this.panel1.Controls.Add(this.btnThemLH);
            this.panel1.Controls.Add(this.btnQLLH);
            this.panel1.Controls.Add(this.btnCapNhatSP);
            this.panel1.Controls.Add(this.btnXoaSP);
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.btnQLSP);
            this.panel1.Location = new System.Drawing.Point(3, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 466);
            this.panel1.TabIndex = 2;
            // 
            // btnUpdateLH
            // 
            this.btnUpdateLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateLH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateLH.Location = new System.Drawing.Point(23, 348);
            this.btnUpdateLH.Name = "btnUpdateLH";
            this.btnUpdateLH.Size = new System.Drawing.Size(172, 31);
            this.btnUpdateLH.TabIndex = 10;
            this.btnUpdateLH.Text = "Cập nhật loại hàng";
            this.btnUpdateLH.UseVisualStyleBackColor = false;
            this.btnUpdateLH.Click += new System.EventHandler(this.btnUpdateLH_Click);
            // 
            // btnXoaLH
            // 
            this.btnXoaLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaLH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaLH.Location = new System.Drawing.Point(23, 309);
            this.btnXoaLH.Name = "btnXoaLH";
            this.btnXoaLH.Size = new System.Drawing.Size(172, 33);
            this.btnXoaLH.TabIndex = 9;
            this.btnXoaLH.Text = "Xóa loại hàng";
            this.btnXoaLH.UseVisualStyleBackColor = false;
            this.btnXoaLH.Click += new System.EventHandler(this.btnXoaLH_Click);
            // 
            // btnThemLH
            // 
            this.btnThemLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemLH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemLH.FlatAppearance.BorderSize = 0;
            this.btnThemLH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemLH.Location = new System.Drawing.Point(23, 267);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(172, 36);
            this.btnThemLH.TabIndex = 8;
            this.btnThemLH.Text = "Thêm loại hàng";
            this.btnThemLH.UseVisualStyleBackColor = false;
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            // 
            // btnQLLH
            // 
            this.btnQLLH.BackColor = System.Drawing.Color.White;
            this.btnQLLH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQLLH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQLLH.Location = new System.Drawing.Point(9, 205);
            this.btnQLLH.Name = "btnQLLH";
            this.btnQLLH.Size = new System.Drawing.Size(192, 56);
            this.btnQLLH.TabIndex = 7;
            this.btnQLLH.Text = "Quản lý loại hàng";
            this.btnQLLH.UseVisualStyleBackColor = false;
            this.btnQLLH.Click += new System.EventHandler(this.btnQLLH_Click);
            // 
            // btnCapNhatSP
            // 
            this.btnCapNhatSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapNhatSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhatSP.Location = new System.Drawing.Point(23, 161);
            this.btnCapNhatSP.Name = "btnCapNhatSP";
            this.btnCapNhatSP.Size = new System.Drawing.Size(172, 31);
            this.btnCapNhatSP.TabIndex = 6;
            this.btnCapNhatSP.Text = "Cập nhật sản phẩm";
            this.btnCapNhatSP.UseVisualStyleBackColor = false;
            this.btnCapNhatSP.Click += new System.EventHandler(this.btnCapNhatSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaSP.ForeColor = System.Drawing.Color.Black;
            this.btnXoaSP.Location = new System.Drawing.Point(23, 122);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(172, 33);
            this.btnXoaSP.TabIndex = 5;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemSP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemSP.ForeColor = System.Drawing.Color.Black;
            this.btnThemSP.Location = new System.Drawing.Point(23, 80);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(172, 36);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // intro
            // 
            this.intro.AutoSize = true;
            this.intro.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.intro.ForeColor = System.Drawing.Color.Transparent;
            this.intro.Location = new System.Drawing.Point(385, 50);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(391, 59);
            this.intro.TabIndex = 3;
            this.intro.Text = "Danh mục quản lý";
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.intro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelQL);
            this.Name = "QuanLy";
            this.Size = new System.Drawing.Size(1184, 753);
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.panelQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Panel panelQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapNhatSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnUpdateLH;
        private System.Windows.Forms.Button btnXoaLH;
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.Button btnQLLH;
        private System.Windows.Forms.Label intro;
        private System.Windows.Forms.PictureBox pictureBoxCC;
    }
}
