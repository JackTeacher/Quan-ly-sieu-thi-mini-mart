using DTO;
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
    public partial class DonNhapHangUserControl : UserControl
    {
        internal SanPham sanPham;
        NhapHangForm nhapHangForm;

        public DonNhapHangUserControl(SanPham sanPham, NhapHangForm nhapHangForm)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.nhapHangForm = nhapHangForm;
        }

        private void DonNhapHangUserControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.tenSanPham;
            if (sanPham.giaBan != 0)
                giaBanTextBox.Text = sanPham.giaBan.ToString("0");
        }

        private void giaNhapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void giaBanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void giaBanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giaBanTextBox.Text))
                giaBanTextBox.Text = "0";
        }

        private void giaNhapTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giaNhapTextBox.Text))
                giaNhapTextBox.Text = "0";
            decimal tongGia = soLuongNumericUpDown.Value * Decimal.Parse(giaNhapTextBox.Text);
            tongGiaLabel.Text = tongGia.ToString("#,##0") + " VNĐ";
            TinhTien();
        }

        private void soLuongNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal tongGia = soLuongNumericUpDown.Value * Decimal.Parse(giaNhapTextBox.Text);
            tongGiaLabel.Text = tongGia.ToString("#,##0") + " VNĐ";
            TinhTien();
        }

        private void TinhTien()
        {
            decimal thanhTien = 0;

            foreach (Control control in nhapHangForm.chiTietDonHangFlowLayoutPanel.Controls)
            {
                if (control is DonNhapHangUserControl)
                {
                    DonNhapHangUserControl donNhapHangUserControl = (DonNhapHangUserControl)control;
                    decimal tongGia = Decimal.Parse((donNhapHangUserControl.tongGiaLabel.Text.Where(char.IsDigit).ToArray()));
                    thanhTien += tongGia;
                }
            }

            nhapHangForm.thanhTienLabel.Text = thanhTien.ToString("#,##0") + " VNĐ";
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            nhapHangForm.listSanPhamNhapHang.Remove(sanPham);
            nhapHangForm.chiTietDonHangFlowLayoutPanel.Controls.Remove(this);

            TinhTien();

            this.Dispose();
        }
    }
}
