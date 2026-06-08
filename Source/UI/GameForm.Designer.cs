namespace project_cs.Source.UI
{
    partial class GameForm
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
            pnlTopBar = new Panel();
            lblScoreTitle = new Label();
            lblScore = new Label();
            lblComboTitle = new Label();
            lblCombo = new Label();
            lblComboTimer = new Label();
            pbComboTimer = new ProgressBar();
            pbTimer = new ProgressBar();
            lblTimer = new Label();
            btnPause = new Button();
            lblTime = new Label();
            pnlBoard = new Panel();
            pnlSide = new Panel();
            btnShuffle = new Button();
            btnHint = new Button();
            btnJoker = new Button();
            lblBoardInfo = new Label();
            grpBoardInfo = new GroupBox();
            listBox1 = new ListBox();
            pnlTopBar.SuspendLayout();
            pnlSide.SuspendLayout();
            grpBoardInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = SystemColors.ButtonHighlight;
            pnlTopBar.Controls.Add(lblTime);
            pnlTopBar.Controls.Add(btnPause);
            pnlTopBar.Controls.Add(lblTimer);
            pnlTopBar.Controls.Add(pbTimer);
            pnlTopBar.Controls.Add(pbComboTimer);
            pnlTopBar.Controls.Add(lblComboTimer);
            pnlTopBar.Controls.Add(lblCombo);
            pnlTopBar.Controls.Add(lblComboTitle);
            pnlTopBar.Controls.Add(lblScore);
            pnlTopBar.Controls.Add(lblScoreTitle);
            pnlTopBar.Location = new Point(17, 12);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(950, 80);
            pnlTopBar.TabIndex = 0;
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.AutoSize = true;
            lblScoreTitle.Location = new Point(45, 15);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(34, 17);
            lblScoreTitle.TabIndex = 1;
            lblScoreTitle.Text = "점수";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("맑은 고딕", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblScore.Location = new Point(45, 30);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(29, 35);
            lblScore.TabIndex = 1;
            lblScore.Text = "0";
            // 
            // lblComboTitle
            // 
            lblComboTitle.AutoSize = true;
            lblComboTitle.Location = new Point(160, 15);
            lblComboTitle.Name = "lblComboTitle";
            lblComboTitle.Size = new Size(34, 17);
            lblComboTitle.TabIndex = 1;
            lblComboTitle.Text = "콤보";
            // 
            // lblCombo
            // 
            lblCombo.AutoSize = true;
            lblCombo.Font = new Font("맑은 고딕", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCombo.Location = new Point(160, 30);
            lblCombo.Name = "lblCombo";
            lblCombo.Size = new Size(60, 35);
            lblCombo.TabIndex = 2;
            lblCombo.Text = "x1.0";
            // 
            // lblComboTimer
            // 
            lblComboTimer.AutoSize = true;
            lblComboTimer.Location = new Point(290, 15);
            lblComboTimer.Name = "lblComboTimer";
            lblComboTimer.Size = new Size(91, 17);
            lblComboTimer.TabIndex = 1;
            lblComboTimer.Text = "콤보 유지시간";
            // 
            // pbComboTimer
            // 
            pbComboTimer.Location = new Point(290, 35);
            pbComboTimer.Name = "pbComboTimer";
            pbComboTimer.Size = new Size(160, 25);
            pbComboTimer.TabIndex = 3;
            // 
            // pbTimer
            // 
            pbTimer.Location = new Point(500, 35);
            pbTimer.Name = "pbTimer";
            pbTimer.Size = new Size(160, 25);
            pbTimer.TabIndex = 4;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(500, 15);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(65, 17);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "남은 시간";
            // 
            // btnPause
            // 
            btnPause.Location = new Point(760, 20);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(120, 40);
            btnPause.TabIndex = 6;
            btnPause.Text = "일시정지";
            btnPause.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("맑은 고딕", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTime.Location = new Point(666, 40);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(31, 20);
            lblTime.TabIndex = 7;
            lblTime.Text = "60s";
            // 
            // pnlBoard
            // 
            pnlBoard.BackColor = SystemColors.ButtonHighlight;
            pnlBoard.BorderStyle = BorderStyle.FixedSingle;
            pnlBoard.Location = new Point(17, 107);
            pnlBoard.Name = "pnlBoard";
            pnlBoard.Size = new Size(750, 615);
            pnlBoard.TabIndex = 1;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = SystemColors.ButtonHighlight;
            pnlSide.Controls.Add(listBox1);
            pnlSide.Controls.Add(grpBoardInfo);
            pnlSide.Controls.Add(btnJoker);
            pnlSide.Controls.Add(btnHint);
            pnlSide.Controls.Add(btnShuffle);
            pnlSide.Location = new Point(777, 107);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(197, 615);
            pnlSide.TabIndex = 0;
            // 
            // btnShuffle
            // 
            btnShuffle.Font = new Font("맑은 고딕", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnShuffle.Location = new Point(23, 20);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(150, 50);
            btnShuffle.TabIndex = 0;
            btnShuffle.Text = "섞기";
            btnShuffle.UseVisualStyleBackColor = true;
            // 
            // btnHint
            // 
            btnHint.Font = new Font("맑은 고딕", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnHint.Location = new Point(23, 101);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(150, 50);
            btnHint.TabIndex = 1;
            btnHint.Text = "힌트";
            btnHint.UseVisualStyleBackColor = true;
            // 
            // btnJoker
            // 
            btnJoker.Font = new Font("맑은 고딕", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnJoker.Location = new Point(23, 178);
            btnJoker.Name = "btnJoker";
            btnJoker.Size = new Size(150, 50);
            btnJoker.TabIndex = 2;
            btnJoker.Text = "조커";
            btnJoker.UseVisualStyleBackColor = true;
            // 
            // lblBoardInfo
            // 
            lblBoardInfo.Font = new Font("맑은 고딕", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblBoardInfo.Location = new Point(15, 21);
            lblBoardInfo.Name = "lblBoardInfo";
            lblBoardInfo.Size = new Size(140, 80);
            lblBoardInfo.TabIndex = 3;
            lblBoardInfo.Text = "중형 보드 10x10";
            lblBoardInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpBoardInfo
            // 
            grpBoardInfo.BackColor = SystemColors.Control;
            grpBoardInfo.Controls.Add(lblBoardInfo);
            grpBoardInfo.Location = new Point(13, 245);
            grpBoardInfo.Name = "grpBoardInfo";
            grpBoardInfo.Size = new Size(170, 110);
            grpBoardInfo.TabIndex = 4;
            grpBoardInfo.TabStop = false;
            grpBoardInfo.Text = "보드정보";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Menu;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(13, 370);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(170, 225);
            listBox1.TabIndex = 5;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 737);
            Controls.Add(pnlSide);
            Controls.Add(pnlBoard);
            Controls.Add(pnlTopBar);
            Name = "GameForm";
            Text = "사과게임";
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlSide.ResumeLayout(false);
            grpBoardInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopBar;
        private Label lblScoreTitle;
        private Label lblScore;
        private Label lblCombo;
        private Label lblComboTitle;
        private Label lblTimer;
        private ProgressBar pbTimer;
        private ProgressBar pbComboTimer;
        private Label lblComboTimer;
        private Label lblTime;
        private Button btnPause;
        private Panel pnlBoard;
        private Panel pnlSide;
        private Button btnHint;
        private Button btnShuffle;
        private Button btnJoker;
        private Label lblBoardInfo;
        private GroupBox grpBoardInfo;
        private ListBox listBox1;
    }
}