namespace GUI.CacFormChon
{
    partial class TestChonKhuyenMaiForm
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
            khuyenMaiDataGridView = new DataGridView();
            maKhuyenMaiColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            chonKhuyenMaiButtonColumn = new DataGridViewButtonColumn();
            timKiemTextBox = new TextBox();
            timKiemButton = new Button();
            lamMoiButton = new Button();
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).BeginInit();
            SuspendLayout();
            // 
            // khuyenMaiDataGridView
            // 
            khuyenMaiDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khuyenMaiDataGridView.Columns.AddRange(new DataGridViewColumn[] { maKhuyenMaiColumn, Column1, Column2, Column3, Column4, Column5, chonKhuyenMaiButtonColumn });
            khuyenMaiDataGridView.Location = new Point(12, 41);
            khuyenMaiDataGridView.Name = "khuyenMaiDataGridView";
            khuyenMaiDataGridView.RowTemplate.Height = 25;
            khuyenMaiDataGridView.Size = new Size(776, 259);
            khuyenMaiDataGridView.TabIndex = 0;
            khuyenMaiDataGridView.CellContentClick += khuyenMaiDataGridView_CellContentClick;
            // 
            // maKhuyenMaiColumn
            // 
            maKhuyenMaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhuyenMaiColumn.HeaderText = "Mã khuyến mãi";
            maKhuyenMaiColumn.Name = "maKhuyenMaiColumn";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Tên khuyến mãi";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Loại giá trị";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Giá trị áp dụng";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Thời gian bắt đầu";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Thời gian kết thúc";
            Column5.Name = "Column5";
            // 
            // chonKhuyenMaiButtonColumn
            // 
            chonKhuyenMaiButtonColumn.HeaderText = "Chọn khuyến mãi";
            chonKhuyenMaiButtonColumn.Name = "chonKhuyenMaiButtonColumn";
            chonKhuyenMaiButtonColumn.Text = "Chọn";
            chonKhuyenMaiButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(12, 12);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.Size = new Size(614, 23);
            timKiemTextBox.TabIndex = 1;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // timKiemButton
            // 
            timKiemButton.Location = new Point(632, 12);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(75, 23);
            timKiemButton.TabIndex = 2;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = true;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // lamMoiButton
            // 
            lamMoiButton.Location = new Point(713, 12);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(75, 23);
            lamMoiButton.TabIndex = 3;
            lamMoiButton.Text = "Làm mới";
            lamMoiButton.UseVisualStyleBackColor = true;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // TestChonKhuyenMaiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 307);
            Controls.Add(lamMoiButton);
            Controls.Add(timKiemButton);
            Controls.Add(timKiemTextBox);
            Controls.Add(khuyenMaiDataGridView);
            Name = "TestChonKhuyenMaiForm";
            Text = "TestChonKhuyenMaiForm";
            FormClosed += TestChonKhuyenMaiForm_FormClosed;
            Load += TestChonKhuyenMaiForm_Load;
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView khuyenMaiDataGridView;
        private TextBox timKiemTextBox;
        private Button timKiemButton;
        private Button lamMoiButton;
        private DataGridViewTextBoxColumn maKhuyenMaiColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn chonKhuyenMaiButtonColumn;
    }
}