using GameOfGoose.Board;

namespace GameOfGoose.Rules
{
    internal class None : IRules
    {
        public int Position { get; set; }

        public void ValidateRule(Player player)
        {
        }
    }
}