namespace fmPhanQuyen.GUI
{
    partial class fmThemNhanVien
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
            this.uscHoTroChucNang1 = new fmPhanQuyen.GUI.uscHoTroChucNang();
            this.SuspendLayout();
            // 
            // uscHoTroChucNang1
            // 
            this.uscHoTroChucNang1.Location = new System.Drawing.Point(0, 0);
            this.uscHoTroChucNang1.Name = "uscHoTroChucNang1";
            this.uscHoTroChucNang1.Size = new System.Drawing.Size(578, 47);
            this.uscHoTroChucNang1.TabIndex = 0;
            // 
            // fmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 372);
            this.Controls.Add(this.uscHoTroChucNang1);
            this.Name = "fmThemNhanVien";
            this.Text = "fmThemNhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private uscHoTroChucNang uscHoTroChucNang1;
    }
}