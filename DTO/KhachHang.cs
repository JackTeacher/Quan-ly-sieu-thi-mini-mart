using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang : ConNguoi
    {
        public KhachHang()
        {
            maKhachHang = string.Empty;
            hangThanhVien = "Đồng";
            diemThanhVien = 0;
        }

        public KhachHang(string hoTen, string? gioiTinh, DateTime? ngaySinh, string? soDienThoai, string? email, string? diaChi, string maKhachHang, string hangThanhVien, int diemThanhVien) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maKhachHang = maKhachHang;
            this.hangThanhVien = hangThanhVien;
            this.diemThanhVien = diemThanhVien;
        }

        public string maKhachHang { get; set; }
        public string hangThanhVien { get; set; }
        public int diemThanhVien { get; set; }
    }
}
