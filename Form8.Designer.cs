namespace Baitaptuan4
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(183, 37);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(276, 22);
            this.txtMaSP.TabIndex = 5;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(183, 70);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(276, 22);
            this.txtTenSP.TabIndex = 6;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(183, 109);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(276, 22);
            this.txtDVT.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(183, 147);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(276, 22);
            this.txtDonGia.TabIndex = 8;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(183, 182);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(276, 24);
            this.cboLoaiSP.TabIndex = 9;
            // 
            // dgSanPham
            // 
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Location = new System.Drawing.Point(12, 230);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.RowHeadersWidth = 51;
            this.dgSanPham.RowTemplate.Height = 24;
            this.dgSanPham.Size = new System.Drawing.Size(776, 208);
            this.dgSanPham.TabIndex = 10;
            this.dgSanPham.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_RowEnter);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(561, 37);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(120, 29);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(561, 76);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(120, 29);
            this.btLuu.TabIndex = 12;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(561, 116);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(120, 29);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(561, 155);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(120, 29);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgSanPham);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "QuanLySanPham_Form";
            this.Load += new System.EventHandler(this.QuanLySanPham_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.DataGridView dgSanPham;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
    }
}