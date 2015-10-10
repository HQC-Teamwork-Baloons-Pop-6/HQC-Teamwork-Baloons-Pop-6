namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    /// <summary>
    /// Abstract class for baloons structure
    /// </summary>
    public abstract class Baloon
    {
        /// <summary>
        /// Symbol property
        /// </summary>
        public char Symbol { get; protected set; }

        /// <summary>
        /// Color property
        /// </summary>
        public string Color { get; protected set; }
    }
}
