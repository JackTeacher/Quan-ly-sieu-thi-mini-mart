namespace GUI.CacFormThongBao
{
    partial class XacNhanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            btnHuyBo = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.BorderRadius = 5;
            btnLuu.CustomizableEdges = customizableEdges1;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.FromArgb(226, 153, 48);
            btnLuu.Font = new Font("Microsoft Sans Serif", 12F);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(253, 181);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLuu.Size = new Size(125, 38);
            btnLuu.TabIndex = 42;
            btnLuu.Text = "Xác nhận";
            btnLuu.Click += ButtonYes_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BorderRadius = 5;
            btnHuyBo.BorderThickness = 1;
            btnHuyBo.CustomizableEdges = customizableEdges3;
            btnHuyBo.DisabledState.BorderColor = Color.DarkGray;
            btnHuyBo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHuyBo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHuyBo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHuyBo.FillColor = Color.White;
            btnHuyBo.Font = new Font("Microsoft Sans Serif", 12F);
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(122, 181);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHuyBo.Size = new Size(125, 38);
            btnHuyBo.TabIndex = 41;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.Click += ButtonNo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(226, 153, 48);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 54);
            panel1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Xác nhận";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(366, 96);
            label2.TabIndex = 44;
            label2.Text = "label2";
            // 
            // XacNhanForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(390, 231);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnLuu);
            Controls.Add(btnHuyBo);
            Font = new Font("Segoe UI", 14.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "XacNhanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XacNhanForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuyBo;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}