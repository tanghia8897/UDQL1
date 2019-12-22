using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmPhanQuyen.GUI
{
    public partial class uscHoTroChucNang : UserControl
    {
        public uscHoTroChucNang()
        {
            InitializeComponent();
        }

        private void btHTCNThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.fmThemHangHoa fmTHH = new GUI.fmThemHangHoa();
            fmTHH.Show();
        }
    }
}
        

