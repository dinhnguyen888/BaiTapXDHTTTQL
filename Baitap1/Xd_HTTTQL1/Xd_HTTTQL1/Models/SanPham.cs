using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xd_HTTTQL1.Models
{
    public class SanPham
    {
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien => DonGia * SoLuong;

        public SanPham(string tenSanPham, int donGia, int soLuong)
        {
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
        }
    }
}