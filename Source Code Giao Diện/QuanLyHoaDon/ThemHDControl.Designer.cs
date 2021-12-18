
namespace QuanLyHoaDon
{
    partial class ThemHDControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHDControl));
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNgay = new System.Windows.Forms.DateTimePicker();
            this.buttonTaoHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxMaKH
            // 
            resources.ApplyResources(this.textBoxMaKH, "textBoxMaKH");
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.TextChanged += new System.EventHandler(this.textBoxMaKH_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerNgay
            // 
            resources.ApplyResources(this.dateTimePickerNgay, "dateTimePickerNgay");
            this.dateTimePickerNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgay.MaxDate = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 0, 0, 0, 0);
            //this.dateTimePickerNgay.MinDate = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dateTimePickerNgay.Name = "dateTimePickerNgay";
            this.dateTimePickerNgay.Value = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 0, 0, 0, 0);

            // 
            // buttonTaoHD
            // 
            this.buttonTaoHD.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.buttonTaoHD, "buttonTaoHD");
            this.buttonTaoHD.Name = "buttonTaoHD";
            this.buttonTaoHD.UseVisualStyleBackColor = false;
            this.buttonTaoHD.Click += new System.EventHandler(this.buttonTaoHD_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxMaHD
            // 
            resources.ApplyResources(this.textBoxMaHD, "textBoxMaHD");
            this.textBoxMaHD.Name = "textBoxMaHD";
            // 
            // ThemHDControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTaoHD);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.dateTimePickerNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Name = "ThemHDControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgay;
        private System.Windows.Forms.Button buttonTaoHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaHD;
    }
}
