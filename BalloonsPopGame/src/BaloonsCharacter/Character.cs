namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    public abstract class Character
    {
        public char Symbol { get; set; }

        public string Color { get; set; }
                
        public abstract void Display(int fontSize);
    }
}
