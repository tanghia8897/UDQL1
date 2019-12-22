using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DTO
{
    public class HangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public float GiaMua { get; set; }
        public float GiaBanSi { get; set; }
        public float GiaBanLe { get; set; }
        public string TinhChat { get; set; }
        public bool ConQuanLi { get; set; }
        public string MaVach { get; set; }
        public string MaNhomHang { get; set; }
        public string MaKhoHang { get; set; }
        public string MaDonViTinh { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongTon { get; set; }
        public int TonKhoToiThieu { get; set; }
        public string MaNCC { get; set; }

    }
}
