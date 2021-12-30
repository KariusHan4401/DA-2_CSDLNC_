
namespace QUANLYCONCUNG
{
    partial class CapNhatLH
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
            this.cbMALH = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.maLH = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.showLH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tenLH = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showLH)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMALH
            // 
            this.cbMALH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMALH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMALH.DropDownHeight = 100;
            this.cbMALH.FormattingEnabled = true;
            this.cbMALH.IntegralHeight = false;
            this.cbMALH.ItemHeight = 20;
            this.cbMALH.Location = new System.Drawing.Point(327, 28);
            this.cbMALH.Name = "cbMALH";
            this.cbMALH.Size = new System.Drawing.Size(205, 28);
            this.cbMALH.TabIndex = 23;
            this.cbMALH.SelectedIndexChanged += new System.EventHandler(this.cbMALH_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(554, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 37);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // maLH
            // 
            this.maLH.AutoSize = true;
            this.maLH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maLH.Location = new System.Drawing.Point(128, 28);
            this.maLH.Name = "maLH";
            this.maLH.Size = new System.Drawing.Size(136, 28);
            this.maLH.TabIndex = 21;
            this.maLH.Text = "Mã loại hàng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(557, 407);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 38);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // showLH
            // 
            this.showLH.BackgroundColor = System.Drawing.Color.White;
            this.showLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showLH.Location = new System.Drawing.Point(128, 162);
            this.showLH.Name = "showLH";
            this.showLH.RowHeadersWidth = 51;
            this.showLH.RowTemplate.Height = 29;
            this.showLH.Size = new System.Drawing.Size(554, 239);
            this.showLH.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên loại hàng";
            // 
            // tenLH
            // 
            this.tenLH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenLH.Location = new System.Drawing.Point(327, 78);
            this.tenLH.Name = "tenLH";
            this.tenLH.Size = new System.Drawing.Size(355, 27);
            this.tenLH.TabIndex = 25;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.Location = new System.Drawing.Point(327, 114);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(128, 37);
            this.btnTim.TabIndex = 26;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheck.Location = new System.Drawing.Point(557, 24);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(128, 37);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // CapNhatLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.tenLH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMALH);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.maLH);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.showLH);
            this.Name = "CapNhatLH";
            this.Size = new System.Drawing.Size(817, 521);
            this.Load += new System.EventHandler(this.CapNhatLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMALH;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label maLH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView showLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenLH;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnCheck;
    }
}
