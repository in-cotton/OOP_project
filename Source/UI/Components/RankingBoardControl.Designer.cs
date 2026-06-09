namespace project_cs.Source.UI.Components
{
    partial class RankingBoardControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabRanking = new TabControl();
            tabPage1 = new TabPage();
            dgvsRanking = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dgvmRanking = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dgvbRanking = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            column2 = new DataGridViewTextBoxColumn();
            column3 = new DataGridViewTextBoxColumn();
            column4 = new DataGridViewTextBoxColumn();
            tabRanking.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsRanking).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmRanking).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbRanking).BeginInit();
            SuspendLayout();
            // 
            // tabRanking
            // 
            tabRanking.Controls.Add(tabPage1);
            tabRanking.Controls.Add(tabPage2);
            tabRanking.Controls.Add(tabPage3);
            tabRanking.Location = new Point(0, 0);
            tabRanking.Name = "tabRanking";
            tabRanking.SelectedIndex = 0;
            tabRanking.Size = new Size(850, 450);
            tabRanking.TabIndex = 5;
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
            // dgvsRanking
            // 
            dgvsRanking.AllowUserToAddRows = false;
            dgvsRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("맑은 고딕", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvsRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvsRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsRanking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvsRanking.DefaultCellStyle = dataGridViewCellStyle2;
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
            // dgvmRanking
            // 
            dgvmRanking.AllowUserToAddRows = false;
            dgvmRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvmRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvmRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmRanking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvmRanking.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvbRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvbRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbRanking.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("맑은 고딕", 8.830189F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvbRanking.DefaultCellStyle = dataGridViewCellStyle6;
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
            // RankingBoardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabRanking);
            Name = "RankingBoardControl";
            Size = new Size(850, 449);
            tabRanking.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsRanking).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvmRanking).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvbRanking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabRanking;
        private TabPage tabPage1;
        private DataGridView dgvsRanking;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private TabPage tabPage2;
        private DataGridView dgvmRanking;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TabPage tabPage3;
        private DataGridView dgvbRanking;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn column2;
        private DataGridViewTextBoxColumn column3;
        private DataGridViewTextBoxColumn column4;
    }
}
