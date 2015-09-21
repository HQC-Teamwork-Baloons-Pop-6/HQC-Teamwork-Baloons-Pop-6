namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    public abstract class Baloon
    {
        public char Symbol { get; set; }

        public string Color { get; set; }
                
        public abstract void Display(int fontSize);
    }
}
