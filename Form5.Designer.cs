namespace Baitaptuan4
{
    partial class Form5
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
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.btLoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn loại sản phẩm";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(207, 49);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(263, 24);
            this.cboLoaiSP.TabIndex = 1;
            // 
            // btLoc
            // 
            this.btLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoc.Location = new System.Drawing.Point(509, 36);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(75, 46);
            this.btLoc.TabIndex = 2;
            this.btLoc.Text = "Lọc";
            this.btLoc.UseVisualStyleBackColor = true;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả";
            // 
            // dgSanPham
            // 
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Location = new System.Drawing.Point(12, 129);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.RowHeadersWidth = 51;
            this.dgSanPham.RowTemplate.Height = 24;
            this.dgSanPham.Size = new System.Drawing.Size(776, 309);
            this.dgSanPham.TabIndex = 4;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLoc);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Button btLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgSanPham;
    }
}