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
    public class XL_TYGIA
    {
        public static DataTable LayDuLieuTyGia()
        {
            return XL_DULIEU.LayDuLieuTuBang("TyGia");
        }

        public static void ThemTyGia(TyGia kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemTyGia",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@tygiaquydoi", Value = kq.TyGiaQuyDoi },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL });
        }

        public static void XoaTyGia(string Ma)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaTyGia",
                 new SqlParameter { ParameterName = "@ma", Value = Ma });
        }

        public static void SuaTyGia(TyGia kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "SuaTyGia",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@tygiaquydoi", Value = kq.TyGiaQuyDoi },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL });
        }
    }
}
