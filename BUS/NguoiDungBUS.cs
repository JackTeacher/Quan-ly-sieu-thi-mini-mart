using BUS.OtherFunctions;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguoiDungBUS
    {
        NguoiDungDAO nguoiDungDAO;

        public NguoiDungBUS() 
        { 
            nguoiDungDAO = new NguoiDungDAO();
        }

        public List<NguoiDung> LayDanhSachNguoiDung()
        {
            return nguoiDungDAO.LayDanhSachNguoiDung();
        }

        public NguoiDung LayNguoiDungTheoMa(string maNguoiDung)
        {
            return nguoiDungDAO.LayNguoiDungTheoMa(maNguoiDung);
        }

        public NguoiDung LayNguoiDungTheoTenDangNhap(string tenDangNhap)
        {
            return nguoiDungDAO.LayNguoiDungTheoTenDangNhap(tenDangNhap);
        }

        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            return nguoiDungDAO.KiemTraTenDangNhapTonTai(tenDangNhap);
        } 

        public bool KiemTraNguoiDungHoatDong(string maNguoiDung)
        {
            return nguoiDungDAO.KiemTraNguoiDungHoatDong(maNguoiDung);
        }

        public string DangNhap(string tenDangNhap, string matKhau)
        {
            tenDangNhap = tenDangNhap.Trim();
            matKhau = matKhau.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin!";
            else
            {
                if (!nguoiDungDAO.KiemTraDangNhap(tenDangNhap, matKhau))
                    return "Thông tin đăng nhập không chính xác!";
                else
                {
                    if (!KiemTraNguoiDungHoatDong(tenDangNhap))
                        return "Tài khoản đang tạm thời bị đình chỉ hoặc đã bị xóa!";
                    else
                        return "Đăng nhập thành công!";
                }
            }
        }

        public int DemSoNguoiDungTheoPhanQuyen(string maPhanQuyen)
        {
            return nguoiDungDAO.DemSoNguoiDungTheoPhanQuyen(maPhanQuyen);
        }

        public string ThemNguoiDung(string maNguoiDung, string maPhanQuyen, string tenDangNhap, string matKhau, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(maPhanQuyen) || string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(hoTen))
                return "Phân quyền, thông tin đăng nhập và họ tên không được để trống!";

            if (nguoiDungDAO.KiemTraTenDangNhapTonTai(tenDangNhap))
                return "Tên đăng nhập đã có người dùng, vui lòng đặt tên khác!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            NguoiDung nguoiDung = new NguoiDung();

            nguoiDung.maNguoiDung = maNguoiDung;
            nguoiDung.maPhanQuyen = maPhanQuyen;
            nguoiDung.tenDangNhap = tenDangNhap;
            nguoiDung.matKhau = matKhau;
            nguoiDung.hoTen = hoTen.Trim();
            nguoiDung.gioiTinh = gioiTinh;
            try { nguoiDung.ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null); }
            catch { nguoiDung.ngaySinh = null; }
            nguoiDung.soDienThoai = soDienThoai.Trim();
            nguoiDung.email = email.Trim();
            nguoiDung.diaChi = diaChi.Trim();

            if (nguoiDungDAO.ThemNguoiDung(nguoiDung))
                return "Thêm người dùng thành công!";
            else
                return "Thêm người dùng thất bại!";
        }

        public string XoaNguoiDung(string maNguoiDung)
        {
            if (nguoiDungDAO.XoaNguoiDung(maNguoiDung))
                return "Xóa người dùng thành công!";
            else
                return "Xóa người dùng thất bại!";
        }

        public string SuaNguoiDung(string maNguoiDung, string maPhanQuyen, string tenDangNhap, string matKhau, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi, string trangThai)
        {
            NguoiDung nguoiDung = LayNguoiDungTheoMa(maNguoiDung);

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(hoTen))
                return "Thông tin đăng nhập và họ tên không được để trống!";

            if (nguoiDungDAO.KiemTraTenDangNhapTonTai(tenDangNhap) && !nguoiDung.tenDangNhap.Equals(tenDangNhap.Trim()))
                return "Tên đăng nhập đã có người dùng, vui lòng đặt tên khác!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            

            nguoiDung.maNguoiDung = maNguoiDung;
            nguoiDung.maPhanQuyen = maPhanQuyen;
            nguoiDung.tenDangNhap = tenDangNhap.Trim();
            nguoiDung.matKhau = matKhau.Trim();
            nguoiDung.hoTen = hoTen.Trim();
            nguoiDung.gioiTinh = gioiTinh;
            try { nguoiDung.ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null); }
            catch { nguoiDung.ngaySinh = null; }
            nguoiDung.soDienThoai = soDienThoai.Trim();
            nguoiDung.email = email.Trim();
            nguoiDung.diaChi = diaChi.Trim();
            nguoiDung.trangThai = trangThai;

            if (nguoiDungDAO.SuaNguoiDung(nguoiDung))
                return "Chỉnh sửa thông tin người dùng thành công!";
            else
                return "Chỉnh sửa thông tin người dùng thất bại!";
        }

        public List<NguoiDung> TimKiemNguoiDung(string tuKhoa, string maPhanQuyen, string gioiTinh, string trangThai)
        {
            tuKhoa = tuKhoa.Trim().ToLower();

            return nguoiDungDAO.TimKiemNguoiDung(tuKhoa, maPhanQuyen, gioiTinh, trangThai);
        }

        public string DoiMatKhau(string maNguoiDung, string matKhauCu, string matKhauMoi, string xacNhan)
        {
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhan))
                return "Vui lòng nhập đầy đủ thông tin!";
            if (!matKhauCu.Equals(LayNguoiDungTheoMa(maNguoiDung).matKhau))
                return "Mật khẩu cũ không chính xác!";
            if (matKhauCu.Equals(matKhauMoi))
                return "Mật khẩu mới không được giống mật khẩu cũ!";
            if (!matKhauMoi.Equals(xacNhan))
                return "Xác nhận mật khẩu mới không chính xác, hãy kiểm tra lại!";
            if (nguoiDungDAO.DoiMatKhau(maNguoiDung, matKhauMoi))
                return "Đổi mật khẩu thành công!";
            else
                return "Đổi mật khẩu thất bại!";
        }
    }
}
