namespace BalloonsPopGame.Srs
{
    using System;

    /// <summary>
    /// Class containing player info.
    /// </summary>
    public class Player : IComparable<Player>
    {
        /// <summary>
        /// Store for the value property.
        /// </summary>
        private int value;

        /// <summary>
        /// Store for the name property.
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="value">Player's value.</param>
        /// <param name="name">Player's name.</param>
        public Player(int value, string name)
        {
            this.Value = value;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets Value property.
        /// </summary>
        /// <value>Gets or sets the value of Value.</value>
        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Gets or sets Name property.
        /// </summary>
        /// <value>Gets or sets the value of Name.</value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Method for compare two players.
        /// </summary>
        /// <param name="other">Value of second player.</param>
        /// <returns>Value of comparing.</returns>
        public int CompareTo(Player other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}