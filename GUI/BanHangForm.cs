using BUS;
using BUS.OtherFunctions;
using DTO;
using GUI.CacFormChon;
using GUI.CacFormThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BanHangForm : Form
    {
        SanPhamBUS sanPhamBUS;
        List<SanPham> listSanPham;
        internal List<SanPham> listSanPhamDonHang;
        internal KhachHang khachHang;
        internal KhuyenMai khuyenMai;

        public BanHangForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.LayDanhSachSanPham();
            listSanPhamDonHang = new List<SanPham>();
            loaiSanPhamComboBox.DataSource = new LoaiSanPhamBUS().LayDanhSachLoaiSanPham();
            loaiSanPhamComboBox.DisplayMember = "tenLoaiSanPham";
            loaiSanPhamComboBox.SelectedIndex = -1;
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            LoadDataToFlowLayout(listSanPham);
        }

        private void LoadDataToFlowLayout(List<SanPham> listSanPham)
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in sanPhamFlowLayoutPanel.Controls)
            {
                controlsToRemove.Add(control);
            }

            foreach (Control control in controlsToRemove)
            {
                sanPhamFlowLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }

            foreach (SanPham sanPham in listSanPham)
            {
                sanPhamFlowLayoutPanel.Controls.Add(new SanPhamControl(sanPham, this));
            }
        }

        private void timKiemSanPhamButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemSanPhamTextBox.Text;
            string maLoaiSanPham = "";
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                LoaiSanPham loaiSanPham = loaiSanPhamComboBox.SelectedValue as LoaiSanPham;
                maLoaiSanPham = loaiSanPham.maLoaiSanPham;
            }

            listSanPham = sanPhamBUS.TimKiemSanPham(tuKhoa, maLoaiSanPham, "Đang bán", "");

            LoadDataToFlowLayout(listSanPham);
        }

        private void timKiemSanPhamTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemSanPhamButton_Click(sender, e);
        }

        private void loaiSanPhamComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                timKiemSanPhamTextBox.Clear();
                timKiemSanPhamButton_Click(sender, e);
            }
        }

        private void lamMoiSanPhamButton_Click(object sender, EventArgs e)
        {
            timKiemSanPhamTextBox.Clear();
            loaiSanPhamComboBox.SelectedItem = null;
            loaiSanPhamComboBox.SelectedIndex = -1;

            listSanPham = sanPhamBUS.LayDanhSachSanPham();

            LoadDataToFlowLayout(listSanPham);
        }

        private void timKiemKhachHangButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemKhachHangTextBox.Text;
            List<KhachHang> listKhachHang = new KhachHangBUS().TimKiemKhachHang(tuKhoa, "", "");
            if (listKhachHang.Count == 1 && listKhachHang[0].soDienThoai.Equals(tuKhoa))
            {
                khachHang = listKhachHang[0];
                tenKhachHangLabel.Text = khachHang.hoTen;
                soDienThoaiLabel.Text = khachHang.soDienThoai;
                bacThanhVienLabel.Text = khachHang.hangThanhVien;
                diemTichLuyLabel.Text = khachHang.diemThanhVien.ToString();
            }
        }

        private void timKiemKhachHangTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemKhachHangButton_Click(sender, e);
        }

        private void lamMoiKhachHangButton_Click(object sender, EventArgs e)
        {
            khachHang = null;
            timKiemKhachHangTextBox.Clear();
            tenKhachHangLabel.Text = string.Empty;
            soDienThoaiLabel.Text = string.Empty;
            bacThanhVienLabel.Text = string.Empty;
            diemTichLuyLabel.Text = "0";
            if (khuyenMaiThanhVienButton.Checked)
            {
                khuyenMaiThanhVienButton.Checked = false;
                tenKhuyenMaiLabel.Text = string.Empty;
                chietKhauLabel.Text = "0 VNĐ";
            }
        }

        private void TinhTien()
        {
            decimal tongTien = Decimal.Parse((tongTienLabel.Text.Where(char.IsDigit).ToArray()));
            decimal giamGia = 0;
            if (khuyenMai != null)
                giamGia = new KhuyenMaiBUS().ApDungKhuyenMai(khuyenMai.maKhuyenMai, tongTien.ToString());
            if (khuyenMai == null && khachHang != null && !chietKhauLabel.Text.Equals("0 VNĐ"))
                giamGia = new KhachHangBUS().GiamGiaThanhVien(khachHang.maKhachHang, tongTien.ToString());
            decimal thanhTien = 0;
            decimal tienNhan = 0;
            if (!string.IsNullOrEmpty(tienNhanTextBox.Text))
                tienNhan = Decimal.Parse((tienNhanTextBox.Text.Where(char.IsDigit).ToArray()));
            decimal tienThua = Decimal.Parse((tienThuaLabel.Text.Where(char.IsDigit).ToArray()));

            thanhTien = tongTien - giamGia;
            tienThua = tienNhan - thanhTien;

            thanhTienLabel.Text = thanhTien.ToString("#,##0") + " VNĐ";
            tienThuaLabel.Text = tienThua.ToString("#,##0") + " VNĐ";
            chietKhauLabel.Text = giamGia.ToString("#,##0") + " VNĐ";
        }

        private void tongTienLabel_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void chietKhauLabel_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void tienNhanTextBox_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void khuyenMaiThanhVienButton_Click(object sender, EventArgs e)
        {
            decimal tongTien = Decimal.Parse((tongTienLabel.Text.Where(char.IsDigit).ToArray()));
            decimal giamGia = Decimal.Parse((chietKhauLabel.Text.Where(char.IsDigit).ToArray()));

            if (khachHang != null)
            {
                khuyenMai = null;
                tenKhuyenMaiLabel.Text = string.Empty;
                chietKhauLabel.Text = "0 VNĐ";

                giamGia = new KhachHangBUS().GiamGiaThanhVien(khachHang.maKhachHang, tongTien.ToString());
                chietKhauLabel.Text = giamGia.ToString("#,##0") + " VNĐ";

                switch (khachHang.hangThanhVien)
                {
                    case "Đồng":
                        tenKhuyenMaiLabel.Text = "(Khuyến mãi thành viên hạng đồng 2% tổng giá trị hóa đơn!)";
                        break;
                    case "Bạc":
                        tenKhuyenMaiLabel.Text = "(Khuyến mãi thành viên hạng đồng 3% tổng giá trị hóa đơn!)";
                        break;
                    case "Vàng":
                        tenKhuyenMaiLabel.Text = "(Khuyến mãi thành viên hạng đồng 5% tổng giá trị hóa đơn!)";
                        break;
                }
            }
        }

        private void khuyenMaiKhacButton_Click(object sender, EventArgs e)
        {
            if (listSanPhamDonHang.Count > 0)
                new ChonKhuyenMai(this).Show();
        }

        internal void lamMoiKhuyenMaiButton_Click(object sender, EventArgs e)
        {
            khuyenMai = null;
            tenKhuyenMaiLabel.Text = string.Empty;
            chietKhauLabel.Text = "0 VNĐ";
        }

        private void hoanTatButton_Click(object sender, EventArgs e)
        {
            DialogResult result = XacNhanForm.ShowDialog("Xác nhận thanh toán?");

            if (result == DialogResult.Yes)
            {
                string maNhanVien = DangNhapForm.nguoiDung.maNguoiDung;
                string maKhachHang = "";
                if (khachHang != null)
                    maKhachHang = khachHang.maKhachHang;
                string maKhuyenMai = "";
                if (khuyenMai != null)
                    maKhuyenMai = khuyenMai.maKhuyenMai;
                string tongTien = tongTienLabel.Text.Replace(" VNĐ", "").Replace(",", "");
                string giamGia = chietKhauLabel.Text.Replace(" VNĐ", "").Replace(",", "");
                string thanhTien = thanhTienLabel.Text.Replace(" VNĐ", "").Replace(",", "");
                string tienNhan = "0";
                if (!string.IsNullOrEmpty(tienNhanTextBox.Text))
                    tienNhan = tienNhanTextBox.Text;
                string tienThua = tienThuaLabel.Text.Replace(" VNĐ", "").Replace(",", "");

                List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

                foreach (Control control in chiTietDonHangFlowLayoutPanel.Controls)
                {
                    if (control is DonDatHangControl)
                    {
                        DonDatHangControl donDatHangControl = (DonDatHangControl)control;

                        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                        chiTietHoaDon.maHoaDon = IDGenerator.GenerateHoaDonID();
                        chiTietHoaDon.maSanPham = donDatHangControl.sanPham.maSanPham;
                        chiTietHoaDon.tenSanPham = donDatHangControl.sanPham.tenSanPham;
                        chiTietHoaDon.soLuong = (int)donDatHangControl.soLuongNumericUpDown.Value;
                        chiTietHoaDon.donGia = donDatHangControl.sanPham.giaBan;
                        chiTietHoaDon.tongTien = Decimal.Parse(donDatHangControl.tongGiaLabel.Text.Replace(" VNĐ", "").Replace(",", ""));

                        listChiTietHoaDon.Add(chiTietHoaDon);
                    }
                }

                string message = new HoaDonBUS().ThemHoaDon(listChiTietHoaDon, maNhanVien, maKhachHang, maKhuyenMai, tongTien, giamGia, thanhTien, tienNhan, tienThua);



                if (message.Equals("Thanh toán thành công!"))
                {
                    CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.SUCCESS);
                    listSanPham = sanPhamBUS.LayDanhSachSanPham();
                    LoadDataToFlowLayout(listSanPham);
                    lamMoiSanPhamButton_Click(sender, e);
                    lamMoiKhachHangButton_Click(sender, e);
                    lamMoiKhuyenMaiButton_Click(sender, e);
                    List<Control> controlsToRemove = new List<Control>();

                    foreach (Control control in chiTietDonHangFlowLayoutPanel.Controls)
                    {
                        controlsToRemove.Add(control);
                    }

                    foreach (Control control in controlsToRemove)
                    {
                        chiTietDonHangFlowLayoutPanel.Controls.Remove(control);
                        control.Dispose();
                    }
                    tongTienLabel.Text = "0 VNĐ";
                    tienNhanTextBox.Text = "0";
                }
                else
                {
                    CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.WARNING);
                }
            }
        }

        private void themMoiNguoiDungButton_Click(object sender, EventArgs e)
        {
            new ChiTietKhachHangForm("Thêm", this).ShowDialog();
        }
    }
}
