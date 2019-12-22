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
    public partial class frmCapNhat : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhat()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}