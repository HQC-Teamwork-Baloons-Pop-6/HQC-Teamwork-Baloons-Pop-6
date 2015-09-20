namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    using System.Collections.Generic;

    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public int NumberOfObjects
        {
            get
            {
                return this.characters.Count;
            }
        }

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character = null;
            if (this.characters.ContainsKey(key))
            {
                character = this.characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A':
                        character = new CharacterA();
                        break;
                    case 'B':
                        character = new CharacterB();
                        break;
                    case 'C':
                        character = new CharacterC();
                        break;
                    case 'D':
                        character = new CharacterD();
                        break;
                    case 'E':
                        character = new CharacterE();
                        break;
                }

                this.characters.Add(key, character);
            }

            return character;
        }
    }
}
