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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}