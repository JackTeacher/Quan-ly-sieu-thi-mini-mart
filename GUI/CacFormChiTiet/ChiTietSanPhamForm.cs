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
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietSanPhamForm : Form
    {
        SanPhamBUS sanPhamBUS;
        SanPham sanPham;
        string context;
        SanPhamForm form;
        NhapHangForm nhapHangForm;
        List<LoaiSanPham> listLoaiSanPham;

        public ChiTietSanPhamForm(SanPham sanPham, string context, SanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();

            sanPhamBUS = new SanPhamBUS();
            this.sanPham = sanPham;
            this.context = context;
            this.form = form;
        }

        public ChiTietSanPhamForm(string context, SanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();

            sanPhamBUS = new SanPhamBUS();
            this.context = context;
            this.form = form;
        }

        public ChiTietSanPhamForm(string context, NhapHangForm nhapHangForm)
        {
            InitializeComponent();
            CenterToParent();

            sanPhamBUS = new SanPhamBUS();
            this.context = context;
            this.nhapHangForm = nhapHangForm;
        }

        private void ChiTietSanPhamForm_Load(object sender, EventArgs e)
        {
            listLoaiSanPham = new LoaiSanPhamBUS().LayDanhSachLoaiSanPham();
            loaiSanPhamComboBox.DataSource = listLoaiSanPham;
            loaiSanPhamComboBox.DisplayMember = "tenLoaiSanPham";
            loaiSanPhamComboBox.SelectedIndex = -1;

            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết sản phẩm";

                    maSanPhamTextBox.Text = sanPham.maSanPham;
                    tenSanPhamTextBox.Text = sanPham.tenSanPham;
                    foreach (var item in loaiSanPhamComboBox.Items)
                    {
                        LoaiSanPham loaiSanPham = item as LoaiSanPham;
                        if (loaiSanPham.maLoaiSanPham.Equals(sanPham.maLoaiSanPham))
                        {
                            loaiSanPhamComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    donViTextBox.Text = sanPham.donVi;
                    soLuongNumericUpDown.Value = sanPham.soLuong;
                    giaBanTextBox.Text = sanPham.giaBan.ToString("0");
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    anhSanPhamPictureBox.Image = ImageHelper.ScaleImage(ImageHelper.ByteArrayToImage(sanPham.duLieuAnh), anhSanPhamPictureBox.Width, anhSanPhamPictureBox.Height);

                    maSanPhamTextBox.ReadOnly = true;
                    tenSanPhamTextBox.ReadOnly = true;
                    loaiSanPhamComboBox.Enabled = false;
                    donViTextBox.ReadOnly = true;
                    soLuongNumericUpDown.Enabled = false;
                    giaBanTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    chonAnhButton.Visible = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm sản phẩm";

                    maSanPhamTextBox.Text = IDGenerator.GenerateSanPhamID();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Chờ xử lý"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maSanPhamTextBox.ReadOnly = true;
                    soLuongNumericUpDown.Enabled = false;
                    trangThaiComboBox.Enabled = false;
                    giaBanTextBox.ReadOnly = true;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin sản phẩm";

                    maSanPhamTextBox.Text = sanPham.maSanPham;
                    tenSanPhamTextBox.Text = sanPham.tenSanPham;
                    foreach (var item in loaiSanPhamComboBox.Items)
                    {
                        LoaiSanPham loaiSanPham = item as LoaiSanPham;
                        if (loaiSanPham.maLoaiSanPham.Equals(sanPham.maLoaiSanPham))
                        {
                            loaiSanPhamComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    donViTextBox.Text = sanPham.donVi;
                    soLuongNumericUpDown.Value = sanPham.soLuong;
                    giaBanTextBox.Text = sanPham.giaBan.ToString("0");
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    if (sanPham.trangThai.Equals("Ngừng kinh doanh"))
                    {
                        foreach(var item in trangThaiComboBox.Items)
                        {
                            if (!item.ToString().Equals("Chờ xử lý"))
                                trangThaiComboBox.Items.Remove(item);
                        }
                    }
                    if (sanPham.trangThai.Equals("Chờ xử lý"))
                    {
                        foreach (var item in trangThaiComboBox.Items)
                        {
                            if (item.ToString().Equals("Đang bán") || item.ToString().Equals("Hết hàng"))
                                trangThaiComboBox.Items.Remove(item);
                        }
                    }
                    if (!sanPham.trangThai.Equals("Đang bán"))
                    {
                        giaBanTextBox.ReadOnly = true;
                    }
                    anhSanPhamPictureBox.Image = ImageHelper.ByteArrayToImage(sanPham.duLieuAnh);

                    maSanPhamTextBox.ReadOnly = true;
                    soLuongNumericUpDown.Enabled = false;

                    break;
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chonAnhButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = new Bitmap(openFileDialog.FileName);

                anhSanPhamPictureBox.Image = ImageHelper.ScaleImage(selectedImage, anhSanPhamPictureBox.Width, anhSanPhamPictureBox.Height);
            }
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn hủy thông tin đã nhập?");

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    tenSanPhamTextBox.Text = sanPham.tenSanPham;
                    foreach (var item in loaiSanPhamComboBox.Items)
                    {
                        LoaiSanPham loaiSanPham = item as LoaiSanPham;
                        if (loaiSanPham.maLoaiSanPham.Equals(sanPham.maLoaiSanPham))
                        {
                            loaiSanPhamComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    donViTextBox.Text = sanPham.donVi;
                    soLuongNumericUpDown.Value = sanPham.soLuong;
                    giaBanTextBox.Text = sanPham.giaBan.ToString("0");
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    anhSanPhamPictureBox.Image = ImageHelper.ByteArrayToImage(sanPham.duLieuAnh);
                }
                else if (context.Equals("Thêm"))
                {
                    tenSanPhamTextBox.Clear();
                    loaiSanPhamComboBox.SelectedItem = null;
                    loaiSanPhamComboBox.SelectedIndex = -1;
                    donViTextBox.Clear();
                    giaBanTextBox.Clear();
                    anhSanPhamPictureBox.Image = Properties.Resources.gallery;
                }
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn lưu thông tin sản phẩm?");

            if (result == DialogResult.Yes)
            {
                string maSanPham = maSanPhamTextBox.Text;
                string tenSanPham = tenSanPhamTextBox.Text;
                string maLoaiSanPham = "";
                if (loaiSanPhamComboBox.SelectedValue != null)
                {
                    LoaiSanPham loaiSanPham = loaiSanPhamComboBox.SelectedValue as LoaiSanPham;
                    maLoaiSanPham = loaiSanPham.maLoaiSanPham;
                }
                string donVi = donViTextBox.Text;
                string giaBan = giaBanTextBox.Text;
                byte[] duLieuAnh;
                try
                {
                    duLieuAnh = ImageHelper.ImageToByteArray(anhSanPhamPictureBox.Image);
                }
                catch
                {
                    duLieuAnh = sanPham.duLieuAnh;
                }
                string trangThai = trangThaiComboBox.SelectedItem.ToString();

                string message = "";

                switch (context)
                {
                    case "Thêm":
                        message = sanPhamBUS.ThemSanPham(maSanPham, maLoaiSanPham,tenSanPham, donVi, giaBan, duLieuAnh);
                        break;
                    case "Sửa":
                        message = sanPhamBUS.SuaSanPham(maSanPham, maLoaiSanPham, tenSanPham, donVi, giaBan, duLieuAnh, trangThai);
                        break;
                }

                
                if (message.Equals("Thêm sản phẩm thành công!") || message.Equals("Chỉnh sửa thông tin sản phẩm thành công!"))
                {
                    if (form != null)
                        form.lamMoiButton_Click(sender, e);
                    if (nhapHangForm != null)
                        nhapHangForm.lamMoiSanPhamButton_Click(sender, e);
                    CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.SUCCESS);

                    this.Close();
                }
                else
                {
                    CanhBaoForm.ShowAlertMessage(message, CanhBaoForm.AlertType.WARNING);
                    
                }
            }
        }

        private void giaBanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giaBanTextBox.Text))
            {
                giaBanTextBox.Text = "0"; 
            }
        }

        private void giaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
