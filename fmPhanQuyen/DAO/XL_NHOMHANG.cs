using fmPhanQuyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DAO
{
    public class XL_NHOMHANG
    {
        public static DataTable LayDuLieuNhomHang()
        {
            return XL_DULIEU.LayDuLieuTuBang("NhomHang");
        }

        public static void ThemNhomHang(NhomHang kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemNhomHang",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@ghichu", Value = kq.GhiChu },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL });
        }
        public static void XoaNhomHang(string Ma)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaNhomHang",
                 new SqlParameter { ParameterName = "@ma", Value = Ma });
        }
    }
}
