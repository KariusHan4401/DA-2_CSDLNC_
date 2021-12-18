
namespace QuanLyHoaDon
{
    partial class menuThemHD
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
            this.buttonThemHD = new System.Windows.Forms.Button();
            this.buttonThemCTHD = new System.Windows.Forms.Button();
            this.panelMenuThemHD = new System.Windows.Forms.Panel();
            this.panelMenuThemHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThemHD
            // 
            this.buttonThemHD.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThemHD.Location = new System.Drawing.Point(54, 53);
            this.buttonThemHD.Name = "buttonThemHD";
            this.buttonThemHD.Size = new System.Drawing.Size(491, 92);
            this.buttonThemHD.TabIndex = 0;
            this.buttonThemHD.Text = "THÊM HÓA ĐƠN";
            this.buttonThemHD.UseVisualStyleBackColor = true;
            this.buttonThemHD.Click += new System.EventHandler(this.buttonThemHD_Click);
            // 
            // buttonThemCTHD
            // 
            this.buttonThemCTHD.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThemCTHD.Location = new System.Drawing.Point(54, 202);
            this.buttonThemCTHD.Name = "buttonThemCTHD";
            this.buttonThemCTHD.Size = new System.Drawing.Size(491, 92);
            this.buttonThemCTHD.TabIndex = 1;
            this.buttonThemCTHD.Text = "THÊM CHI TIẾT HÓA ĐƠN";
            this.buttonThemCTHD.UseVisualStyleBackColor = true;
            this.buttonThemCTHD.Click += new System.EventHandler(this.buttonThemCTHD_Click);
            // 
            // panelMenuThemHD
            // 
            this.panelMenuThemHD.Controls.Add(this.buttonThemCTHD);
            this.panelMenuThemHD.Controls.Add(this.buttonThemHD);
            this.panelMenuThemHD.Location = new System.Drawing.Point(120, 83);
            this.panelMenuThemHD.Name = "panelMenuThemHD";
            this.panelMenuThemHD.Size = new System.Drawing.Size(607, 376);
            this.panelMenuThemHD.TabIndex = 2;
            // 
            // menuThemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenuThemHD);
            this.Name = "menuThemHD";
            this.Size = new System.Drawing.Size(784, 579);
            this.panelMenuThemHD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonThemHD;
        private System.Windows.Forms.Button buttonThemCTHD;
        private System.Windows.Forms.Panel panelMenuThemHD;
    }
}
