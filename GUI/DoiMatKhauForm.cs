using BUS;
using DTO;
using GUI.CacFormChiTiet;
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
    public partial class DoiMatKhauForm : Form
    {
        NguoiDung nguoiDung;
        ChiTietNguoiDungForm form;
        public DoiMatKhauForm(ChiTietNguoiDungForm form, NguoiDung nguoiDung)
        {
            InitializeComponent();
            CenterToParent();
            this.nguoiDung = nguoiDung;
            this.form = form;
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            matKhauCuTextBox.Clear();
            matKhauMoiTextBox.Clear();
            xacNhanMatKhauMoiTextBox.Clear();
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đổi mật khẩu mới không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string maNguoiDung = nguoiDung.maNguoiDung;
                string matKhauCu = matKhauCuTextBox.Text.Trim();
                string matKhauMoi = matKhauMoiTextBox.Text.Trim();
                string xacNhan = xacNhanMatKhauMoiTextBox.Text.Trim();


                string message = new NguoiDungBUS().DoiMatKhau(maNguoiDung, matKhauCu, matKhauMoi, xacNhan);

                MessageBox.Show(message);

                if (message.Equals("Đổi mật khẩu thành công!"))
                {
                    form.nguoiDung = new NguoiDungBUS().LayNguoiDungTheoMa(maNguoiDung);
                    form.ChiTietNguoiDungForm_Load(sender, e);

                    this.Close();
                }
            }
        }
    }
}
