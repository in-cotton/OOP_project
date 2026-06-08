namespace project_cs.Source.UI
{
    partial class MainMenuForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSubTitle = new Label();
            grpBoardSize = new GroupBox();
            rbSmall = new RadioButton();
            rbMedium = new RadioButton();
            rbLarge = new RadioButton();
            btnStart = new Button();
            tabRanking = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dgvbRanking = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            column2 = new DataGridViewTextBoxColumn();
            column3 = new DataGridViewTextBoxColumn();
            column4 = new DataGridViewTextBoxColumn();
            dgvmRanking = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dgvsRanking = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            grpBoardSize.SuspendLayout();
            tabRanking.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbRanking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvmRanking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvsRanking).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("맑은 고딕", 21.73585F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTitle.Location = new Point(350, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "사과게임";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Location = new Point(250, 85);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(500, 20);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "드래그해서 합이 10이 되는 사과를 제거하세요";
            lblSubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpBoardSize
            // 
            grpBoardSize.BackColor = SystemColors.ButtonHighlight;
            grpBoardSize.Controls.Add(rbLarge);
            grpBoardSize.Controls.Add(rbMedium);
            grpBoardSize.Controls.Add(rbSmall);
            grpBoardSize.Location = new Point(200, 115);
            grpBoardSize.Name = "grpBoardSize";
            grpBoardSize.Size = new Size(600, 80);
            grpBoardSize.TabIndex = 2;
            grpBoardSize.TabStop = false;
            grpBoardSize.Text = "보드 크기 선택";
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(50, 35);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(85, 21);
            rbSmall.TabIndex = 0;
            rbSmall.TabStop = true;
            rbSmall.Text = "소형 (7x7)";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(246, 35);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(99, 21);
            rbMedium.TabIndex = 1;
            rbMedium.TabStop = true;
            rbMedium.Text = "중형 (10x10)";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(451, 35);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(99, 21);
            rbLarge.TabIndex = 2;
            rbLarge.TabStop = true;
            rbLarge.Text = "대형 (14x14)";
            rbLarge.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ActiveCaption;
            btnStart.Font = new Font("맑은 고딕", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnStart.Location = new Point(400, 215);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 45);
            btnStart.TabIndex = 3;
            btnStart.Text = "게임시작";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // tabRanking
            // 
            tabRanking.Controls.Add(tabPage1);
            tabRanking.Controls.Add(tabPage2);
            tabRanking.Controls.Add(tabPage3);
            tabRanking.Location = new Point(70, 270);
            tabRanking.Name = "tabRanking";
            tabRanking.SelectedIndex = 0;
            tabRanking.Size = new Size(850, 450);
            tabRanking.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvsRanking);
            tabPage1.Font = new Font("맑은 고딕", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 129);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(842, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "소형";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvmRanking);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(842, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "중형";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvbRanking);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(842, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "대형";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvbRanking
            // 
            dgvbRanking.AllowUserToAddRows = false;
            dgvbRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvbRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvbRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbRanking.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvbRanking.DefaultCellStyle = dataGridViewCellStyle8;
            dgvbRanking.Dock = DockStyle.Fill;
            dgvbRanking.Location = new Point(3, 3);
            dgvbRanking.Name = "dgvbRanking";
            dgvbRanking.RowHeadersVisible = false;
            dgvbRanking.RowHeadersWidth = 45;
            dgvbRanking.Size = new Size(836, 414);
            dgvbRanking.TabIndex = 0;
            // 
            // column1
            // 
            column1.HeaderText = "순위";
            column1.MinimumWidth = 6;
            column1.Name = "column1";
            // 
            // column2
            // 
            column2.HeaderText = "닉네임";
            column2.MinimumWidth = 6;
            column2.Name = "column2";
            // 
            // column3
            // 
            column3.HeaderText = "점수";
            column3.MinimumWidth = 6;
            column3.Name = "column3";
            // 
            // column4
            // 
            column4.HeaderText = "날짜";
            column4.MinimumWidth = 6;
            column4.Name = "column4";
            // 
            // dgvmRanking
            // 
            dgvmRanking.AllowUserToAddRows = false;
            dgvmRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvmRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvmRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmRanking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvmRanking.DefaultCellStyle = dataGridViewCellStyle10;
            dgvmRanking.Dock = DockStyle.Fill;
            dgvmRanking.Location = new Point(3, 3);
            dgvmRanking.Name = "dgvmRanking";
            dgvmRanking.RowHeadersVisible = false;
            dgvmRanking.RowHeadersWidth = 45;
            dgvmRanking.Size = new Size(836, 414);
            dgvmRanking.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "순위";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "닉네임";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "점수";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "날짜";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dgvsRanking
            // 
            dgvsRanking.AllowUserToAddRows = false;
            dgvsRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("맑은 고딕", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvsRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvsRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsRanking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvsRanking.DefaultCellStyle = dataGridViewCellStyle12;
            dgvsRanking.Dock = DockStyle.Fill;
            dgvsRanking.Location = new Point(3, 3);
            dgvsRanking.Name = "dgvsRanking";
            dgvsRanking.RowHeadersVisible = false;
            dgvsRanking.RowHeadersWidth = 45;
            dgvsRanking.Size = new Size(836, 414);
            dgvsRanking.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "순위";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "닉네임";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "점수";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "날짜";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 737);
            Controls.Add(tabRanking);
            Controls.Add(btnStart);
            Controls.Add(grpBoardSize);
            Controls.Add(lblSubTitle);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "Form1";
            grpBoardSize.ResumeLayout(false);
            grpBoardSize.PerformLayout();
            tabRanking.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvbRanking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvmRanking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvsRanking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubTitle;
        private GroupBox grpBoardSize;
        private RadioButton rbLarge;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private Button btnStart;
        private TabControl tabRanking;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgvbRanking;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn column2;
        private DataGridViewTextBoxColumn column3;
        private DataGridViewTextBoxColumn column4;
        private DataGridView dgvsRanking;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridView dgvmRanking;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}