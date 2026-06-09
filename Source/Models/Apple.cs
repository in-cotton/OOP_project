namespace OOP_project.Source.Models
{
    /// <summary>
    /// 모든 사과의 부모 클래스
    /// </summary>
    public abstract class Apple
    {
        public Position Position { get; set; }

        protected Apple(Position position)
        {
            Position = position;
        }

        /// <summary>
        /// 사과가 가지는 숫자 값 반환
        /// </summary>
        public abstract int GetValue();
    }
}