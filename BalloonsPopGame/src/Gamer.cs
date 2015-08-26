namespace BalloonsPopGame.Srs
{
    using System;

    public class Gamer : IComparable<Gamer>
    {
        private int value;
        private string name;

        public Gamer(int value, string name)
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

        public int CompareTo(Gamer other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}