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
    public partial class NhapHangForm : Form
    {

        SanPhamBUS sanPhamBUS;
        internal List<SanPham> listSanPham;
        internal List<SanPham> listSanPhamNhapHang;
        internal NhaCungCap nhaCungCap;

        public NhapHangForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.TimKiemSanPham("", "", "", "");
            listSanPhamNhapHang = new List<SanPham>();
            loaiSanPhamComboBox.DataSource = new LoaiSanPhamBUS().LayDanhSachLoaiSanPham();
            loaiSanPhamComboBox.DisplayMember = "tenLoaiSanPham";
            loaiSanPhamComboBox.SelectedIndex = -1;
        }

        private void NhapHangForm_Load(object sender, EventArgs e)
        {
            maNhaCungCapTextBox.ReadOnly = true;
            tenNhaCungCapTextBox.ReadOnly = true;
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
                sanPhamFlowLayoutPanel.Controls.Add(new SanPhamNhapHangUserControl(sanPham, this));
            }
        }

        private void loaiSanPhamComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string maLoaiSanPham = "";
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                LoaiSanPham loaiSanPham = loaiSanPhamComboBox.SelectedValue as LoaiSanPham;
                maLoaiSanPham = loaiSanPham.maLoaiSanPham;
            }
            listSanPham = sanPhamBUS.TimKiemSanPham(tuKhoa, maLoaiSanPham, "", "");
            LoadDataToFlowLayout(listSanPham);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        internal void lamMoiSanPhamButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            loaiSanPhamComboBox.SelectedItem = null;
            loaiSanPhamComboBox.SelectedIndex = -1;
            listSanPham = sanPhamBUS.TimKiemSanPham("", "", "", "");
            LoadDataToFlowLayout(listSanPham);
        }

        private void themSanPhamButton_Click(object sender, EventArgs e)
        {
            new ChiTietSanPhamForm("Thêm", this).Show();
        }

        private void chonNhaCungCapButton_Click(object sender, EventArgs e)
        {
            new ChonNhaCungCap(this).Show();
        }

        private void themMoiNhaCungCapButton_Click(object sender, EventArgs e)
        {
            new ChiTietNhaCungCapForm("Thêm", this).Show();
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null)
                CanhBaoForm.ShowAlertMessage("Vui lòng chọn nhà cung cấp để thao tác", CanhBaoForm.AlertType.WARNING);
            else
            {
                if (listSanPhamNhapHang.Count <= 0)
                    CanhBaoForm.ShowAlertMessage("Phiếu nhập trống", CanhBaoForm.AlertType.WARNING);
                else
                {
                    DialogResult result = XacNhanForm.ShowDialog("Xác nhận tạo phiếu nhập?");

                    if (result == DialogResult.Yes)
                    {
                        string maPhieuNhap = IDGenerator.GeneratePhieuNhapID();
                        string maNhaCungCap = nhaCungCap.maNhaCungCap;
                        string maNguoiTao = DangNhapForm.nguoiDung.maNguoiDung;
                        string thanhTien = thanhTienLabel.Text.Replace(" VNĐ", "").Replace(",", "");

                        List<ChiTietPhieuNhap> listChiTietPhieuNhap = new List<ChiTietPhieuNhap>();

                        foreach (Control control in chiTietDonHangFlowLayoutPanel.Controls)
                        {
                            if (control is DonNhapHangUserControl)
                            {
                                DonNhapHangUserControl donNhapHangUserControl = (DonNhapHangUserControl)control;

                                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();

                                chiTietPhieuNhap.maPhieuNhap = IDGenerator.GeneratePhieuNhapID();
                                chiTietPhieuNhap.maSanPham = donNhapHangUserControl.sanPham.maSanPham;
                                chiTietPhieuNhap.tenSanPham = donNhapHangUserControl.sanPham.tenSanPham;
                                chiTietPhieuNhap.soLuong = (int)donNhapHangUserControl.soLuongNumericUpDown.Value;
                                chiTietPhieuNhap.giaBan = Decimal.Parse(donNhapHangUserControl.giaBanTextBox.Text.Replace(" VNĐ", "").Replace(",", ""));
                                chiTietPhieuNhap.giaNhap = Decimal.Parse(donNhapHangUserControl.giaNhapTextBox.Text.Replace(" VNĐ", "").Replace(",", "")); 
                                chiTietPhieuNhap.tongTien = Decimal.Parse(donNhapHangUserControl.tongGiaLabel.Text.Replace(" VNĐ", "").Replace(",", ""));

                                listChiTietPhieuNhap.Add(chiTietPhieuNhap);
                            }
                        }

                        string message = new PhieuNhapBUS().ThemPhieuNhap(listChiTietPhieuNhap, maPhieuNhap, maNhaCungCap, maNguoiTao, thanhTien);



                        if (message.Equals("Thêm phiếu nhập thành công!"))
                        {
                            CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.SUCCESS);
                            listSanPhamNhapHang.Clear();
                            nhaCungCap = null;
                            maNhaCungCapTextBox.Clear();
                            tenNhaCungCapTextBox.Clear();
                            lamMoiSanPhamButton_Click(sender, e);
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
                            controlsToRemove.Clear();
                            foreach (Control control in sanPhamFlowLayoutPanel.Controls)
                            {
                                controlsToRemove.Add(control);
                            }

                            foreach (Control control in controlsToRemove)
                            {
                                sanPhamFlowLayoutPanel.Controls.Remove(control);
                                control.Dispose();
                            }
                            thanhTienLabel.Text = "0 VNĐ";
                            listSanPham = sanPhamBUS.TimKiemSanPham("", "", "", "");
                            LoadDataToFlowLayout(listSanPham);
                        }
                        else
                        {
                            CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.WARNING);
                        }
                    }
                }
            }
        }

        
    }
}
