namespace OOP_project.Source.Models
{
    /// <summary>
    /// 보드판 위의 X, Y 좌표를 하나의 단위로 묶어서 관리하는 경량 데이터 구조체입니다.
    /// </summary>
    public struct Position
    {
        public int x; // 2차원 평면상의 X 좌표(열 위치)
        public int y; // 2차원 평면상의 Y 좌표(행 위치)

        /// <summary>
        /// 생성자입니다. 전달받은 x, y 값으로 좌표를 초기화합니다.
        /// </summary>
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
