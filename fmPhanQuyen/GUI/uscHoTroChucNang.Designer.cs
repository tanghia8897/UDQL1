namespace fmPhanQuyen.GUI
{
    partial class uscHoTroChucNang
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnUCThem = new DevExpress.XtraBars.BarButtonItem();
            this.btHTCNSua = new DevExpress.XtraBars.BarButtonItem();
            this.btHTCNXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btHTCNNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.btHTCNXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btHTCNNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btHTCNDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.btnUCThem,
            this.btHTCNXoa,
            this.btHTCNSua,
            this.btHTCNNapLai,
            this.btHTCNXuat,
            this.btHTCNNhap,
            this.btHTCNDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUCThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btHTCNSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btHTCNXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btHTCNNapLai, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btHTCNXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btHTCNNhap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btHTCNDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnUCThem
            // 
            this.btnUCThem.Caption = "Thêm";
            this.btnUCThem.Id = 0;
            this.btnUCThem.ImageOptions.ImageUri.Uri = "AddItem";
            this.btnUCThem.Name = "btnUCThem";
            this.btnUCThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btHTCNThem_ItemClick);
            // 
            // btHTCNSua
            // 
            this.btHTCNSua.Caption = "Sửa";
            this.btHTCNSua.Id = 2;
            this.btHTCNSua.ImageOptions.ImageUri.Uri = "Replace";
            this.btHTCNSua.Name = "btHTCNSua";
            // 
            // btHTCNXoa
            // 
            this.btHTCNXoa.Caption = "Xóa";
            this.btHTCNXoa.Id = 1;
            this.btHTCNXoa.ImageOptions.ImageUri.Uri = "Delete";
            this.btHTCNXoa.Name = "btHTCNXoa";
            // 
            // btHTCNNapLai
            // 
            this.btHTCNNapLai.Caption = "Nạp Lại";
            this.btHTCNNapLai.Id = 3;
            this.btHTCNNapLai.ImageOptions.ImageUri.Uri = "Refresh";
            this.btHTCNNapLai.Name = "btHTCNNapLai";
            // 
            // btHTCNXuat
            // 
            this.btHTCNXuat.Caption = "Xuất";
            this.btHTCNXuat.Id = 4;
            this.btHTCNXuat.ImageOptions.ImageUri.Uri = "IndentDecrease";
            this.btHTCNXuat.Name = "btHTCNXuat";
            // 
            // btHTCNNhap
            // 
            this.btHTCNNhap.Caption = "Nhập";
            this.btHTCNNhap.Id = 5;
            this.btHTCNNhap.ImageOptions.ImageUri.Uri = "IndentIncrease";
            this.btHTCNNhap.Name = "btHTCNNhap";
            // 
            // btHTCNDong
            // 
            this.btHTCNDong.Caption = "Đóng";
            this.btHTCNDong.Id = 6;
            this.btHTCNDong.ImageOptions.ImageUri.Uri = "Cancel";
            this.btHTCNDong.Name = "btHTCNDong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(578, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 30);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(578, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 4);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(578, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 4);
            // 
            // uscHoTroChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uscHoTroChucNang";
            this.Size = new System.Drawing.Size(578, 30);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnUCThem;
        private DevExpress.XtraBars.BarButtonItem btHTCNSua;
        private DevExpress.XtraBars.BarButtonItem btHTCNXoa;
        private DevExpress.XtraBars.BarButtonItem btHTCNNapLai;
        private DevExpress.XtraBars.BarButtonItem btHTCNXuat;
        private DevExpress.XtraBars.BarButtonItem btHTCNNhap;
        private DevExpress.XtraBars.BarButtonItem btHTCNDong;
    }
}
