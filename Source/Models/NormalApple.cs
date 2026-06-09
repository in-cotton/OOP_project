namespace OOP_project.Source.Models
{
    /// <summary>
    /// 일반 숫자 사과
    /// </summary>
    public class NormalApple : Apple
    {
        public int Number { get; private set; }

        public NormalApple(Position position, int number)
            : base(position)
        {
            Number = number;
        }

        public override int GetValue()
        {
            return Number;
        }
    }
}