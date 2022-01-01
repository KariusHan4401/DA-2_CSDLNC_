
namespace QUANLYCONCUNG
{
    partial class datagridviewXEMLH
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
            this.dataGridViewLH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tất cả loại hàng:";
            // 
            // dataGridViewLH
            // 
            this.dataGridViewLH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLH.Location = new System.Drawing.Point(109, 44);
            this.dataGridViewLH.Name = "dataGridViewLH";
            this.dataGridViewLH.RowHeadersWidth = 51;
            this.dataGridViewLH.RowTemplate.Height = 29;
            this.dataGridViewLH.Size = new System.Drawing.Size(450, 318);
            this.dataGridViewLH.TabIndex = 2;
            // 
            // datagridviewXEMLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLH);
            this.Name = "datagridviewXEMLH";
            this.Size = new System.Drawing.Size(1018, 590);
            this.Load += new System.EventHandler(this.datagridviewXEMLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLH;
    }
}
