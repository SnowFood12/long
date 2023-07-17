namespace asm_DangKi
{
    partial class frm_SanPham
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ThemSanPham = new System.Windows.Forms.Button();
            this.dtm_NgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.dtm_HanSuDung = new System.Windows.Forms.DateTimePicker();
            this.dtm_NgayNhapKho = new System.Windows.Forms.DateTimePicker();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DachSanPham = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1367, 708);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_ThemSanPham);
            this.tabPage1.Controls.Add(this.dtm_NgaySanXuat);
            this.tabPage1.Controls.Add(this.dtm_HanSuDung);
            this.tabPage1.Controls.Add(this.dtm_NgayNhapKho);
            this.tabPage1.Controls.Add(this.txt_GiaTien);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_SoLuong);
            this.tabPage1.Controls.Add(this.txt_TenSanPham);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_MaSanPham);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_DachSanPham);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1359, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_ThemSanPham
            // 
            this.btn_ThemSanPham.Location = new System.Drawing.Point(922, 569);
            this.btn_ThemSanPham.Name = "btn_ThemSanPham";
            this.btn_ThemSanPham.Size = new System.Drawing.Size(257, 43);
            this.btn_ThemSanPham.TabIndex = 4;
            this.btn_ThemSanPham.Text = "Thêm sản phẩm";
            this.btn_ThemSanPham.UseVisualStyleBackColor = true;
            this.btn_ThemSanPham.Click += new System.EventHandler(this.btn_ThemSanPham_Click);
            // 
            // dtm_NgaySanXuat
            // 
            this.dtm_NgaySanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_NgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_NgaySanXuat.Location = new System.Drawing.Point(1002, 340);
            this.dtm_NgaySanXuat.Name = "dtm_NgaySanXuat";
            this.dtm_NgaySanXuat.Size = new System.Drawing.Size(177, 32);
            this.dtm_NgaySanXuat.TabIndex = 3;
            // 
            // dtm_HanSuDung
            // 
            this.dtm_HanSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_HanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_HanSuDung.Location = new System.Drawing.Point(1002, 492);
            this.dtm_HanSuDung.Name = "dtm_HanSuDung";
            this.dtm_HanSuDung.Size = new System.Drawing.Size(177, 32);
            this.dtm_HanSuDung.TabIndex = 3;
            // 
            // dtm_NgayNhapKho
            // 
            this.dtm_NgayNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_NgayNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_NgayNhapKho.Location = new System.Drawing.Point(1002, 414);
            this.dtm_NgayNhapKho.Name = "dtm_NgayNhapKho";
            this.dtm_NgayNhapKho.Size = new System.Drawing.Size(177, 32);
            this.dtm_NgayNhapKho.TabIndex = 3;
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaTien.Location = new System.Drawing.Point(299, 545);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(297, 32);
            this.txt_GiaTien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá tiền";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(299, 481);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(297, 32);
            this.txt_SoLuong.TabIndex = 2;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(299, 417);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(297, 32);
            this.txt_TenSanPham.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(779, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hạn sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSanPham.Location = new System.Drawing.Point(299, 340);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(297, 32);
            this.txt_MaSanPham.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(779, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(779, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày nhập kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // dgv_DachSanPham
            // 
            this.dgv_DachSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.GiaBan,
            this.SoLuong,
            this.NgayNhapKho,
            this.HanSuDung,
            this.NgaySanXuat});
            this.dgv_DachSanPham.Location = new System.Drawing.Point(8, 6);
            this.dgv_DachSanPham.Name = "dgv_DachSanPham";
            this.dgv_DachSanPham.ReadOnly = true;
            this.dgv_DachSanPham.RowHeadersWidth = 51;
            this.dgv_DachSanPham.RowTemplate.Height = 24;
            this.dgv_DachSanPham.Size = new System.Drawing.Size(1343, 288);
            this.dgv_DachSanPham.TabIndex = 0;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            this.MaSanPham.Width = 125;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            this.TenSanPham.Width = 125;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // NgayNhapKho
            // 
            this.NgayNhapKho.DataPropertyName = "NgayNhapKho";
            this.NgayNhapKho.HeaderText = "Ngày nhập kho";
            this.NgayNhapKho.MinimumWidth = 6;
            this.NgayNhapKho.Name = "NgayNhapKho";
            this.NgayNhapKho.ReadOnly = true;
            this.NgayNhapKho.Width = 125;
            // 
            // HanSuDung
            // 
            this.HanSuDung.DataPropertyName = "HanSuDung";
            this.HanSuDung.HeaderText = "Hạn sử dụng";
            this.HanSuDung.MinimumWidth = 6;
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.ReadOnly = true;
            this.HanSuDung.Width = 125;
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.DataPropertyName = "NgaySanXuat";
            this.NgaySanXuat.HeaderText = "Ngày sản xuất";
            this.NgaySanXuat.MinimumWidth = 6;
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.ReadOnly = true;
            this.NgaySanXuat.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1359, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 708);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SanPham";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DachSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtm_NgaySanXuat;
        private System.Windows.Forms.DateTimePicker dtm_HanSuDung;
        private System.Windows.Forms.DateTimePicker dtm_NgayNhapKho;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DachSanPham;
        private System.Windows.Forms.Button btn_ThemSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySanXuat;
    }
}