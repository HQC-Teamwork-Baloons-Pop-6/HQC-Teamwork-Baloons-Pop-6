namespace BalloonsPopGame.Srs
{
    using System;

    /// <summary>
    /// Class containing player info
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
        /// Constructor for palyer
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        public Player(int value, string name)
        {
            this.Value = value;
            this.Name = name;
        }

        /// <summary>
        /// Value property
        /// </summary>
        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Name property
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Method for compare two players
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Player other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}