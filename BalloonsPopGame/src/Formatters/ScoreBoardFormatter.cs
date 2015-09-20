namespace BalloonsPopGame.Srs.Formatters
{
    internal class ScoreBoardFormatter : IFormatter
    {
        public string Format(int number, string name, int value)
        {
            return string.Format("{0}.   {1} with {2} moves.", number, name, value);
        }
    }
}
