
namespace QUANLYCONCUNG
{
    partial class ProductItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_love = new System.Windows.Forms.Label();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lbl_Price);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pic_product);
            this.panel1.Location = new System.Drawing.Point(23, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 329);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(45, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 32);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Chọn mua";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Price.Location = new System.Drawing.Point(32, 211);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(145, 31);
            this.lbl_Price.TabIndex = 20;
            this.lbl_Price.Text = "đ149.000";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(10, 147);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(192, 60);
            this.lbl_name.TabIndex = 19;
            this.lbl_name.Text = "Dép sục con bò cười";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_comment);
            this.panel2.Location = new System.Drawing.Point(9, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 39);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QUANLYCONCUNG.Properties.Resources.speech_bubble1;
            this.panel3.Location = new System.Drawing.Point(1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 36);
            this.panel3.TabIndex = 6;
            // 
            // lbl_comment
            // 
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Location = new System.Drawing.Point(46, 9);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(17, 20);
            this.lbl_comment.TabIndex = 5;
            this.lbl_comment.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lbl_love);
            this.panel4.Location = new System.Drawing.Point(107, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(94, 39);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::QUANLYCONCUNG.Properties.Resources.love;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 33);
            this.panel5.TabIndex = 8;
            // 
            // lbl_love
            // 
            this.lbl_love.AutoSize = true;
            this.lbl_love.Location = new System.Drawing.Point(53, 8);
            this.lbl_love.Name = "lbl_love";
            this.lbl_love.Size = new System.Drawing.Size(17, 20);
            this.lbl_love.TabIndex = 6;
            this.lbl_love.Text = "0";
            // 
            // pic_product
            // 
            this.pic_product.Image = global::QUANLYCONCUNG.Properties.Resources._0fc8bdc48ddac4df48dc75ef6c732ea41;
            this.pic_product.InitialImage = null;
            this.pic_product.Location = new System.Drawing.Point(5, 11);
            this.pic_product.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(207, 127);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_product.TabIndex = 15;
            this.pic_product.TabStop = false;
            this.pic_product.Click += new System.EventHandler(this.pic_product_Click);
            this.pic_product.DoubleClick += new System.EventHandler(this.pic_product_DoubleClick);
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(247, 374);
            this.Load += new System.EventHandler(this.ProductItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_comment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_love;
        private System.Windows.Forms.PictureBox pic_product;
    }
}
