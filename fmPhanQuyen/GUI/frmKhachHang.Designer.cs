namespace fmPhanQuyen.GUI
{
    partial class frmKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLienHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Website = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSoThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Nhập";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Xuất";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(602, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 240);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(602, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 214);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(602, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 214);
            // 
            // gridKhachHang
            // 
            this.gridKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKhachHang.Location = new System.Drawing.Point(0, 26);
            this.gridKhachHang.MainView = this.gridView1;
            this.gridKhachHang.MenuManager = this.barManager1;
            this.gridKhachHang.Name = "gridKhachHang";
            this.gridKhachHang.Size = new System.Drawing.Size(602, 214);
            this.gridKhachHang.TabIndex = 4;
            this.gridKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKH,
            this.TenKH,
            this.NguoiLienHe,
            this.DiaChi,
            this.DienThoai,
            this.DiDong,
            this.Fax,
            this.Email,
            this.Website,
            this.MaSoThue,
            this.TenNganHang,
            this.ConQuanLy,
            this.MaKhuVuc,
            this.SoTaiKhoan});
            this.gridView1.GridControl = this.gridKhachHang;
            this.gridView1.Name = "gridView1";
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Mã khách hàng";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 0;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Tên khách hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            // 
            // NguoiLienHe
            // 
            this.NguoiLienHe.Caption = "Người liên hệ";
            this.NguoiLienHe.FieldName = "NguoiLienHe";
            this.NguoiLienHe.Name = "NguoiLienHe";
            this.NguoiLienHe.Visible = true;
            this.NguoiLienHe.VisibleIndex = 2;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "Điện thoại";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 4;
            // 
            // DiDong
            // 
            this.DiDong.Caption = "Di động";
            this.DiDong.FieldName = "DiDong";
            this.DiDong.Name = "DiDong";
            this.DiDong.Visible = true;
            this.DiDong.VisibleIndex = 5;
            // 
            // Fax
            // 
            this.Fax.Caption = "Fax";
            this.Fax.FieldName = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.Visible = true;
            this.Fax.VisibleIndex = 6;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 7;
            // 
            // Website
            // 
            this.Website.Caption = "Website";
            this.Website.FieldName = "Website";
            this.Website.Name = "Website";
            this.Website.Visible = true;
            this.Website.VisibleIndex = 8;
            // 
            // MaSoThue
            // 
            this.MaSoThue.Caption = "Mã số thuế";
            this.MaSoThue.FieldName = "MaSoThue";
            this.MaSoThue.Name = "MaSoThue";
            this.MaSoThue.Visible = true;
            this.MaSoThue.VisibleIndex = 9;
            // 
            // TenNganHang
            // 
            this.TenNganHang.Caption = "Tên ngân hàng";
            this.TenNganHang.FieldName = "TenNganHang";
            this.TenNganHang.Name = "TenNganHang";
            this.TenNganHang.Visible = true;
            this.TenNganHang.VisibleIndex = 10;
            // 
            // ConQuanLy
            // 
            this.ConQuanLy.Caption = "Còn quản lý";
            this.ConQuanLy.FieldName = "ConQuanLy";
            this.ConQuanLy.Name = "ConQuanLy";
            this.ConQuanLy.Visible = true;
            this.ConQuanLy.VisibleIndex = 11;
            // 
            // MaKhuVuc
            // 
            this.MaKhuVuc.Caption = "Mã khu vực";
            this.MaKhuVuc.FieldName = "MaKhuVuc";
            this.MaKhuVuc.Name = "MaKhuVuc";
            this.MaKhuVuc.Visible = true;
            this.MaKhuVuc.VisibleIndex = 12;
            // 
            // SoTaiKhoan
            // 
            this.SoTaiKhoan.Caption = "Số tài khoản";
            this.SoTaiKhoan.FieldName = "SoTaiKhoan";
            this.SoTaiKhoan.Name = "SoTaiKhoan";
            this.SoTaiKhoan.Visible = true;
            this.SoTaiKhoan.VisibleIndex = 13;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 240);
            this.Controls.Add(this.gridKhachHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraGrid.GridControl gridKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLienHe;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn DiDong;
        private DevExpress.XtraGrid.Columns.GridColumn Fax;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Website;
        private DevExpress.XtraGrid.Columns.GridColumn MaSoThue;
        private DevExpress.XtraGrid.Columns.GridColumn TenNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn ConQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn SoTaiKhoan;



    }
}