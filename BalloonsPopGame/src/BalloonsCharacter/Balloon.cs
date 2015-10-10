namespace BalloonsPopGame.Srs.BaloonsCharacter
{
    /// <summary>
    /// Abstract class for balloons structure.
    /// </summary>
    public abstract class Balloon
    {
        /// <summary>
        /// Gets or sets Symbol property.
        /// </summary>
        /// <value>Gets or sets the value of Symbol.</value>
        public char Symbol { get; protected set; }

        /// <summary>
        /// Gets or sets Color property.
        /// </summary>
        /// <value>Gets or sets the Color value.</value>
        public string Color { get; protected set; }
    }
}
