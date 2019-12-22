namespace fmPhanQuyen.GUI
{
    partial class frmInPhieuBH
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.gridLoaiPhieuIn = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiPhieuIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridLoaiPhieuIn);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.btnHuy);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(334, 240);
            this.splitContainerControl1.SplitterPosition = 164;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(101, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Chọn";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(220, 34);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 23);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // gridLoaiPhieuIn
            // 
            this.gridLoaiPhieuIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLoaiPhieuIn.Location = new System.Drawing.Point(0, 0);
            this.gridLoaiPhieuIn.MainView = this.gridView1;
            this.gridLoaiPhieuIn.Name = "gridLoaiPhieuIn";
            this.gridLoaiPhieuIn.Size = new System.Drawing.Size(334, 164);
            this.gridLoaiPhieuIn.TabIndex = 0;
            this.gridLoaiPhieuIn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenLoai,
            this.ID});
            this.gridView1.GridControl = this.gridLoaiPhieuIn;
            this.gridView1.Name = "gridView1";
            // 
            // TenLoai
            // 
            this.TenLoai.Caption = "Loại phiếu";
            this.TenLoai.FieldName = "TenLoai";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Visible = true;
            this.TenLoai.VisibleIndex = 0;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 1;
            // 
            // frmInPhieuBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 240);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmInPhieuBH";
            this.Text = "Tùy Chọn In Phiếu Xuất";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiPhieuIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridLoaiPhieuIn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}