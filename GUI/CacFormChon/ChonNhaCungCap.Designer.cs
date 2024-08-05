namespace GUI.CacFormChon
{
    partial class ChonNhaCungCap
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            nhaCungCapDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            quayLaiButton = new FontAwesome.Sharp.IconButton();
            tieuDeFormLabel = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            maNhaCungCapColumn = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            chonNhaCungCapButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nhaCungCapDataGridView
            // 
            nhaCungCapDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            nhaCungCapDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            nhaCungCapDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            nhaCungCapDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            nhaCungCapDataGridView.ColumnHeadersHeight = 40;
            nhaCungCapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            nhaCungCapDataGridView.Columns.AddRange(new DataGridViewColumn[] { maNhaCungCapColumn, Column2, Column3, Column4, Column5, chonNhaCungCapButtonColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            nhaCungCapDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            nhaCungCapDataGridView.Dock = DockStyle.Fill;
            nhaCungCapDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.Location = new Point(0, 0);
            nhaCungCapDataGridView.Margin = new Padding(5);
            nhaCungCapDataGridView.Name = "nhaCungCapDataGridView";
            nhaCungCapDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            nhaCungCapDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            nhaCungCapDataGridView.RowHeadersVisible = false;
            nhaCungCapDataGridView.RowTemplate.DividerHeight = 3;
            nhaCungCapDataGridView.RowTemplate.Height = 50;
            nhaCungCapDataGridView.Size = new Size(949, 389);
            nhaCungCapDataGridView.TabIndex = 28;
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            nhaCungCapDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            nhaCungCapDataGridView.ThemeStyle.ReadOnly = true;
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.Height = 50;
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            nhaCungCapDataGridView.CellContentClick += nhaCungCapDataGridView_CellContentClick;
            nhaCungCapDataGridView.CellPainting += phanQuyenDataGridView_CellPainting;
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
            lamMoiButton.Location = new Point(883, 52);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 72;
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += lamMoiButton_Click;
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
            timKiemButton.Location = new Point(834, 52);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 71;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges1;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(5, 52);
            timKiemTextBox.Margin = new Padding(5, 5, 5, 5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(821, 36);
            timKiemTextBox.TabIndex = 29;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 99);
            panel2.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 79, 111);
            panel4.Controls.Add(quayLaiButton);
            panel4.Controls.Add(tieuDeFormLabel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(949, 44);
            panel4.TabIndex = 73;
            // 
            // quayLaiButton
            // 
            quayLaiButton.Dock = DockStyle.Right;
            quayLaiButton.FlatAppearance.BorderSize = 0;
            quayLaiButton.FlatStyle = FlatStyle.Flat;
            quayLaiButton.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            quayLaiButton.IconColor = Color.White;
            quayLaiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            quayLaiButton.Location = new Point(866, 0);
            quayLaiButton.Name = "quayLaiButton";
            quayLaiButton.Size = new Size(83, 44);
            quayLaiButton.TabIndex = 1;
            quayLaiButton.UseVisualStyleBackColor = true;
            quayLaiButton.Click += quayLaiButton_Click;
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            tieuDeFormLabel.ForeColor = Color.White;
            tieuDeFormLabel.Location = new Point(40, 9);
            tieuDeFormLabel.Margin = new Padding(5, 0, 5, 0);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(235, 29);
            tieuDeFormLabel.TabIndex = 0;
            tieuDeFormLabel.Text = "Chọn nhà cung cấp";
            // 
            // panel3
            // 
            panel3.Controls.Add(nhaCungCapDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 99);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(949, 389);
            panel3.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 488);
            panel1.TabIndex = 4;
            // 
            // maNhaCungCapColumn
            // 
            maNhaCungCapColumn.FillWeight = 80F;
            maNhaCungCapColumn.HeaderText = "Mã nhà cung cấp";
            maNhaCungCapColumn.Name = "maNhaCungCapColumn";
            maNhaCungCapColumn.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 140F;
            Column2.HeaderText = "Tên nhà cung cấp";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 80F;
            Column3.HeaderText = "Số điện thoại";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Địa chỉ";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // chonNhaCungCapButtonColumn
            // 
            chonNhaCungCapButtonColumn.FillWeight = 50F;
            chonNhaCungCapButtonColumn.FlatStyle = FlatStyle.Flat;
            chonNhaCungCapButtonColumn.HeaderText = "Chọn";
            chonNhaCungCapButtonColumn.Name = "chonNhaCungCapButtonColumn";
            chonNhaCungCapButtonColumn.ReadOnly = true;
            chonNhaCungCapButtonColumn.Resizable = DataGridViewTriState.True;
            chonNhaCungCapButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            chonNhaCungCapButtonColumn.Text = "Chọn";
            chonNhaCungCapButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ChonNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 488);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "ChonNhaCungCap";
            Load += TestChonNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView nhaCungCapDataGridView;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton quayLaiButton;
        private Label tieuDeFormLabel;
        private DataGridViewTextBoxColumn maNhaCungCapColumn;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn chonNhaCungCapButtonColumn;
    }
}