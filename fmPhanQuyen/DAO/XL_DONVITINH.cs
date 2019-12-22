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
    public class XL_DONVITINH
    {
        public static DataTable LayDuLieuDonViTinh()
        {
            return XL_DULIEU.LayDuLieuTuBang("DonViTinh");
        }
        public static void ThemDonViTinh(DonViTinh kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemDonViTinh",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@ghichu", Value = kq.GhiChu },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL });
        }
        public static void XoaDonViTinh(string Ma)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaDonViTinh",
                 new SqlParameter { ParameterName = "@ma", Value = Ma });
        }

        public static void SuaDonViTinh(DonViTinh kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "SuaDonViTinh",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@ghichu", Value = kq.GhiChu },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL });
        }
    }
}
