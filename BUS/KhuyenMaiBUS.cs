using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAO khuyenMaiDAO;

        public KhuyenMaiBUS()
        {
            khuyenMaiDAO = new KhuyenMaiDAO();
        }

        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            return khuyenMaiDAO.LayDanhSachKhuyenMai();
        }

        public int DemSoKhuyenMai()
        {
            return khuyenMaiDAO.DemSoKhuyenMai();
        }

        public KhuyenMai LayKhuyenMaiTheoMa(string maKhuyenMai)
        {
            return khuyenMaiDAO.LayKhuyenMaiTheoMa(maKhuyenMai);
        }

        public string ThemKhuyenMai(string maKhuyenMai, string tenKhuyenMai, string thoiGianBatDau, string thoiGianKetThuc, string loaiGiaTri, string giaTri)
        {
            if (string.IsNullOrEmpty(tenKhuyenMai) || string.IsNullOrEmpty(thoiGianBatDau) || string.IsNullOrEmpty(thoiGianKetThuc) || string.IsNullOrEmpty(loaiGiaTri) || string.IsNullOrEmpty(giaTri))
                return "Vui lòng nhập đầy đủ thông tin!";

            DateTime dateTimeBatDau = DateTime.ParseExact(thoiGianBatDau, "dd/MM/yyyy HH:mm:ss", null);
            DateTime dateTimeKetThuc = DateTime.ParseExact(thoiGianKetThuc, "dd/MM/yyyy HH:mm:ss", null);

            if (dateTimeBatDau >= dateTimeKetThuc)
                return "Thời gian bắt đầu phải diễn ra trước thời gian kết thúc!";

            if (dateTimeBatDau <= DateTime.Now)
                return "Thời gian bắt đầu không được diễn ra trước thời điểm hiện tại!";

            if (Decimal.Parse(giaTri) <= 0)
                return "Giá trị không được bé hơn 0!";

            KhuyenMai khuyenMai = new KhuyenMai();

            khuyenMai.maKhuyenMai = maKhuyenMai;
            khuyenMai.tenKhuyenMai = tenKhuyenMai.Trim();
            khuyenMai.thoiGianBatDau = dateTimeBatDau;
            khuyenMai.thoiGianKetThuc = dateTimeKetThuc;
            khuyenMai.loaiGiaTri = loaiGiaTri;
            khuyenMai.giaTri = Decimal.Parse(giaTri);

            if (khuyenMaiDAO.ThemKhuyenMai(khuyenMai))
                return "Thêm khuyến mãi thành công!";
            else
                return "Thêm khuyến mãi thất bại!";
        }

        public string XoaKhuyenMai(string maKhuyenMai)
        {
            if (khuyenMaiDAO.XoaKhuyenMai(maKhuyenMai))
                return "Xóa khuyến mãi thành công!";
            else
                return "Xóa khuyến mãi thất bại!";
        }

        public string SuaKhuyenMai(string maKhuyenMai, string tenKhuyenMai, string thoiGianBatDau, string thoiGianKetThuc, string loaiGiaTri, string giaTri)
        {
            if (string.IsNullOrEmpty(tenKhuyenMai) || string.IsNullOrEmpty(thoiGianBatDau) || string.IsNullOrEmpty(thoiGianKetThuc) || string.IsNullOrEmpty(loaiGiaTri) || string.IsNullOrEmpty(giaTri))
                return "Vui lòng nhập đầy đủ thông tin!";

            DateTime dateTimeBatDau = DateTime.ParseExact(thoiGianBatDau, "dd/MM/yyyy HH:mm:ss", null);
            DateTime dateTimeKetThuc = DateTime.ParseExact(thoiGianKetThuc, "dd/MM/yyyy HH:mm:ss", null);

            if (dateTimeBatDau >= dateTimeKetThuc)
                return "Thời gian bắt đầu phải trước thời gian kết thúc!";

            if (dateTimeBatDau <= DateTime.Now && !dateTimeBatDau.Equals(LayKhuyenMaiTheoMa(maKhuyenMai).thoiGianBatDau))
                return "Thời gian bắt đầu không được trước thời điểm hiện tại!";

            if (Decimal.Parse(giaTri) <= 0)
                return "Giá trị áp dụng không được bé hơn 0!";

            KhuyenMai khuyenMai = new KhuyenMai();

            khuyenMai.maKhuyenMai = maKhuyenMai;
            khuyenMai.tenKhuyenMai = tenKhuyenMai.Trim();
            khuyenMai.thoiGianBatDau = dateTimeBatDau;
            khuyenMai.thoiGianKetThuc = dateTimeKetThuc;
            khuyenMai.loaiGiaTri = loaiGiaTri;
            khuyenMai.giaTri = Decimal.Parse(giaTri);

            if (khuyenMaiDAO.SuaKhuyenMai(khuyenMai))
                return "Chỉnh sửa thông tin khuyến mãi thành công!";
            else
                return "Chỉnh sửa thông tin khuyến mãi thất bại!";
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string tuKhoa, string trangThai, string loaiGiaTri, string sapXep, string thoiGianBatDau, string thoiGianKetThuc)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            DateTime? dateTimeBatDau = null;
            DateTime? dateTimeKetThuc = null;

            if (!string.IsNullOrEmpty(thoiGianBatDau) && !string.IsNullOrEmpty(thoiGianKetThuc))
            {
                dateTimeBatDau = DateTime.ParseExact(thoiGianBatDau, "dd/MM/yyyy HH:mm:ss", null);
                dateTimeKetThuc = DateTime.ParseExact(thoiGianKetThuc, "dd/MM/yyyy HH:mm:ss", null);
            }

            return khuyenMaiDAO.TimKiemKhuyenMai(tuKhoa, trangThai, loaiGiaTri, sapXep, dateTimeBatDau, dateTimeKetThuc);
        }

        public decimal ApDungKhuyenMai(string maKhuyenMai,  string tongTien)
        {
            KhuyenMai khuyenMai = khuyenMaiDAO.LayKhuyenMaiTheoMa(maKhuyenMai);

            return khuyenMaiDAO.ApDungKhuyenMai(khuyenMai, Decimal.Parse(tongTien));
        }
    }
}
