namespace fmPhanQuyen.GUI
{
    partial class frmCapNhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhat));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiên bản bạn đang dùng là phiên bản mới nhất.";
            // 
            // btnOK
            // 
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnOK.Location = new System.Drawing.Point(308, 78);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 26);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 120);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Trực Tuyến";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}