namespace Baitaptuan4
{
    partial class FormTongHop
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
            this.btnQuanLySP = new System.Windows.Forms.Button();
            this.btnPhanTrang = new System.Windows.Forms.Button();
            this.LocSanPham = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXemDMSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLySP
            // 
            this.btnQuanLySP.Location = new System.Drawing.Point(78, 49);
            this.btnQuanLySP.Name = "btnQuanLySP";
            this.btnQuanLySP.Size = new System.Drawing.Size(167, 39);
            this.btnQuanLySP.TabIndex = 1;
            this.btnQuanLySP.Text = "Quản lý sản phẩm";
            this.btnQuanLySP.UseVisualStyleBackColor = true;
            this.btnQuanLySP.Click += new System.EventHandler(this.btnQuanLySP_Click);
            // 
            // btnPhanTrang
            // 
            this.btnPhanTrang.Location = new System.Drawing.Point(304, 49);
            this.btnPhanTrang.Name = "btnPhanTrang";
            this.btnPhanTrang.Size = new System.Drawing.Size(155, 39);
            this.btnPhanTrang.TabIndex = 2;
            this.btnPhanTrang.Text = "Phân Trang";
            this.btnPhanTrang.UseVisualStyleBackColor = true;
            this.btnPhanTrang.Click += new System.EventHandler(this.btnPhanTrang_Click);
            // 
            // LocSanPham
            // 
            this.LocSanPham.Location = new System.Drawing.Point(527, 49);
            this.LocSanPham.Name = "LocSanPham";
            this.LocSanPham.Size = new System.Drawing.Size(155, 39);
            this.LocSanPham.TabIndex = 3;
            this.LocSanPham.Text = "Lọc sản phẩm";
            this.LocSanPham.UseVisualStyleBackColor = true;
            this.LocSanPham.Click += new System.EventHandler(this.LocSanPham_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(195, 106);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(155, 39);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm sản phẩm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXemDMSP
            // 
            this.btnXemDMSP.Location = new System.Drawing.Point(390, 106);
            this.btnXemDMSP.Name = "btnXemDMSP";
            this.btnXemDMSP.Size = new System.Drawing.Size(188, 39);
            this.btnXemDMSP.TabIndex = 5;
            this.btnXemDMSP.Text = "Xem danh mục sản phẩm";
            this.btnXemDMSP.UseVisualStyleBackColor = true;
            this.btnXemDMSP.Click += new System.EventHandler(this.btnXemDMSP_Click);
            // 
            // FormTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXemDMSP);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.LocSanPham);
            this.Controls.Add(this.btnPhanTrang);
            this.Controls.Add(this.btnQuanLySP);
            this.IsMdiContainer = true;
            this.Name = "FormTongHop";
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLySP;
        private System.Windows.Forms.Button btnPhanTrang;
        private System.Windows.Forms.Button LocSanPham;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXemDMSP;
    }
}