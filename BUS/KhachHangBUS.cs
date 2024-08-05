using BUS.OtherFunctions;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khachHangDAO;
        public KhachHangBUS()
        {
            khachHangDAO = new KhachHangDAO();
        }

        public List<KhachHang> LayDanhSachKhachHang()
        {
            return khachHangDAO.LayDanhSachKhachHang();
        }

        public KhachHang LayKhachHangTheoMa(string maKhachHang)
        {
            return khachHangDAO.LayKhachHangTheoMa(maKhachHang);
        }

        public KhachHang LayKhachHangTheoSoDienThoai(string soDienThoai)
        {
            return khachHangDAO.LayKhachHangTheoSoDienThoai(soDienThoai);
        }

        public int DemSoKhachHang()
        {
            return khachHangDAO.DemSoKhachHang();
        }

        public string ThemKhachHang(string maKhachHang, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai))
                return "Tên khách hàng và số điện thoại không được bỏ trống!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (khachHangDAO.KiemTraSoDienThoaiDaTonTai(soDienThoai))
                return "Số điện thoại đã có khách hàng đăng kí, vui lòng sử dụng số khác!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            KhachHang khachHang = new KhachHang();

            khachHang.maKhachHang = maKhachHang;
            khachHang.hoTen = hoTen.Trim();
            khachHang.gioiTinh = gioiTinh;
            try { khachHang.ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null); }
            catch { khachHang.ngaySinh = null; }
            khachHang.soDienThoai = soDienThoai.Trim();
            khachHang.email = email.Trim();
            khachHang.diaChi = diaChi.Trim();

            if (khachHangDAO.ThemKhachHang(khachHang))
                return "Thêm khách hàng thành công!";
            else
                return "Thêm khách hàng thất bại!";
        }

        public string SuaKhachHang(string maKhachHang, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai))
                return "Họ tên và số điện thoại không được bỏ trống!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (khachHangDAO.KiemTraSoDienThoaiDaTonTai(soDienThoai) && !LayKhachHangTheoMa(maKhachHang).soDienThoai.Equals(soDienThoai))
                return "Số điện thoại đã có khách hàng đăng kí, vui lòng sử dụng số khác!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            KhachHang khachHang = new KhachHang();

            khachHang.maKhachHang = maKhachHang;
            khachHang.hoTen = hoTen.Trim();
            khachHang.gioiTinh = gioiTinh;
            try { khachHang.ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null); }
            catch { khachHang.ngaySinh = null; }
            khachHang.soDienThoai = soDienThoai.Trim();
            khachHang.email = email.Trim();
            khachHang.diaChi = diaChi.Trim();

            if (khachHangDAO.SuaKhachHang(khachHang))
                return "Chỉnh sửa thông tin khách hàng thành công!";
            else
                return "Chỉnh sửa thông tin khách hàng thất bại!";
        }

        public List<KhachHang> TimKiemKhachHang(string tuKhoa, string hangThanhVien, string gioiTinh)
        {
            tuKhoa = tuKhoa.Trim().ToLower();

            return khachHangDAO.TimKiemKhachHang(tuKhoa, hangThanhVien, gioiTinh);
        }

        public decimal TichDiem(string maKhachHang, string tongTien)
        {
            KhachHang khachHang = khachHangDAO.LayKhachHangTheoMa(maKhachHang);

            return khachHangDAO.TichDiem(khachHang, Decimal.Parse(tongTien));
        }

        public decimal GiamGiaThanhVien(string maKhachHang, string tongTien)
        {
            KhachHang khachHang = khachHangDAO.LayKhachHangTheoMa(maKhachHang);

            return khachHangDAO.GiamGiaThanhVien(khachHang, Decimal.Parse(tongTien));
        }
    }
}
