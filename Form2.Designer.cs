namespace Baitaptuan4
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(154, 98);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(203, 24);
            this.cboSanPham.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(399, 98);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(550, 295);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSanPham);
            this.Name = "Form2";
            this.Text = "Đưa dữ liệu lên ComboBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}