namespace fmPhanQuyen.GUI
{
    partial class frmDangNhap
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkShowPW = new DevExpress.XtraEditors.CheckEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPW.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(230, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMatKhau);
            this.layoutControl1.Controls.Add(this.txtTaiKhoan);
            this.layoutControl1.Location = new System.Drawing.Point(170, 70);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(287, 80);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(65, 48);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(210, 20);
            this.txtMatKhau.StyleController = this.layoutControl1;
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(65, 12);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(210, 20);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(287, 80);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTaiKhoan;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(267, 24);
            this.layoutControlItem1.Text = "Tài khoản:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(267, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMatKhau;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(267, 24);
            this.layoutControlItem2.Text = "Mật khẩu:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 13);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::fmPhanQuyen.Properties.Resources.khoa3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 154);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // checkShowPW
            // 
            this.checkShowPW.Location = new System.Drawing.Point(236, 161);
            this.checkShowPW.Name = "checkShowPW";
            this.checkShowPW.Properties.Caption = "Hiển thị mật khẩu";
            this.checkShowPW.Size = new System.Drawing.Size(120, 20);
            this.checkShowPW.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(177, 219);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(131, 23);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(326, 219);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 258);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.checkShowPW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Bán Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPW.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.CheckEdit checkShowPW;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}