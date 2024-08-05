namespace GUI
{
    partial class ChiTietPhanQuyenForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            btnHuyBo = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtTenPhanQuyen = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaPhanQuyen = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnHuyBo);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTenPhanQuyen);
            panel2.Controls.Add(txtMaPhanQuyen);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 294);
            panel2.TabIndex = 6;
            // 
            // btnLuu
            // 
            btnLuu.BorderRadius = 5;
            btnLuu.CustomizableEdges = customizableEdges1;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.FromArgb(0, 79, 111);
            btnLuu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(427, 190);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLuu.Size = new Size(189, 53);
            btnLuu.TabIndex = 42;
            btnLuu.Text = "Lưu";
            // 
            // btnHuyBo
            // 
            btnHuyBo.BorderColor = Color.FromArgb(0, 79, 111);
            btnHuyBo.BorderRadius = 5;
            btnHuyBo.BorderThickness = 1;
            btnHuyBo.CustomizableEdges = customizableEdges3;
            btnHuyBo.DisabledState.BorderColor = Color.DarkGray;
            btnHuyBo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHuyBo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHuyBo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHuyBo.FillColor = Color.White;
            btnHuyBo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuyBo.ForeColor = Color.FromArgb(0, 79, 111);
            btnHuyBo.Location = new Point(232, 190);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHuyBo.Size = new Size(189, 53);
            btnHuyBo.TabIndex = 41;
            btnHuyBo.Text = "Huỷ bỏ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 79, 111);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 66);
            panel1.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(456, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 66);
            panel3.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(71, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(129, 66);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 29);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết phân quyền ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 79, 111);
            label5.Location = new Point(326, 91);
            label5.Name = "label5";
            label5.Size = new Size(150, 24);
            label5.TabIndex = 31;
            label5.Text = "Tên phân quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 79, 111);
            label2.Location = new Point(26, 91);
            label2.Name = "label2";
            label2.Size = new Size(142, 24);
            label2.TabIndex = 28;
            label2.Text = "Mã phân quyền";
            // 
            // txtTenPhanQuyen
            // 
            txtTenPhanQuyen.BorderColor = Color.FromArgb(0, 79, 111);
            txtTenPhanQuyen.BorderRadius = 5;
            txtTenPhanQuyen.CustomizableEdges = customizableEdges5;
            txtTenPhanQuyen.DefaultText = "";
            txtTenPhanQuyen.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenPhanQuyen.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenPhanQuyen.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenPhanQuyen.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenPhanQuyen.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenPhanQuyen.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenPhanQuyen.Location = new Point(326, 120);
            txtTenPhanQuyen.Margin = new Padding(5, 5, 5, 5);
            txtTenPhanQuyen.Name = "txtTenPhanQuyen";
            txtTenPhanQuyen.PasswordChar = '\0';
            txtTenPhanQuyen.PlaceholderText = "";
            txtTenPhanQuyen.SelectedText = "";
            txtTenPhanQuyen.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTenPhanQuyen.Size = new Size(290, 40);
            txtTenPhanQuyen.TabIndex = 24;
            // 
            // txtMaPhanQuyen
            // 
            txtMaPhanQuyen.BorderColor = Color.FromArgb(0, 79, 111);
            txtMaPhanQuyen.BorderRadius = 5;
            txtMaPhanQuyen.CustomizableEdges = customizableEdges7;
            txtMaPhanQuyen.DefaultText = "";
            txtMaPhanQuyen.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaPhanQuyen.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaPhanQuyen.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaPhanQuyen.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaPhanQuyen.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaPhanQuyen.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaPhanQuyen.Location = new Point(26, 120);
            txtMaPhanQuyen.Margin = new Padding(5, 5, 5, 5);
            txtMaPhanQuyen.Name = "txtMaPhanQuyen";
            txtMaPhanQuyen.PasswordChar = '\0';
            txtMaPhanQuyen.PlaceholderText = "";
            txtMaPhanQuyen.SelectedText = "";
            txtMaPhanQuyen.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtMaPhanQuyen.Size = new Size(290, 40);
            txtMaPhanQuyen.TabIndex = 23;
            // 
            // ChiTietPhanQuyenForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 294);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "ChiTietPhanQuyenForm";
            Text = "CHI TIẾT PHÂN QUYỀN";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuyBo;
        private Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Label label5;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPhanQuyen;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhanQuyen;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}