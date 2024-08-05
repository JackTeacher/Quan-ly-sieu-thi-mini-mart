using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung : ConNguoi
    {
        public NguoiDung()
        {
            maNguoiDung = string.Empty;
            maPhanQuyen = string.Empty;
            tenDangNhap = string.Empty;
            matKhau = string.Empty;
            trangThai = "Đang hoạt động";
        }

        public NguoiDung(string hoTen, string? gioiTinh, DateTime? ngaySinh, string? soDienThoai, string? email, string? diaChi, string maNguoiDung, string maPhanQuyen, string tenDangNhap, string matKhau, string trangThai) : base(hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi)
        {
            this.maNguoiDung = maNguoiDung;
            this.maPhanQuyen = maPhanQuyen;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.trangThai = trangThai;
        }

        public string maNguoiDung {  get; set; }
        public string maPhanQuyen { get; set; }
        public string tenDangNhap { get; set; }
        public string matKhau { get; set; }
        public string trangThai { get; set; }
    }
}
