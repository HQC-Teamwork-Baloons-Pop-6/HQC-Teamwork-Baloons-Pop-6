namespace BalloonsPopGame.Srs
{
    using System;

    public class NameValuePair : IComparable<NameValuePair>
    {
        private int value;
        private string name;

        public NameValuePair(int value, string name)
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

        public int CompareTo(NameValuePair other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}