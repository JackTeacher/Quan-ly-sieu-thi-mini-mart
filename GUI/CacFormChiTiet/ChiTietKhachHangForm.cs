using BUS;
using BUS.OtherFunctions;
using DTO;
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
    public partial class ChiTietKhachHangForm : Form
    {
        KhachHangBUS khachHangBUS;
        KhachHang khachHang;
        KhachHangForm khachHangForm;
        string context;
        BanHangForm banHangForm;

        public ChiTietKhachHangForm(KhachHang khachHang, string context, KhachHangForm khachHangForm)
        {
            InitializeComponent();
            CenterToParent();

            khachHangBUS = new KhachHangBUS();
            this.khachHang = khachHang;
            this.context = context;
            this.khachHangForm = khachHangForm;
        }

        public ChiTietKhachHangForm(string context, KhachHangForm khachHangForm)
        {
            InitializeComponent();
            CenterToParent();

            khachHangBUS = new KhachHangBUS();
            this.context = context;
            this.khachHangForm = khachHangForm;
        }

        public ChiTietKhachHangForm(string context, BanHangForm banHangForm)
        {
            InitializeComponent();
            CenterToParent();

            khachHangBUS = new KhachHangBUS();
            this.context = context;
            this.banHangForm = banHangForm;
        }

        private void ChiTietKhachHangForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết khách hàng";

                    maKhachHangTextBox.Text = khachHang.maKhachHang;
                    tenKhachHangTextBox.Text = khachHang.hoTen;
                    if (khachHang.gioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    else if (khachHang.gioiTinh.Equals("Nữ"))
                        nuRadioButton.Checked = true;
                    if (khachHang.ngaySinh.HasValue)
                        ngaySinhDateTimePicker.Value = khachHang.ngaySinh.Value;
                    soDienThoaiTextBox.Text = khachHang.soDienThoai;
                    emailTextBox.Text = khachHang.email;
                    diaChiTextBox.Text = khachHang.diaChi;
                    diemTichLuyTextBox.Text = khachHang.diemThanhVien.ToString();
                    foreach (var item in bacThanhVienComboBox.Items)
                    {
                        if (item.ToString().Equals(khachHang.hangThanhVien))
                        {
                            bacThanhVienComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maKhachHangTextBox.ReadOnly = true;
                    tenKhachHangTextBox.ReadOnly = true;
                    namRadioButton.Enabled = false;
                    nuRadioButton.Enabled = false;
                    if (khachHang.ngaySinh.HasValue)
                        ngaySinhDateTimePicker.Checked = true;
                    else
                        ngaySinhDateTimePicker.Checked = false;
                    ngaySinhDateTimePicker.Enabled = false;
                    soDienThoaiTextBox.ReadOnly = true;
                    emailTextBox.ReadOnly = true;
                    diaChiTextBox.ReadOnly = true;
                    diemTichLuyTextBox.ReadOnly = true;
                    bacThanhVienComboBox.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm khách hàng";

                    maKhachHangTextBox.Text = IDGenerator.GenerateKhachHangID();
                    foreach (var item in bacThanhVienComboBox.Items)
                    {
                        if (item.ToString().Equals("Đồng"))
                        {
                            bacThanhVienComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maKhachHangTextBox.ReadOnly = true;
                    ngaySinhDateTimePicker.Checked = false;
                    diemTichLuyTextBox.ReadOnly = true;
                    diemTichLuyTextBox.Text = "0";
                    bacThanhVienComboBox.Enabled = false;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin khách hàng";

                    maKhachHangTextBox.Text = khachHang.maKhachHang;
                    tenKhachHangTextBox.Text = khachHang.hoTen;
                    if (khachHang.gioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    else if (khachHang.gioiTinh.Equals("Nữ"))
                        nuRadioButton.Checked = true;
                    if (khachHang.ngaySinh.HasValue)
                        ngaySinhDateTimePicker.Value = khachHang.ngaySinh.Value;
                    soDienThoaiTextBox.Text = khachHang.soDienThoai;
                    emailTextBox.Text = khachHang.email;
                    diaChiTextBox.Text = khachHang.diaChi;
                    diemTichLuyTextBox.Text = khachHang.diemThanhVien.ToString();
                    foreach (var item in bacThanhVienComboBox.Items)
                    {
                        if (item.ToString().Equals(khachHang.hangThanhVien))
                        {
                            bacThanhVienComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maKhachHangTextBox.ReadOnly = true;
                    if (khachHang.ngaySinh.HasValue)
                        ngaySinhDateTimePicker.Checked = true;
                    else
                        ngaySinhDateTimePicker.Checked = false;
                    diemTichLuyTextBox.ReadOnly = true;
                    bacThanhVienComboBox.Enabled = false;

                    break;
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    tenKhachHangTextBox.Text = khachHang.hoTen;
                    if (khachHang.gioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    else if (khachHang.gioiTinh.Equals("Nữ"))
                        nuRadioButton.Checked = true;
                    if (khachHang.ngaySinh.HasValue)
                        ngaySinhDateTimePicker.Value = khachHang.ngaySinh.Value;
                    soDienThoaiTextBox.Text = khachHang.soDienThoai;
                    emailTextBox.Text = khachHang.email;
                    diaChiTextBox.Text = khachHang.diaChi;
                    diemTichLuyTextBox.Text = khachHang.diemThanhVien.ToString();
                }
                else if (context.Equals("Thêm"))
                {
                    tenKhachHangTextBox.Clear();
                    namRadioButton.Checked = false;
                    nuRadioButton.Checked = false;
                    ngaySinhDateTimePicker.Checked = false;
                    soDienThoaiTextBox.Clear();
                    emailTextBox.Clear();
                    diaChiTextBox.Clear();
                }
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn lưu thông tin khách hàng?");


            if (result == DialogResult.Yes)
            {
                string maKhachHang = maKhachHangTextBox.Text;
                string tenKhachHang = tenKhachHangTextBox.Text;
                string gioiTinh = "";
                if (namRadioButton.Checked)
                    gioiTinh = namRadioButton.Text;
                else if (nuRadioButton.Checked)
                    gioiTinh = nuRadioButton.Text;
                string ngaySinh = "";
                if (ngaySinhDateTimePicker.Checked)
                    ngaySinh = ngaySinhDateTimePicker.Value.ToString("dd/MM/yyyy");
                string soDienThoai = soDienThoaiTextBox.Text;
                string email = emailTextBox.Text;
                string diaChi = diaChiTextBox.Text;

                string message = "";

                switch (context)
                {
                    case "Thêm":
                        message = khachHangBUS.ThemKhachHang(maKhachHang, tenKhachHang, gioiTinh, ngaySinh, soDienThoai, email, diaChi);
                        break;
                    case "Sửa":
                        message = khachHangBUS.SuaKhachHang(maKhachHang, tenKhachHang, gioiTinh, ngaySinh, soDienThoai, email, diaChi);
                        break;
                }


                if (message.Equals("Thêm khách hàng thành công!") || message.Equals("Chỉnh sửa thông tin khách hàng thành công!"))
                {
                    CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.SUCCESS);
                    
                    if (khachHangForm != null)
                        khachHangForm.lamMoiButton_Click(sender, e);

                    this.Close();
                }
                else
                {
                    CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.WARNING);
                    if (tenKhachHangTextBox.Text.Equals("")) { this.tenKhachHangTextBox.BorderColor = Color.Red; }
                    if (soDienThoaiTextBox.Text.Equals("")) { this.soDienThoaiTextBox.BorderColor = Color.Red; }

                }
            }
        }

        private void soDienThoaiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }
    }


}
