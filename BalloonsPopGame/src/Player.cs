namespace BalloonsPopGame.Srs
{
    using System;

    public class Player : IComparable<Player>
    {
        private int value;
        private string name;

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

        public int CompareTo(Player other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}