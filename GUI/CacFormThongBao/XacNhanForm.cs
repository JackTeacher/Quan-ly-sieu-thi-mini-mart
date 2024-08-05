using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CacFormThongBao
{
    public partial class XacNhanForm : Form
    {
        public XacNhanForm(string text)
        {

            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            label2.Text = text;
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Dispose();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Dispose();
        }

        public static DialogResult ShowDialog(string text)
        {
            return (new XacNhanForm(text)).ShowDialog();
        }
    }
}

