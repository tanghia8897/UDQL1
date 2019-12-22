namespace fmPhanQuyen.GUI
{
    partial class frmThemNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNguoiDung));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.checkQuanLi = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtXacNhan = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbVaiTro = new System.Windows.Forms.ComboBox();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkQuanLi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.checkQuanLi);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDong);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLuu);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(347, 299);
            this.splitContainerControl1.SplitterPosition = 180;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(74, 67);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(214, 67);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(124, 23);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // checkQuanLi
            // 
            this.checkQuanLi.Location = new System.Drawing.Point(70, 14);
            this.checkQuanLi.Name = "checkQuanLi";
            this.checkQuanLi.Properties.Caption = "Còn quản lí";
            this.checkQuanLi.Size = new System.Drawing.Size(75, 19);
            this.checkQuanLi.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 180);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin bắt buộc";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbVaiTro);
            this.layoutControl1.Controls.Add(this.txtXacNhan);
            this.layoutControl1.Controls.Add(this.txtMatKhau);
            this.layoutControl1.Controls.Add(this.txtTaiKhoan);
            this.layoutControl1.Controls.Add(this.txtTenNV);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(343, 158);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(343, 158);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(323, 17);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(68, 29);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(263, 20);
            this.txtTenNV.StyleController = this.layoutControl1;
            this.txtTenNV.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenNV;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(323, 24);
            this.layoutControlItem2.Text = "Nhân viên:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(68, 53);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(263, 20);
            this.txtTaiKhoan.StyleController = this.layoutControl1;
            this.txtTaiKhoan.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTaiKhoan;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(323, 24);
            this.layoutControlItem3.Text = "Tài khoản:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 13);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(68, 77);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(263, 20);
            this.txtMatKhau.StyleController = this.layoutControl1;
            this.txtMatKhau.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMatKhau;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(323, 24);
            this.layoutControlItem4.Text = "Mật khẩu:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 13);
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Location = new System.Drawing.Point(68, 101);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Size = new System.Drawing.Size(263, 20);
            this.txtXacNhan.StyleController = this.layoutControl1;
            this.txtXacNhan.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtXacNhan;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 89);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(323, 24);
            this.layoutControlItem5.Text = "Xác nhận:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 13);
            // 
            // cbVaiTro
            // 
            this.cbVaiTro.FormattingEnabled = true;
            this.cbVaiTro.Location = new System.Drawing.Point(68, 125);
            this.cbVaiTro.Name = "cbVaiTro";
            this.cbVaiTro.Size = new System.Drawing.Size(263, 21);
            this.cbVaiTro.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbVaiTro;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 113);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(323, 25);
            this.layoutControlItem6.Text = "Vai trò:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 13);
            // 
            // frmThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 299);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Người Dùng";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkQuanLi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtXacNhan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.CheckEdit checkQuanLi;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.ComboBox cbVaiTro;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}