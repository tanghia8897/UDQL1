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
    public class XL_KHUVUC
    {
        public static DataTable LayDuLieuKhuVuc()
        {
            return XL_DULIEU.LayDuLieuTuBang("KhuVuc");
        }
        public static void ThemKhuVuc(KhuVuc kv)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemKhuVuc",
                 new SqlParameter { ParameterName = "@ma", Value = kv.MaKhuVuc },
                 new SqlParameter { ParameterName = "@ten", Value = kv.TenKhuVuc },
                 new SqlParameter { ParameterName = "@ghichu", Value = kv.GhiChu },
                 new SqlParameter { ParameterName = "@conquanly", Value = kv.ConQuanLi });
        }

        public static void XoaKhuVuc(string MaKhuVuc)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaKhuVuc",
                 new SqlParameter { ParameterName = "@ma", Value = MaKhuVuc });
        }

        public static void SuaKhuVuc(KhuVuc kv)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "SuaKhuVuc",
                 new SqlParameter { ParameterName = "@ma", Value = kv.MaKhuVuc },
                 new SqlParameter { ParameterName = "@ten", Value = kv.TenKhuVuc },
                 new SqlParameter { ParameterName = "@ghichu", Value = kv.GhiChu },
                 new SqlParameter { ParameterName = "@conquanly", Value = kv.ConQuanLi });
        }
    }
}
