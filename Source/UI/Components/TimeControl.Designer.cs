namespace project_cs.Source.UI.Components
{
    partial class TimeControl
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
            lblTime = new Label();
            lblTimer = new Label();
            pbTimer = new ProgressBar();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("맑은 고딕", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTime.Location = new Point(166, 25);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(31, 20);
            lblTime.TabIndex = 10;
            lblTime.Text = "60s";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(0, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(65, 17);
            lblTimer.TabIndex = 9;
            lblTimer.Text = "남은 시간";
            // 
            // pbTimer
            // 
            pbTimer.Location = new Point(0, 20);
            pbTimer.Name = "pbTimer";
            pbTimer.Size = new Size(160, 25);
            pbTimer.TabIndex = 8;
            // 
            // TimeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTime);
            Controls.Add(lblTimer);
            Controls.Add(pbTimer);
            Name = "TimeControl";
            Size = new Size(199, 49);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblTimer;
        private ProgressBar pbTimer;
    }
}
