
namespace QUANLYCONCUNG
{
    partial class ThemLH
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
            this.tenLH = new System.Windows.Forms.Label();
            this.showLH = new System.Windows.Forms.DataGridView();
            this.btnThemLH = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textTenLH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showLH)).BeginInit();
            this.SuspendLayout();
            // 
            // tenLH
            // 
            this.tenLH.AutoSize = true;
            this.tenLH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tenLH.Location = new System.Drawing.Point(128, 27);
            this.tenLH.Name = "tenLH";
            this.tenLH.Size = new System.Drawing.Size(139, 28);
            this.tenLH.TabIndex = 0;
            this.tenLH.Text = "Tên loại hàng";
            // 
            // showLH
            // 
            this.showLH.BackgroundColor = System.Drawing.Color.White;
            this.showLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showLH.Location = new System.Drawing.Point(128, 116);
            this.showLH.Name = "showLH";
            this.showLH.RowHeadersWidth = 51;
            this.showLH.RowTemplate.Height = 29;
            this.showLH.Size = new System.Drawing.Size(554, 295);
            this.showLH.TabIndex = 1;
            // 
            // btnThemLH
            // 
            this.btnThemLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThemLH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemLH.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemLH.Location = new System.Drawing.Point(416, 64);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(134, 41);
            this.btnThemLH.TabIndex = 2;
            this.btnThemLH.Text = "Thêm";
            this.btnThemLH.UseVisualStyleBackColor = false;
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(557, 417);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 38);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textTenLH
            // 
            this.textTenLH.Location = new System.Drawing.Point(273, 31);
            this.textTenLH.Name = "textTenLH";
            this.textTenLH.Size = new System.Drawing.Size(409, 27);
            this.textTenLH.TabIndex = 4;
            // 
            // ThemLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.textTenLH);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnThemLH);
            this.Controls.Add(this.showLH);
            this.Controls.Add(this.tenLH);
            this.Name = "ThemLH";
            this.Size = new System.Drawing.Size(810, 480);
            this.Load += new System.EventHandler(this.ThemLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tenLH;
        private System.Windows.Forms.DataGridView showLH;
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textTenLH;
    }
}
