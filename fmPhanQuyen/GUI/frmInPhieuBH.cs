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
using fmPhanQuyen.DAO;

namespace fmPhanQuyen.GUI
{
    public partial class frmInPhieuBH : DevExpress.XtraEditors.XtraForm
    {
        public frmInPhieuBH()
        {
            InitializeComponent();
            LoadDuLieu();
        }

        public void LoadDuLieu()
        {
            gridLoaiPhieuIn.DataSource = XL_DULIEU.LayDuLieuTuBang("LoaiPhieuIn");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}