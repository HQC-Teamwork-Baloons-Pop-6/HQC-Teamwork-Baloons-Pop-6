namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    using System.Collections.Generic;

    public class BaloonFactory
    {
        private readonly Dictionary<byte, Baloon> _characters = new Dictionary<byte, Baloon>();

        public int NumberOfObjects
        {
            get { return _characters.Count; }
        }

        public Baloon GetCharacter(byte key)
        {
            if (_characters.ContainsKey(key))
            {
                return _characters[key];
            }

            // Lazy initialization
            Baloon character = null;
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

            _characters.Add(key, character);

            return character;
        }
    }
}
