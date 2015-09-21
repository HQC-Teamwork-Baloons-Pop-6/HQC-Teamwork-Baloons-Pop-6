namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    using System.Collections.Generic;

    public class BaloonFactory
    {
        private readonly Dictionary<byte, Baloon> characters = new Dictionary<byte, Baloon>();

        public int NumberOfObjects
        {
            get
            {
                return this.characters.Count;
            }
        }

        public Baloon GetCharacter(byte key)
        {
            // Lazy initialization
            Baloon character = null;
            if (this.characters.ContainsKey(key))
            {
                character = this.characters[key];
            }
            else
            {
                switch (key)
                {
                    case 1:
                        character = new BaloonA();
                        break;
                    case 2:
                        character = new BaloonB();
                        break;
                    case 3:
                        character = new BaloonC();
                        break;
                    case 4:
                        character = new BaloonD();
                        break;
                }

                this.characters.Add(key, character);
            }

            return character;
        }
    }
}
