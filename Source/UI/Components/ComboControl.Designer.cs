namespace project_cs.Source.UI.Components
{
    partial class ComboControl
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
            pbComboTimer = new ProgressBar();
            lblComboTimer = new Label();
            lblCombo = new Label();
            lblComboTitle = new Label();
            SuspendLayout();
            // 
            // pbComboTimer
            // 
            pbComboTimer.Location = new Point(130, 20);
            pbComboTimer.Name = "pbComboTimer";
            pbComboTimer.Size = new Size(160, 25);
            pbComboTimer.TabIndex = 5;
            // 
            // lblComboTimer
            // 
            lblComboTimer.AutoSize = true;
            lblComboTimer.Location = new Point(130, 0);
            lblComboTimer.Name = "lblComboTimer";
            lblComboTimer.Size = new Size(91, 17);
            lblComboTimer.TabIndex = 4;
            lblComboTimer.Text = "콤보 유지시간";
            // 
            // lblCombo
            // 
            lblCombo.AutoSize = true;
            lblCombo.Font = new Font("맑은 고딕", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCombo.Location = new Point(0, 15);
            lblCombo.Name = "lblCombo";
            lblCombo.Size = new Size(60, 35);
            lblCombo.TabIndex = 7;
            lblCombo.Text = "x1.0";
            // 
            // lblComboTitle
            // 
            lblComboTitle.AutoSize = true;
            lblComboTitle.Location = new Point(0, 0);
            lblComboTitle.Name = "lblComboTitle";
            lblComboTitle.Size = new Size(34, 17);
            lblComboTitle.TabIndex = 6;
            lblComboTitle.Text = "콤보";
            // 
            // ComboControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCombo);
            Controls.Add(lblComboTitle);
            Controls.Add(pbComboTimer);
            Controls.Add(lblComboTimer);
            Location = new Point(17, 12);
            Name = "ComboControl";
            Size = new Size(292, 49);
            Load += AppleButton_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pbComboTimer;
        private Label lblComboTimer;
        private Label lblCombo;
        private Label lblComboTitle;
    }
}
