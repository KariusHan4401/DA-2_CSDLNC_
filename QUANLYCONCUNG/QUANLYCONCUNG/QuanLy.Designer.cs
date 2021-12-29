
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
            this.btnQLSP = new System.Windows.Forms.Button();
            this.panelQL = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapNhatSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQLSP
            // 
            this.btnQLSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQLSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQLSP.Location = new System.Drawing.Point(3, 18);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(192, 56);
            this.btnQLSP.TabIndex = 0;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // panelQL
            // 
            this.panelQL.Location = new System.Drawing.Point(219, 108);
            this.panelQL.Name = "panelQL";
            this.panelQL.Size = new System.Drawing.Size(965, 466);
            this.panelQL.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCapNhatSP);
            this.panel1.Controls.Add(this.btnXoaSP);
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.btnQLSP);
            this.panel1.Location = new System.Drawing.Point(3, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 466);
            this.panel1.TabIndex = 2;
            // 
            // btnCapNhatSP
            // 
            this.btnCapNhatSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.btnThemSP.Location = new System.Drawing.Point(23, 80);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(172, 36);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelQL);
            this.Name = "QuanLy";
            this.Size = new System.Drawing.Size(1184, 574);
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Panel panelQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapNhatSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThemSP;
    }
}
