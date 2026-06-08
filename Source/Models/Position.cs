namespace OOP_project.Source.Models
{
    /// <summary>
    /// 보드판 위의 2D X, Y 좌표를 표현하는 구조체
    /// </summary>
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
