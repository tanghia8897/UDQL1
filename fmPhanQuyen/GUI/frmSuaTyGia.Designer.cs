namespace fmPhanQuyen.GUI
{
    partial class frmSuaTyGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaTyGia));
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.checkConQL = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTyGiaQuyDoi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.checkConQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTyGiaQuyDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(191, 161);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(49, 161);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // checkConQL
            // 
            this.checkConQL.Location = new System.Drawing.Point(87, 111);
            this.checkConQL.Name = "checkConQL";
            this.checkConQL.Properties.Caption = "Còn quản lý";
            this.checkConQL.Size = new System.Drawing.Size(97, 19);
            this.checkConQL.TabIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTyGiaQuyDoi);
            this.layoutControl1.Controls.Add(this.txtTen);
            this.layoutControl1.Controls.Add(this.txtMa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(326, 106);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTyGiaQuyDoi
            // 
            this.txtTyGiaQuyDoi.Location = new System.Drawing.Point(86, 74);
            this.txtTyGiaQuyDoi.Name = "txtTyGiaQuyDoi";
            this.txtTyGiaQuyDoi.Size = new System.Drawing.Size(228, 20);
            this.txtTyGiaQuyDoi.StyleController = this.layoutControl1;
            this.txtTyGiaQuyDoi.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(86, 50);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(228, 20);
            this.txtTen.StyleController = this.layoutControl1;
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(86, 26);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(228, 20);
            this.txtMa.StyleController = this.layoutControl1;
            this.txtMa.TabIndex = 0;
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
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(326, 106);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(306, 14);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMa;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 14);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem2.Text = "Mã:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTen;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem3.Text = "Tên:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTyGiaQuyDoi;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem4.Text = "Tỷ giá quy đổi:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(71, 13);
            // 
            // frmSuaTyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 202);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.checkConQL);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmSuaTyGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Tỷ Giá";
            ((System.ComponentModel.ISupportInitialize)(this.checkConQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTyGiaQuyDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.CheckEdit checkConQL;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtTyGiaQuyDoi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}