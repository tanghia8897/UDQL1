namespace fmPhanQuyen.GUI
{
    partial class frmDangKy
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTiepTheo = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTroGiup = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập mã đăng ký hoặc mã kích hoạt (nếu có)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đăng ký:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã kích hoạt:";
            // 
            // btnTiepTheo
            // 
            this.btnTiepTheo.Location = new System.Drawing.Point(46, 138);
            this.btnTiepTheo.Name = "btnTiepTheo";
            this.btnTiepTheo.Size = new System.Drawing.Size(95, 23);
            this.btnTiepTheo.TabIndex = 5;
            this.btnTiepTheo.Text = "Tiếp theo >";
            this.btnTiepTheo.Click += new System.EventHandler(this.btnTiepTheo_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(150, 138);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Location = new System.Drawing.Point(252, 138);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(95, 23);
            this.btnTroGiup.TabIndex = 7;
            this.btnTroGiup.Text = "Trợ giúp";
            this.btnTroGiup.Click += new System.EventHandler(this.btnTroGiup_Click);
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 177);
            this.Controls.Add(this.btnTroGiup);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTiepTheo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Bán Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnTiepTheo;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTroGiup;
    }
}