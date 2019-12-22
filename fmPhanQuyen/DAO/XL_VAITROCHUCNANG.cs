using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DAO
{
    class XL_VAITROCHUCNANG
    {
        public static DataTable LayThongTin(int maVaiTro)
        {
            string sql = "select * from VAITRO_CHUCNANG th,CHUCNANG cn where th.MaChucNang=cn.ID and th.MaVaiTro='"+ maVaiTro+"'";
            return XL_DULIEU.LayDuLieu(sql);
        }
    }
}
