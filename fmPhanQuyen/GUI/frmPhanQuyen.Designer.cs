namespace fmPhanQuyen.GUI
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemVaiTro = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tvChucNang = new System.Windows.Forms.TreeView();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridVaiTroChucNang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridChucNang = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TatCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TruyCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Them = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xuat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVaiTroChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.btnThemVaiTro,
            this.btnThemNguoiDung,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemVaiTro, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemNguoiDung, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemVaiTro
            // 
            this.btnThemVaiTro.Caption = "Thêm Vai Trò";
            this.btnThemVaiTro.Id = 0;
            this.btnThemVaiTro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaiTro.ImageOptions.Image")));
            this.btnThemVaiTro.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemVaiTro.ImageOptions.LargeImage")));
            this.btnThemVaiTro.Name = "btnThemVaiTro";
            this.btnThemVaiTro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemVaiTro_ItemClick);
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.Caption = "Thêm Người Dùng";
            this.btnThemNguoiDung.Id = 1;
            this.btnThemNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNguoiDung.ImageOptions.Image")));
            this.btnThemNguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemNguoiDung.ImageOptions.LargeImage")));
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNguoiDung_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sửa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 4;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(753, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 401);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(753, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(753, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 24);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(753, 377);
            this.splitContainerControl1.SplitterPosition = 187;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tvChucNang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(187, 377);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Vai Trò Và Người Dùng";
            // 
            // tvChucNang
            // 
            this.tvChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvChucNang.Location = new System.Drawing.Point(2, 20);
            this.tvChucNang.Name = "tvChucNang";
            this.tvChucNang.Size = new System.Drawing.Size(183, 355);
            this.tvChucNang.TabIndex = 0;
            this.tvChucNang.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvChucNang_AfterSelect);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridVaiTroChucNang);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridChucNang);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(561, 377);
            this.splitContainerControl2.SplitterPosition = 176;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridVaiTroChucNang
            // 
            this.gridVaiTroChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVaiTroChucNang.Location = new System.Drawing.Point(0, 0);
            this.gridVaiTroChucNang.MainView = this.gridView1;
            this.gridVaiTroChucNang.MenuManager = this.barManager1;
            this.gridVaiTroChucNang.Name = "gridVaiTroChucNang";
            this.gridVaiTroChucNang.Size = new System.Drawing.Size(561, 176);
            this.gridVaiTroChucNang.TabIndex = 0;
            this.gridVaiTroChucNang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridVaiTroChucNang;
            this.gridView1.Name = "gridView1";
            // 
            // gridChucNang
            // 
            this.gridChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChucNang.Location = new System.Drawing.Point(0, 0);
            this.gridChucNang.MainView = this.gridView2;
            this.gridChucNang.MenuManager = this.barManager1;
            this.gridChucNang.Name = "gridChucNang";
            this.gridChucNang.Size = new System.Drawing.Size(561, 196);
            this.gridChucNang.TabIndex = 1;
            this.gridChucNang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenChucNang,
            this.TatCa,
            this.TruyCap,
            this.Them,
            this.Xoa,
            this.Sua,
            this.InAn,
            this.Nhap,
            this.Xuat});
            this.gridView2.GridControl = this.gridChucNang;
            this.gridView2.Name = "gridView2";
            // 
            // TenChucNang
            // 
            this.TenChucNang.Caption = "Tên chức năng";
            this.TenChucNang.FieldName = "TenChucNang";
            this.TenChucNang.Name = "TenChucNang";
            this.TenChucNang.Visible = true;
            this.TenChucNang.VisibleIndex = 0;
            // 
            // TatCa
            // 
            this.TatCa.Caption = "Tất cả";
            this.TatCa.FieldName = "TatCa";
            this.TatCa.Name = "TatCa";
            this.TatCa.Visible = true;
            this.TatCa.VisibleIndex = 1;
            // 
            // TruyCap
            // 
            this.TruyCap.Caption = "Truy cập";
            this.TruyCap.FieldName = "TruyCap";
            this.TruyCap.Name = "TruyCap";
            this.TruyCap.Visible = true;
            this.TruyCap.VisibleIndex = 2;
            // 
            // Them
            // 
            this.Them.Caption = "Thêm";
            this.Them.FieldName = "Them";
            this.Them.Name = "Them";
            this.Them.Visible = true;
            this.Them.VisibleIndex = 3;
            // 
            // Xoa
            // 
            this.Xoa.Caption = "Xóa";
            this.Xoa.FieldName = "Xoa";
            this.Xoa.Name = "Xoa";
            this.Xoa.Visible = true;
            this.Xoa.VisibleIndex = 4;
            // 
            // Sua
            // 
            this.Sua.Caption = "Sửa";
            this.Sua.FieldName = "Sua";
            this.Sua.Name = "Sua";
            this.Sua.Visible = true;
            this.Sua.VisibleIndex = 5;
            // 
            // InAn
            // 
            this.InAn.Caption = "In";
            this.InAn.FieldName = "InAn";
            this.InAn.Name = "InAn";
            this.InAn.Visible = true;
            this.InAn.VisibleIndex = 6;
            // 
            // Nhap
            // 
            this.Nhap.Caption = "Nhập";
            this.Nhap.FieldName = "Nhap";
            this.Nhap.Name = "Nhap";
            this.Nhap.Visible = true;
            this.Nhap.VisibleIndex = 7;
            // 
            // Xuat
            // 
            this.Xuat.Caption = "Xuất";
            this.Xuat.FieldName = "Xuat";
            this.Xuat.Name = "Xuat";
            this.Xuat.Visible = true;
            this.Xuat.VisibleIndex = 8;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 401);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhanQuyen";
            this.Text = "Phân Quyền";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVaiTroChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemVaiTro;
        private DevExpress.XtraBars.BarButtonItem btnThemNguoiDung;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TreeView tvChucNang;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridVaiTroChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn TenChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn TatCa;
        private DevExpress.XtraGrid.Columns.GridColumn TruyCap;
        private DevExpress.XtraGrid.Columns.GridColumn Them;
        private DevExpress.XtraGrid.Columns.GridColumn Xoa;
        private DevExpress.XtraGrid.Columns.GridColumn Sua;
        private DevExpress.XtraGrid.Columns.GridColumn InAn;
        private DevExpress.XtraGrid.Columns.GridColumn Nhap;
        private DevExpress.XtraGrid.Columns.GridColumn Xuat;
    }
}