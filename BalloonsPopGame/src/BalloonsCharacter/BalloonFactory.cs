namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    using System.Collections.Generic;

    /// <summary>
    /// Class generate a balloon factory.
    /// </summary>
    public class BalloonFactory
    {
        private readonly Dictionary<byte, Balloon> characters = new Dictionary<byte, Balloon>();

        public int NumberOfObjects
        {
            get
            {
                return this.characters.Count;
            }
        }

        public Balloon GetCharacter(byte key)
        {
            if (this.characters.ContainsKey(key))
            {
                return this.characters[key];
            }

            // Lazy initialization
            Balloon character = null;
            switch (key)
            {
                case 1:
                    character = new BalloonA();
                    break;
                case 2:
                    character = new BalloonB();
                    break;
                case 3:
                    character = new BalloonC();
                    break;
                case 4:
                    character = new BalloonD();
                    break;
            }

            this.characters.Add(key, character);

            return character;
        }
    }
}
