using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace fmPhanQuyen.GUI
{
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Chức năng này chưa hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Chức năng này chưa hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}