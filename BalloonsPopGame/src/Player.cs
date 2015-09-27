namespace BalloonsPopGame.Srs
{
    using System;
    /// <summary>
    /// Class containing player info
    /// </summary>
   
    public class Player : IComparable<Player>
    {
        private int value;
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

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

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