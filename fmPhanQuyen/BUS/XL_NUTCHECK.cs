using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmPhanQuyen.BUS
{
    //xử lí nút check trên dữ liệu
    public class XL_NUTCHECK
    {
        public static bool Check(CheckEdit chk)
        {
            if (chk.Checked) return true;
            return false;
        }
        public static bool Check(CheckBox chk)
        {
            if (chk.Checked) return true;
            return false;
        }
    }
}
