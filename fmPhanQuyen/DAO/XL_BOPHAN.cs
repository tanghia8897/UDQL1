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
    public class XL_BOPHAN
    {
        public static DataTable LayDuLieuBoPhan()
        {
            return XL_DULIEU.LayDuLieuTuBang("BoPhan");
        }

        public static void ThemBoPhan(BoPhan kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemBoPhan",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@ghichu", Value = kq.GhiChu },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL });
        }

        public static void XoaBoPhan(string Ma)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaBoPhan",
                 new SqlParameter { ParameterName = "@ma", Value = Ma });
        }

        public static void SuaBoPhan(BoPhan kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "SuaBoPhan",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@ghichu", Value = kq.GhiChu },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL });
        }
    }
}
