namespace OOP_project.Source.Models
{
    /// <summary>
    /// 조커 사과
    /// </summary>
    public class JokerApple : Apple
    {
        public JokerApple(Position position)
            : base(position)
        {
        }

        public override int GetValue()
        {
            return 0;
        }
    }
}