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
            lblTitle = new Label();
            lblSubTitle = new Label();
            grpBoardSize = new GroupBox();
            rbLarge = new RadioButton();
            rbMedium = new RadioButton();
            rbSmall = new RadioButton();
            btnStart = new Button();
            rankingBoardControl1 = new project_cs.Source.UI.Components.RankingBoardControl();
            grpBoardSize.SuspendLayout();
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
            // rankingBoardControl1
            // 
            rankingBoardControl1.Location = new Point(70, 270);
            rankingBoardControl1.Name = "rankingBoardControl1";
            rankingBoardControl1.Size = new Size(851, 447);
            rankingBoardControl1.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 737);
            Controls.Add(rankingBoardControl1);
            Controls.Add(btnStart);
            Controls.Add(grpBoardSize);
            Controls.Add(lblSubTitle);
            Controls.Add(lblTitle);
            Name = "MainMenuForm";
            Text = "Form1";
            grpBoardSize.ResumeLayout(false);
            grpBoardSize.PerformLayout();
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
        private Components.RankingBoardControl rankingBoardControl1;
    }
}