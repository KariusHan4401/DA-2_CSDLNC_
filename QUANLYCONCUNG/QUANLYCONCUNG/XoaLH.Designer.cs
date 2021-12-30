
namespace QUANLYCONCUNG
{
    partial class XoaLH
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
            this.showLH = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.maLH = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbMALH = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showLH)).BeginInit();
            this.SuspendLayout();
            // 
            // showLH
            // 
            this.showLH.BackgroundColor = System.Drawing.Color.White;
            this.showLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showLH.Location = new System.Drawing.Point(128, 115);
            this.showLH.Name = "showLH";
            this.showLH.RowHeadersWidth = 51;
            this.showLH.RowTemplate.Height = 29;
            this.showLH.Size = new System.Drawing.Size(554, 295);
            this.showLH.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(557, 418);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 38);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // maLH
            // 
            this.maLH.AutoSize = true;
            this.maLH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maLH.Location = new System.Drawing.Point(128, 44);
            this.maLH.Name = "maLH";
            this.maLH.Size = new System.Drawing.Size(136, 28);
            this.maLH.TabIndex = 5;
            this.maLH.Text = "Mã loại hàng";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(501, 72);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 37);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbMALH
            // 
            this.cbMALH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMALH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMALH.DropDownHeight = 100;
            this.cbMALH.FormattingEnabled = true;
            this.cbMALH.IntegralHeight = false;
            this.cbMALH.ItemHeight = 20;
            this.cbMALH.Location = new System.Drawing.Point(280, 44);
            this.cbMALH.Name = "cbMALH";
            this.cbMALH.Size = new System.Drawing.Size(205, 28);
            this.cbMALH.TabIndex = 10;
            this.cbMALH.SelectedIndexChanged += new System.EventHandler(this.cbMALH_SelectedIndexChanged);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.Location = new System.Drawing.Point(501, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(128, 37);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // XoaLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbMALH);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.maLH);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.showLH);
            this.Name = "XoaLH";
            this.Size = new System.Drawing.Size(810, 480);
            this.Load += new System.EventHandler(this.XoaLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showLH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label maLH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbMALH;
        private System.Windows.Forms.Button btnTim;
    }
}
