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
        public decimal DonGia { get; set; }
        public decimal SoLuong { get; set; }
        public decimal ThanhTien => DonGia * SoLuong;

        public SanPham(string tenSanPham, decimal donGia, decimal soLuong)
        {
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
        }
    }

}