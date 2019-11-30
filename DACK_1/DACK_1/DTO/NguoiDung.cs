using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DTO
{
    public class NguoiDung
    {
        public int MaNguoiDung { get; set; }
        public string TenNguoiDung { get; set; }
        public string TenHienThi { get; set; }
        public string MatKhau { get; set; }
        public bool KichHoat { get; set; }
        public int MaVaiTro { get; set; }
    }
}
