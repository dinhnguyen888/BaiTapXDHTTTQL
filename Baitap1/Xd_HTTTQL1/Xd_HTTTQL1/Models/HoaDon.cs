using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xd_HTTTQL1.Models
{
    public class HoaDon
    {
        public string SoHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string KhachHang { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string NhanVienBanHang { get; set; }
        public List<SanPham> DanhSachSanPham { get; set; }

        public HoaDon()
        {
            DanhSachSanPham = new List<SanPham>();
        }

        public int TinhTriGia()
        {
            return DanhSachSanPham.Sum(sp => sp.ThanhTien);
        }
    }
}