namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    using System.Collections.Generic;

    public class CharacterFactory
    {
        private readonly Dictionary<byte, Character> characters = new Dictionary<byte, Character>();

        public int NumberOfObjects
        {
            get
            {
                return this.characters.Count;
            }
        }

        public Character GetCharacter(byte key)
        {
            // Lazy initialization
            Character character = null;
            if (this.characters.ContainsKey(key))
            {
                character = this.characters[key];
            }
            else
            {
                switch (key)
                {
                    case 1:
                        character = new CharacterA();
                        break;
                    case 2:
                        character = new CharacterB();
                        break;
                    case 3:
                        character = new CharacterC();
                        break;
                    case 4:
                        character = new CharacterD();
                        break;
                }

                this.characters.Add(key, character);
            }

            return character;
        }
    }
}
