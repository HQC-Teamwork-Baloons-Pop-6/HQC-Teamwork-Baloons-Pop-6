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
        private int _value;

        /// <summary>
        /// Store for the name property.
        /// </summary>
        private string _name;

        /// <summary>
        /// Constructor for palyer
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        public Player(int value, string name)
        {
            Value = value;
            Name = name;
        }

        /// <summary>
        /// Value property
        /// </summary>
        public int Value
        {
            get { return _value; }
            set { this._value = value; }
        }

        /// <summary>
        /// Name property
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Method for compare two players
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Player other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}