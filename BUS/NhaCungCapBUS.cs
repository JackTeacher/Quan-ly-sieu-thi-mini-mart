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
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO nhaCungCapDAO;

        public NhaCungCapBUS()
        {
            nhaCungCapDAO = new NhaCungCapDAO();
        }

        public List<NhaCungCap> LayDanhSachNhaCungCap()
        {
            return nhaCungCapDAO.LayDanhSachNhaCungCap();
        }

        public NhaCungCap LayNhaCungCapTheoMa(string maNhaCungCap)
        {
            return nhaCungCapDAO.LayNhaCungCapTheoMa(maNhaCungCap);
        }

        public int DemSoNhaCungCap()
        {
            return nhaCungCapDAO.DemSoNhaCungCap();
        }

        public string ThemNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(tenNhaCungCap))
                return "Tên nhà cung cấp không được bỏ trống!";

            if (string.IsNullOrEmpty(soDienThoai) && string.IsNullOrEmpty(email))
                return "Hãy nhập số điện thoại hoặc email để có thể liên lạc nhà cung cấp!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            NhaCungCap nhaCungCap = new NhaCungCap();

            nhaCungCap.maNhaCungCap = maNhaCungCap;
            nhaCungCap.tenNhaCungCap = tenNhaCungCap.Trim();
            nhaCungCap.soDienThoai = soDienThoai.Trim();
            nhaCungCap.email = email.Trim();
            nhaCungCap.diaChi = diaChi.Trim();

            if (nhaCungCapDAO.ThemNhaCungCap(nhaCungCap))
                return "Thêm nhà cung cấp thành công!";
            else
                return "Thêm nhà cung cấp thất bại!";
        }

        public string SuaNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string email, string diaChi)
        {
            if (string.IsNullOrEmpty(tenNhaCungCap))
                return "Tên nhà cung cấp không được bỏ trống!";

            if (string.IsNullOrEmpty(soDienThoai) && string.IsNullOrEmpty(email))
                return "Hãy nhập số điện thoại hoặc email để liên lạc nhà cung cấp!";

            if (!string.IsNullOrEmpty(soDienThoai) && !InputValidate.PhoneNumberValidate(soDienThoai))
                return "Vui lòng nhập đúng số điện thoại!";

            if (!string.IsNullOrEmpty(email) && !InputValidate.EmailValidate(email))
                return "Vui lòng nhập đúng email!";

            NhaCungCap nhaCungCap = new NhaCungCap();

            nhaCungCap.maNhaCungCap = maNhaCungCap;
            nhaCungCap.tenNhaCungCap = tenNhaCungCap.Trim();
            nhaCungCap.soDienThoai = soDienThoai.Trim();
            nhaCungCap.email = email.Trim();
            nhaCungCap.diaChi = diaChi.Trim();

            if (nhaCungCapDAO.SuaNhaCungCap(nhaCungCap))
                return "Chỉnh sửa thông tin nhà cung cấp thành công!";
            else
                return "Chỉnh sửa thông tin nhà cung cấp thất bại!";
        }

        public List<NhaCungCap> TimKiemNhaCungCap(string tuKhoa)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return nhaCungCapDAO.TimKiemNhaCungCap(tuKhoa);
        }
    }
}
