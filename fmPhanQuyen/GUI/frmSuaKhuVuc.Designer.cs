namespace fmPhanQuyen.GUI
{
    partial class frmSuaKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaKhuVuc));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtGhichu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKV = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkConQL = new DevExpress.XtraEditors.CheckEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(339, 110);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(74, 78);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(253, 20);
            this.txtGhichu.StyleController = this.layoutControl1;
            this.txtGhichu.TabIndex = 7;
            // 
            // txtTenKV
            // 
            this.txtTenKV.Location = new System.Drawing.Point(74, 54);
            this.txtTenKV.Name = "txtTenKV";
            this.txtTenKV.Size = new System.Drawing.Size(253, 20);
            this.txtTenKV.StyleController = this.layoutControl1;
            this.txtTenKV.TabIndex = 6;
            // 
            // txtMaKV
            // 
            this.txtMaKV.Location = new System.Drawing.Point(74, 30);
            this.txtMaKV.Name = "txtMaKV";
            this.txtMaKV.Size = new System.Drawing.Size(253, 20);
            this.txtMaKV.StyleController = this.layoutControl1;
            this.txtMaKV.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(339, 110);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(319, 18);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMaKV;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem2.Text = "Mã khu vực:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTenKV;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem3.Text = "Tên khu vực";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtGhichu;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem4.Text = "Ghi chú:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(59, 13);
            // 
            // checkConQL
            // 
            this.checkConQL.Location = new System.Drawing.Point(75, 116);
            this.checkConQL.Name = "checkConQL";
            this.checkConQL.Properties.Caption = "Còn quản lí";
            this.checkConQL.Size = new System.Drawing.Size(75, 19);
            this.checkConQL.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(81, 155);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(213, 155);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(114, 23);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmSuaKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 188);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.checkConQL);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmSuaKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Thông Tin Khu Vực";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkConQL.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtGhichu;
        private DevExpress.XtraEditors.TextEdit txtTenKV;
        private DevExpress.XtraEditors.TextEdit txtMaKV;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.CheckEdit checkConQL;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}