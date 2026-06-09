namespace project_cs.Source.UI.Components
{
    partial class ItemButtonControl
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
            btnJoker = new Button();
            btnHint = new Button();
            btnShuffle = new Button();
            SuspendLayout();
            // 
            // btnJoker
            // 
            btnJoker.Font = new Font("맑은 고딕", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnJoker.Location = new Point(0, 158);
            btnJoker.Name = "btnJoker";
            btnJoker.Size = new Size(150, 50);
            btnJoker.TabIndex = 5;
            btnJoker.Text = "조커";
            btnJoker.UseVisualStyleBackColor = true;
            // 
            // btnHint
            // 
            btnHint.Font = new Font("맑은 고딕", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnHint.Location = new Point(0, 81);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(150, 50);
            btnHint.TabIndex = 4;
            btnHint.Text = "힌트";
            btnHint.UseVisualStyleBackColor = true;
            // 
            // btnShuffle
            // 
            btnShuffle.Font = new Font("맑은 고딕", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnShuffle.Location = new Point(0, 0);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(150, 50);
            btnShuffle.TabIndex = 3;
            btnShuffle.Text = "섞기";
            btnShuffle.UseVisualStyleBackColor = true;
            // 
            // ItemButtonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnJoker);
            Controls.Add(btnHint);
            Controls.Add(btnShuffle);
            Name = "ItemButtonControl";
            Size = new Size(151, 210);
            ResumeLayout(false);
        }

        #endregion

        private Button btnJoker;
        private Button btnHint;
        private Button btnShuffle;
    }
}
