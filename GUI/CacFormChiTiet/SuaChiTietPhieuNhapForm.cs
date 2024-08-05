using BUS;
using DocumentFormat.OpenXml.InkML;
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

namespace GUI.CacFormChiTiet
{
    public partial class SuaChiTietPhieuNhapForm : Form
    {
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS;
        ChiTietPhieuNhap chiTietPhieuNhap;
        ChiTietPhieuNhapForm chiTietPhieuNhapForm;

        public SuaChiTietPhieuNhapForm(ChiTietPhieuNhap chiTietPhieuNhap, ChiTietPhieuNhapForm chiTietPhieuNhapForm)
        {
            InitializeComponent();
            CenterToParent();

            chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
            this.chiTietPhieuNhap = chiTietPhieuNhap;
            this.chiTietPhieuNhapForm = chiTietPhieuNhapForm;
        }

        private void SuaChiTietPhieuNhapForm_Load(object sender, EventArgs e)
        {
            maSanPhamTextBox.Text = chiTietPhieuNhap.maSanPham;
            tenSanPhamTextBox.Text = chiTietPhieuNhap.tenSanPham;
            donViTextBox.Text = chiTietPhieuNhap.donVi;
            soLuongNumericUpDown.Value = chiTietPhieuNhap.soLuong;
            giaBanTextBox.Text = chiTietPhieuNhap.giaBan.ToString("0");
            giaNhapTextBox.Text = chiTietPhieuNhap.giaNhap.ToString("0");
            tongTienTextBox.Text = chiTietPhieuNhap.tongTien.ToString("0");
        }

        private void TinhTien()
        {
            int soLuong = (int)soLuongNumericUpDown.Value;
            decimal giaNhap = Decimal.Parse(giaNhapTextBox.Text);
            decimal tongTien = 0;

            tongTien = giaNhap * soLuong;

            tongTienTextBox.Text = tongTien.ToString("0");
        }

        private void soLuongNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void giaNhapTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(giaNhapTextBox.Text))
            {
                giaNhapTextBox.Text = "0";
            }

            TinhTien();
        }

        private void giaBanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(giaBanTextBox.Text))
            {
                giaBanTextBox.Text = "0";
            }
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                soLuongNumericUpDown.Value = chiTietPhieuNhap.soLuong;
                giaBanTextBox.Text = chiTietPhieuNhap.giaBan.ToString("0");
                giaNhapTextBox.Text = chiTietPhieuNhap.giaNhap.ToString("0");
                tongTienTextBox.Text = chiTietPhieuNhap.tongTien.ToString("0");
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin chi tiết phiếu nhập không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                chiTietPhieuNhap.soLuong = (int)soLuongNumericUpDown.Value;
                chiTietPhieuNhap.giaBan = Decimal.Parse(giaBanTextBox.Text);
                chiTietPhieuNhap.giaNhap = Decimal.Parse(giaNhapTextBox.Text);
                chiTietPhieuNhap.tongTien = Decimal.Parse(tongTienTextBox.Text);

                string message = chiTietPhieuNhapBUS.SuaChiTietPhieuNhap(chiTietPhieuNhap);

                MessageBox.Show(message);

                if (message.Equals("Chỉnh sửa chi tiết phiếu nhập thành công!"))
                {
                    chiTietPhieuNhapForm.listChiTietPhieuNhap = chiTietPhieuNhapBUS.LayDanhSachChiTietPhieuNhap(chiTietPhieuNhap.maPhieuNhap);
                    chiTietPhieuNhapForm.LoadDataToDataGridView(chiTietPhieuNhapForm.listChiTietPhieuNhap);
                    
                    this.Close();
                }
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giaBanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void giaNhapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
