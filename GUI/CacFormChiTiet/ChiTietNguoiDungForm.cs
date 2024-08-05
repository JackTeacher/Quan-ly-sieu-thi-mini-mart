using BUS;
using BUS.OtherFunctions;
using DTO;
using GUI.CacFormDuLieu;
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
    public partial class ChiTietNguoiDungForm : Form
    {
        internal NguoiDung nguoiDung;
        NguoiDungBUS nguoiDungBUS;
        string context;
        NguoiDungForm form;
        List<PhanQuyen> listPhanQuyen;

        public ChiTietNguoiDungForm(NguoiDung nguoiDung, string context, NguoiDungForm form)
        {
            InitializeComponent();
            CenterToParent();

            nguoiDungBUS = new NguoiDungBUS();
            this.nguoiDung = nguoiDung;
            this.context = context;
            this.form = form;
        }

        public ChiTietNguoiDungForm(string context, NguoiDungForm form)
        {
            InitializeComponent();
            CenterToParent();

            nguoiDungBUS = new NguoiDungBUS();
            this.context = context;
            this.form = form;
        }

        internal void ChiTietNguoiDungForm_Load(object sender, EventArgs e)
        {
            listPhanQuyen = new PhanQuyenBUS().LayDanhSachPhanQuyen();
            phanQuyenComboBox.DataSource = listPhanQuyen;
            phanQuyenComboBox.DisplayMember = "tenPhanQuyen";
            phanQuyenComboBox.SelectedIndex = -1;

            trangThaiComboBox.SelectedIndex = 0;

            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết người dùng";

                    maNguoiDungTextBox.Text = nguoiDung.maNguoiDung;
                    foreach (var item in phanQuyenComboBox.Items)
                    {
                        PhanQuyen phanQuyen = item as PhanQuyen;
                        if (phanQuyen.maPhanQuyen.Equals(nguoiDung.maPhanQuyen))
                        {
                            phanQuyenComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    tenDangNhapTextBox.Text = nguoiDung.tenDangNhap;
                    matKhauTextBox.Text = nguoiDung.matKhau;
                    hoTenTextBox.Text = nguoiDung.hoTen;
                    if (nguoiDung.gioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    else
                        nuRadioButton.Checked = true;
                    if (nguoiDung.ngaySinh.HasValue)
                    {
                        ngaySinhDateTimePicker.Value = nguoiDung.ngaySinh.Value;
                    }
                    else
                        ngaySinhDateTimePicker.Checked = false;
                    soDienThoaiTextBox.Text = nguoiDung.soDienThoai;
                    emailTextBox.Text = nguoiDung.email;
                    diaChiTextBox.Text = nguoiDung.diaChi;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(nguoiDung.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNguoiDungTextBox.ReadOnly = true;
                    phanQuyenComboBox.Enabled = false;
                    tenDangNhapTextBox.ReadOnly = true;
                    matKhauTextBox.ReadOnly = true;
                    doiMatKhauButton.Visible = false;
                    hoTenTextBox.ReadOnly = true;
                    namRadioButton.Enabled = false;
                    nuRadioButton.Enabled = false;
                    ngaySinhDateTimePicker.Enabled = false;
                    soDienThoaiTextBox.ReadOnly = true;
                    emailTextBox.ReadOnly = true;
                    diaChiTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm người dùng";

                    ngaySinhDateTimePicker.Checked = false;
                    
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Đang hoạt động"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNguoiDungTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    doiMatKhauButton.Visible = false;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin người dùng";

                    maNguoiDungTextBox.Text = nguoiDung.maNguoiDung;
                    foreach (var item in phanQuyenComboBox.Items)
                    {
                        PhanQuyen phanQuyen = item as PhanQuyen;
                        if (phanQuyen.maPhanQuyen.Equals(nguoiDung.maPhanQuyen))
                        {
                            phanQuyenComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    tenDangNhapTextBox.Text = nguoiDung.tenDangNhap;
                    matKhauTextBox.Text = nguoiDung.matKhau;
                    hoTenTextBox.Text = nguoiDung.hoTen;
                    if (nguoiDung.gioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    else
                        nuRadioButton.Checked = true;
                    if (nguoiDung.ngaySinh.HasValue)
                    {
                        ngaySinhDateTimePicker.Value = nguoiDung.ngaySinh.Value;
                    }
                    else
                        ngaySinhDateTimePicker.Checked = false;
                    soDienThoaiTextBox.Text = nguoiDung.soDienThoai;
                    emailTextBox.Text = nguoiDung.email;
                    diaChiTextBox.Text = nguoiDung.diaChi;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(nguoiDung.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNguoiDungTextBox.ReadOnly = true;
                    phanQuyenComboBox.Enabled = false;
                    tenDangNhapTextBox.ReadOnly = true;
                    matKhauTextBox.ReadOnly = true;

                    break;
            }
        }

        private void doiMatKhauButton_Click(object sender, EventArgs e)
        {
            new DoiMatKhauForm(this, nguoiDung).ShowDialog();
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void huyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    tenDangNhapTextBox.Text = nguoiDung.tenDangNhap;
                    matKhauTextBox.Text = nguoiDung.matKhau;
                    hoTenTextBox.Text = nguoiDung.hoTen;
                    if (nguoiDung.gioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    else
                        nuRadioButton.Checked = true;
                    if (nguoiDung.ngaySinh.HasValue)
                    {
                        ngaySinhDateTimePicker.Value = nguoiDung.ngaySinh.Value;
                    }
                    else
                        ngaySinhDateTimePicker.Checked = false;
                    soDienThoaiTextBox.Text = nguoiDung.soDienThoai;
                    emailTextBox.Text = nguoiDung.email;
                    diaChiTextBox.Text = nguoiDung.diaChi;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(nguoiDung.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (context.Equals("Thêm"))
                {
                    maNguoiDungTextBox.Clear();
                    phanQuyenComboBox.SelectedItem = null;
                    phanQuyenComboBox.SelectedIndex = -1;
                    tenDangNhapTextBox.Clear();
                    matKhauTextBox.Clear();
                    hoTenTextBox.Clear();
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
            DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn lưu thông tin người dùng?");

            if (result == DialogResult.Yes)
            {
                string maNguoiDung = maNguoiDungTextBox.Text;
                string maPhanQuyen = "";
                if (phanQuyenComboBox.SelectedValue != null)
                {
                    PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                    maPhanQuyen = phanQuyen.maPhanQuyen;
                }
                string tenDangNhap = tenDangNhapTextBox.Text;
                string matKhau = matKhauTextBox.Text;
                string hoTen = hoTenTextBox.Text;
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
                string trangThai = trangThaiComboBox.SelectedItem.ToString();

                string message = "";

                switch (context)
                {
                    case "Thêm":
                        message = nguoiDungBUS.ThemNguoiDung(maNguoiDung, maPhanQuyen, tenDangNhap, matKhau, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi);
                        break;
                    case "Sửa":
                        message = nguoiDungBUS.SuaNguoiDung(maNguoiDung, maPhanQuyen, tenDangNhap, matKhau, hoTen, gioiTinh, ngaySinh, soDienThoai, email, diaChi, trangThai);
                        break;
                }


                if (message.Equals("Thêm người dùng thành công!") || message.Equals("Chỉnh sửa thông tin người dùng thành công!"))
                {
                    if (form != null)
                        form.lamMoiButton_Click(sender, e);
                    CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.SUCCESS);

                    this.Close();
                }
                else
                {
                    CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.WARNING);
                }
            }
        }

        private void soDienThoaiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số, không phải là phím Backspace và không phải là dấu '+'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                // Không cho phép nhập ký tự không phải số hoặc dấu '+'
                e.Handled = true;
            }
        }

        private void tenDangNhapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar == ' ' || !char.IsAscii(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void matKhauTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar == ' ' || !char.IsAscii(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar == ' ' || !char.IsAscii(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void phanQuyenComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (phanQuyenComboBox.SelectedValue != null)
            {
                PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                maNguoiDungTextBox.Text = IDGenerator.GenerateNguoiDungID(phanQuyen.maPhanQuyen);
            }
        }
    }
}
