namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    using System.Collections.Generic;

    /// <summary>
    /// Class generate a balloon factory.
    /// </summary>
    public class BalloonFactory
    {
        /// <summary>
        /// Set of the balloon characters.
        /// </summary>
        private readonly Dictionary<byte, Balloon> characters = new Dictionary<byte, Balloon>();

        /// <summary>
        /// Gets the number of characters.
        /// </summary>
        /// <value>Gets character.</value>
        public int NumberOfObjects
        {
            get
            {
                return this.characters.Count;
            }
        }

        /// <summary>
        /// Gets or adds the searched character.
        /// </summary>
        /// <param name="key">Given key for searching.</param>
        /// <returns>Returns searched character.</returns>
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
