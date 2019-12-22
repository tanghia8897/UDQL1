namespace fmPhanQuyen.GUI
{
    partial class fmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmHangHoa));
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
            this.gridHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhChat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKhoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TonKhoToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangHoa)).BeginInit();
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
            this.btnSua,
            this.btnXoa,
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
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
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
            this.barDockControlTop.Size = new System.Drawing.Size(515, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 202);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(515, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 176);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(515, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 176);
            // 
            // gridHangHoa
            // 
            this.gridHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHangHoa.Location = new System.Drawing.Point(0, 26);
            this.gridHangHoa.MainView = this.gridView1;
            this.gridHangHoa.MenuManager = this.barManager1;
            this.gridHangHoa.Name = "gridHangHoa";
            this.gridHangHoa.Size = new System.Drawing.Size(515, 176);
            this.gridHangHoa.TabIndex = 4;
            this.gridHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHang,
            this.TenHang,
            this.GiaMua,
            this.GiaBanSi,
            this.GiaBanLe,
            this.TinhChat,
            this.ConQuanLy,
            this.MaVach,
            this.MaNhomHang,
            this.MaKhoHang,
            this.MaDonViTinh,
            this.SoLuong,
            this.SoLuongTon,
            this.TonKhoToiThieu,
            this.MaNhaCungCap});
            this.gridView1.GridControl = this.gridHangHoa;
            this.gridView1.Name = "gridView1";
            // 
            // MaHang
            // 
            this.MaHang.Caption = "Mã";
            this.MaHang.FieldName = "MaHang";
            this.MaHang.Name = "MaHang";
            this.MaHang.Visible = true;
            this.MaHang.VisibleIndex = 0;
            // 
            // TenHang
            // 
            this.TenHang.Caption = "Tên";
            this.TenHang.FieldName = "TenHang";
            this.TenHang.Name = "TenHang";
            this.TenHang.Visible = true;
            this.TenHang.VisibleIndex = 1;
            // 
            // GiaMua
            // 
            this.GiaMua.Caption = "Giá mua";
            this.GiaMua.FieldName = "GiaMua";
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.Visible = true;
            this.GiaMua.VisibleIndex = 2;
            // 
            // GiaBanSi
            // 
            this.GiaBanSi.Caption = "Giá bán sỉ";
            this.GiaBanSi.FieldName = "GiaBanSi";
            this.GiaBanSi.Name = "GiaBanSi";
            this.GiaBanSi.Visible = true;
            this.GiaBanSi.VisibleIndex = 3;
            // 
            // GiaBanLe
            // 
            this.GiaBanLe.Caption = "Giá bán lẻ";
            this.GiaBanLe.FieldName = "GiaBanLe";
            this.GiaBanLe.Name = "GiaBanLe";
            this.GiaBanLe.Visible = true;
            this.GiaBanLe.VisibleIndex = 4;
            // 
            // TinhChat
            // 
            this.TinhChat.Caption = "Tính chẩt";
            this.TinhChat.FieldName = "TinhChat";
            this.TinhChat.Name = "TinhChat";
            this.TinhChat.Visible = true;
            this.TinhChat.VisibleIndex = 5;
            // 
            // ConQuanLy
            // 
            this.ConQuanLy.Caption = "Còn quản lý";
            this.ConQuanLy.FieldName = "ConQuanLy";
            this.ConQuanLy.Name = "ConQuanLy";
            this.ConQuanLy.Visible = true;
            this.ConQuanLy.VisibleIndex = 6;
            // 
            // MaVach
            // 
            this.MaVach.Caption = "Mã vạch";
            this.MaVach.FieldName = "MaVach";
            this.MaVach.Name = "MaVach";
            this.MaVach.Visible = true;
            this.MaVach.VisibleIndex = 7;
            // 
            // MaNhomHang
            // 
            this.MaNhomHang.Caption = "Mã nhóm hàng";
            this.MaNhomHang.FieldName = "MaNhomHang";
            this.MaNhomHang.Name = "MaNhomHang";
            this.MaNhomHang.Visible = true;
            this.MaNhomHang.VisibleIndex = 8;
            // 
            // MaKhoHang
            // 
            this.MaKhoHang.Caption = "Mã kho hàng";
            this.MaKhoHang.FieldName = "MaKhoHang";
            this.MaKhoHang.Name = "MaKhoHang";
            this.MaKhoHang.Visible = true;
            this.MaKhoHang.VisibleIndex = 9;
            // 
            // MaDonViTinh
            // 
            this.MaDonViTinh.Caption = "Mã đơn vị tính";
            this.MaDonViTinh.FieldName = "MaDonViTinh";
            this.MaDonViTinh.Name = "MaDonViTinh";
            this.MaDonViTinh.Visible = true;
            this.MaDonViTinh.VisibleIndex = 10;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 11;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.Caption = "Số lượng tồn";
            this.SoLuongTon.FieldName = "SoLuongTon";
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.Visible = true;
            this.SoLuongTon.VisibleIndex = 12;
            // 
            // TonKhoToiThieu
            // 
            this.TonKhoToiThieu.Caption = "Tồn kho tối thiểu";
            this.TonKhoToiThieu.FieldName = "TonKhoToiThieu";
            this.TonKhoToiThieu.Name = "TonKhoToiThieu";
            this.TonKhoToiThieu.Visible = true;
            this.TonKhoToiThieu.VisibleIndex = 13;
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.Caption = "Mã nhà cung cấp";
            this.MaNhaCungCap.FieldName = "MaNhaCungCap";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Visible = true;
            this.MaNhaCungCap.VisibleIndex = 14;
            // 
            // fmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 202);
            this.Controls.Add(this.gridHangHoa);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fmHangHoa";
            this.Text = "Hàng Hóa & Dịch Vụ";
            this.Load += new System.EventHandler(this.fmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenHang;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMua;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanSi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanLe;
        private DevExpress.XtraGrid.Columns.GridColumn TinhChat;
        private DevExpress.XtraGrid.Columns.GridColumn ConQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongTon;
        private DevExpress.XtraGrid.Columns.GridColumn TonKhoToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaCungCap;

    }
}