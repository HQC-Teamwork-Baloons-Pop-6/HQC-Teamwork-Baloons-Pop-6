using System;

namespace BalloonsPopGame
{
    public class NameValuePair : IComparable<NameValuePair>
    {
        public int val;
        public string name;

        public NameValuePair(int value, string name)
        {
            this.val = value;
            this.name = name;
        }

        public int CompareTo(NameValuePair other)
        {
            return val.CompareTo(other.val);
        }
    }
}