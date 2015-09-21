namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    using System;

    public class BaloonC : Baloon
    {
        public BaloonC()
        {
            this.Symbol = 'C';
            this.Color = "Red";
        }

        public override void Display(int fontSize)
        {
            throw new NotImplementedException();
        }
    }
}
