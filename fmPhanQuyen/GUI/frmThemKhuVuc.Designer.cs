namespace fmPhanQuyen.GUI
{
    partial class frmThemKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKhuVuc));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtMaKV = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTenKV = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtGhichu = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkConQL = new DevExpress.XtraEditors.CheckEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkConQL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtGhichu);
            this.layoutControl1.Controls.Add(this.txtTenKV);
            this.layoutControl1.Controls.Add(this.txtMaKV);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(284, 103);
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
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(284, 103);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(264, 11);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtMaKV
            // 
            this.txtMaKV.Location = new System.Drawing.Point(79, 23);
            this.txtMaKV.Name = "txtMaKV";
            this.txtMaKV.Size = new System.Drawing.Size(193, 20);
            this.txtMaKV.StyleController = this.layoutControl1;
            this.txtMaKV.TabIndex = 0;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMaKV;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 11);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem2.Text = "Mã khu vực:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
            // 
            // txtTenKV
            // 
            this.txtTenKV.Location = new System.Drawing.Point(79, 47);
            this.txtTenKV.Name = "txtTenKV";
            this.txtTenKV.Size = new System.Drawing.Size(193, 20);
            this.txtTenKV.StyleController = this.layoutControl1;
            this.txtTenKV.TabIndex = 1;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTenKV;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem3.Text = "Tên khu vực:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 13);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(79, 71);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(193, 20);
            this.txtGhichu.StyleController = this.layoutControl1;
            this.txtGhichu.TabIndex = 2;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtGhichu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 59);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem1.Text = "Ghi chú:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 13);
            // 
            // checkConQL
            // 
            this.checkConQL.Location = new System.Drawing.Point(79, 110);
            this.checkConQL.Name = "checkConQL";
            this.checkConQL.Properties.Caption = "Còn quản lí";
            this.checkConQL.Size = new System.Drawing.Size(75, 19);
            this.checkConQL.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(47, 149);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(165, 149);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(107, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThemKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.checkConQL);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmThemKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khu Vực";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkConQL.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtGhichu;
        private DevExpress.XtraEditors.TextEdit txtTenKV;
        private DevExpress.XtraEditors.TextEdit txtMaKV;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.CheckEdit checkConQL;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}