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
            timeControl1 = new project_cs.Source.UI.Components.TimeControl();
            comboControl1 = new project_cs.Source.UI.Components.ComboControl();
            btnPause = new Button();
            lblScore = new Label();
            lblScoreTitle = new Label();
            pnlBoard = new Panel();
            pnlSide = new Panel();
            listBox1 = new ListBox();
            grpBoardInfo = new GroupBox();
            lblBoardInfo = new Label();
            itemButtonControl1 = new project_cs.Source.UI.Components.ItemButtonControl();
            pnlTopBar.SuspendLayout();
            pnlSide.SuspendLayout();
            grpBoardInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = SystemColors.ButtonHighlight;
            pnlTopBar.Controls.Add(timeControl1);
            pnlTopBar.Controls.Add(comboControl1);
            pnlTopBar.Controls.Add(btnPause);
            pnlTopBar.Controls.Add(lblScore);
            pnlTopBar.Controls.Add(lblScoreTitle);
            pnlTopBar.Location = new Point(17, 12);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(950, 80);
            pnlTopBar.TabIndex = 0;
            // 
            // timeControl1
            // 
            timeControl1.Location = new Point(500, 15);
            timeControl1.Name = "timeControl1";
            timeControl1.Size = new Size(197, 54);
            timeControl1.TabIndex = 9;
            // 
            // comboControl1
            // 
            comboControl1.Location = new Point(150, 15);
            comboControl1.Name = "comboControl1";
            comboControl1.Size = new Size(294, 54);
            comboControl1.TabIndex = 8;
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
            // lblScoreTitle
            // 
            lblScoreTitle.AutoSize = true;
            lblScoreTitle.Location = new Point(45, 15);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(34, 17);
            lblScoreTitle.TabIndex = 1;
            lblScoreTitle.Text = "점수";
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
            pnlSide.Controls.Add(itemButtonControl1);
            pnlSide.Controls.Add(listBox1);
            pnlSide.Controls.Add(grpBoardInfo);
            pnlSide.Location = new Point(777, 107);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(197, 615);
            pnlSide.TabIndex = 0;
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
            // itemButtonControl1
            // 
            itemButtonControl1.Location = new Point(23, 20);
            itemButtonControl1.Name = "itemButtonControl1";
            itemButtonControl1.Size = new Size(154, 213);
            itemButtonControl1.TabIndex = 6;
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
        private Button btnPause;
        private Panel pnlBoard;
        private Panel pnlSide;
        private Label lblBoardInfo;
        private GroupBox grpBoardInfo;
        private ListBox listBox1;
        private Components.ComboControl comboControl1;
        private Components.TimeControl timeControl1;
        private Components.ItemButtonControl itemButtonControl1;
    }
}