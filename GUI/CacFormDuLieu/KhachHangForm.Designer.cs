namespace GUI
{
    partial class KhachHangForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            hangThanhVienComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            khachHangDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            maKhachHangColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            infoButtonColumn = new DataGridViewImageColumn();
            editButtonColumn = new DataGridViewImageColumn();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)khachHangDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2HtmlLabel4);
            panel2.Controls.Add(hangThanhVienComboBox);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(xuatExcelButton);
            panel2.Controls.Add(themMoiButton);
            panel2.Controls.Add(timKiemButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 84);
            panel2.TabIndex = 44;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 14.25F);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(0, 79, 111);
            guna2HtmlLabel4.Location = new Point(12, 5);
            guna2HtmlLabel4.Margin = new Padding(5);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(142, 27);
            guna2HtmlLabel4.TabIndex = 101;
            guna2HtmlLabel4.Text = "Hạng thành viên ";
            // 
            // hangThanhVienComboBox
            // 
            hangThanhVienComboBox.BackColor = Color.Transparent;
            hangThanhVienComboBox.CustomizableEdges = customizableEdges1;
            hangThanhVienComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            hangThanhVienComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hangThanhVienComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            hangThanhVienComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            hangThanhVienComboBox.Font = new Font("Segoe UI", 10F);
            hangThanhVienComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            hangThanhVienComboBox.ItemHeight = 30;
            hangThanhVienComboBox.Items.AddRange(new object[] { "Đồng", "Bạc", "Vàng" });
            hangThanhVienComboBox.Location = new Point(12, 36);
            hangThanhVienComboBox.Name = "hangThanhVienComboBox";
            hangThanhVienComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            hangThanhVienComboBox.Size = new Size(203, 36);
            hangThanhVienComboBox.TabIndex = 89;
            hangThanhVienComboBox.SelectionChangeCommitted += hangThanhVienComboBox_SelectionChangeCommitted;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges3;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 12F);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(237, 36);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timKiemTextBox.Size = new Size(592, 36);
            timKiemTextBox.TabIndex = 86;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // lamMoiButton
            // 
            lamMoiButton.BackColor = Color.FromArgb(33, 31, 48);
            lamMoiButton.FlatAppearance.BorderSize = 0;
            lamMoiButton.FlatStyle = FlatStyle.Flat;
            lamMoiButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            lamMoiButton.IconColor = Color.White;
            lamMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            lamMoiButton.IconSize = 20;
            lamMoiButton.Location = new Point(886, 36);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 84;
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // xuatExcelButton
            // 
            xuatExcelButton.BackColor = Color.FromArgb(33, 31, 48);
            xuatExcelButton.FlatAppearance.BorderSize = 0;
            xuatExcelButton.FlatStyle = FlatStyle.Flat;
            xuatExcelButton.Font = new Font("Microsoft Sans Serif", 12F);
            xuatExcelButton.ForeColor = Color.White;
            xuatExcelButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            xuatExcelButton.IconColor = Color.White;
            xuatExcelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatExcelButton.IconSize = 20;
            xuatExcelButton.ImageAlign = ContentAlignment.MiddleLeft;
            xuatExcelButton.Location = new Point(935, 36);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(115, 36);
            xuatExcelButton.TabIndex = 80;
            xuatExcelButton.Text = "Xuất excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
            xuatExcelButton.Click += xuatExcelButton_Click;
            // 
            // themMoiButton
            // 
            themMoiButton.BackColor = Color.FromArgb(226, 153, 48);
            themMoiButton.FlatAppearance.BorderSize = 0;
            themMoiButton.FlatStyle = FlatStyle.Flat;
            themMoiButton.Font = new Font("Microsoft Sans Serif", 12F);
            themMoiButton.ForeColor = Color.White;
            themMoiButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            themMoiButton.IconColor = Color.White;
            themMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            themMoiButton.IconSize = 20;
            themMoiButton.ImageAlign = ContentAlignment.MiddleLeft;
            themMoiButton.Location = new Point(1056, 36);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 79;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
            themMoiButton.Click += themMoiButton_Click;
            // 
            // timKiemButton
            // 
            timKiemButton.BackColor = Color.FromArgb(226, 153, 48);
            timKiemButton.FlatAppearance.BorderSize = 0;
            timKiemButton.FlatStyle = FlatStyle.Flat;
            timKiemButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            timKiemButton.IconColor = Color.White;
            timKiemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            timKiemButton.IconSize = 20;
            timKiemButton.Location = new Point(837, 36);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 81;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(khachHangDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 84);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 737);
            panel3.TabIndex = 45;
            // 
            // khachHangDataGridView
            // 
            khachHangDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            khachHangDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            khachHangDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            khachHangDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            khachHangDataGridView.ColumnHeadersHeight = 40;
            khachHangDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            khachHangDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, maKhachHangColumn, Column3, Column4, Column6, Column9, Column11, infoButtonColumn, editButtonColumn });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            khachHangDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            khachHangDataGridView.Dock = DockStyle.Fill;
            khachHangDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            khachHangDataGridView.Location = new Point(0, 0);
            khachHangDataGridView.Name = "khachHangDataGridView";
            khachHangDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            khachHangDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            khachHangDataGridView.RowHeadersVisible = false;
            khachHangDataGridView.RowHeadersWidth = 51;
            khachHangDataGridView.RowTemplate.DividerHeight = 3;
            khachHangDataGridView.RowTemplate.Height = 50;
            khachHangDataGridView.Size = new Size(1183, 737);
            khachHangDataGridView.TabIndex = 43;
            khachHangDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            khachHangDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            khachHangDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            khachHangDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            khachHangDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            khachHangDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            khachHangDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            khachHangDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            khachHangDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            khachHangDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            khachHangDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            khachHangDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            khachHangDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            khachHangDataGridView.ThemeStyle.ReadOnly = true;
            khachHangDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            khachHangDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            khachHangDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            khachHangDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            khachHangDataGridView.ThemeStyle.RowsStyle.Height = 50;
            khachHangDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            khachHangDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            khachHangDataGridView.CellContentClick += khachHangDataGridView_CellContentClick;
            khachHangDataGridView.CellFormatting += khachHangDataGridView_CellFormatting;
            khachHangDataGridView.CellPainting += khachHangDataGridView_CellPainting;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 39;
            // 
            // maKhachHangColumn
            // 
            maKhachHangColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhachHangColumn.HeaderText = "Mã khách hàng";
            maKhachHangColumn.MinimumWidth = 6;
            maKhachHangColumn.Name = "maKhachHangColumn";
            maKhachHangColumn.ReadOnly = true;
            maKhachHangColumn.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 120F;
            Column3.HeaderText = "Tên khách hàng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 60F;
            Column4.HeaderText = "Giới tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle4;
            Column6.HeaderText = "Số điện thoại";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 70F;
            Column9.HeaderText = "Hạng thành viên";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.FillWeight = 80F;
            Column11.HeaderText = "Điểm thành viên";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // infoButtonColumn
            // 
            infoButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            infoButtonColumn.FillWeight = 30F;
            infoButtonColumn.HeaderText = "";
            infoButtonColumn.Image = Properties.Resources._003_info;
            infoButtonColumn.MinimumWidth = 6;
            infoButtonColumn.Name = "infoButtonColumn";
            infoButtonColumn.ReadOnly = true;
            infoButtonColumn.Width = 6;
            // 
            // editButtonColumn
            // 
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editButtonColumn.FillWeight = 30F;
            editButtonColumn.HeaderText = "";
            editButtonColumn.Image = Properties.Resources._002_pencil1;
            editButtonColumn.MinimumWidth = 6;
            editButtonColumn.Name = "editButtonColumn";
            editButtonColumn.ReadOnly = true;
            editButtonColumn.Width = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 821);
            panel1.TabIndex = 1;
            // 
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 821);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "KhachHangForm";
            Text = "QUẢN LÝ KHÁCH HÀNG";
            Load += KhachHangForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)khachHangDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView khachHangDataGridView;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private Guna.UI2.WinForms.Guna2ComboBox hangThanhVienComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn maKhachHangColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewImageColumn infoButtonColumn;
        private DataGridViewImageColumn editButtonColumn;
    }
}