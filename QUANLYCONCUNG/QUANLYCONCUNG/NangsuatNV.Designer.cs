
namespace QUANLYCONCUNG
{
    partial class NangsuatNV
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
            this.gridViewNangSuat = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNangSuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "NĂNG SUẤT LÀM VIỆC";
            // 
            // gridViewNangSuat
            // 
            this.gridViewNangSuat.AllowUserToAddRows = false;
            this.gridViewNangSuat.AllowUserToDeleteRows = false;
            this.gridViewNangSuat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridViewNangSuat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewNangSuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewNangSuat.Location = new System.Drawing.Point(39, 148);
            this.gridViewNangSuat.Name = "gridViewNangSuat";
            this.gridViewNangSuat.ReadOnly = true;
            this.gridViewNangSuat.RowHeadersWidth = 51;
            this.gridViewNangSuat.RowTemplate.Height = 29;
            this.gridViewNangSuat.Size = new System.Drawing.Size(961, 337);
            this.gridViewNangSuat.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(601, 109);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(244, 27);
            this.txtTen.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(863, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm theo tên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NangsuatNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewNangSuat);
            this.Name = "NangsuatNV";
            this.Size = new System.Drawing.Size(1041, 497);
            this.Load += new System.EventHandler(this.NangsuatNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNangSuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewNangSuat;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button button1;
    }
}
