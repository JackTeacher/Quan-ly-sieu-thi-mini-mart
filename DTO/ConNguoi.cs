using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ConNguoi
    {
        public string hoTen { get; set; }
        public string? gioiTinh { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string? soDienThoai { get; set; }
        public string? email { get; set; }
        public string? diaChi { get; set; }
        public ConNguoi() 
        { 
            hoTen = string.Empty;
        }

        public ConNguoi(string hoTen, string? gioiTinh, DateTime? ngaySinh, string? soDienThoai, string? email, string? diaChi)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.diaChi = diaChi;
        }
    }
}
