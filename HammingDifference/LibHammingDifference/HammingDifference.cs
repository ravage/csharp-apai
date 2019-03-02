using System;
using System.Linq;

namespace LibHammingDifference
{
    public class HammingDifference
    {
        public int Difference(string a, string b)
        {
            int aLength = a.Length;
            int bLength = b.Length;
            int distance = 0;

            if (aLength != bLength)
            {
                throw new ArgumentException("Strings must be of same size.");
            }

            for (var i = 0; i < aLength; i++)
            {
                if (a[i] != b[i])
                {
                    distance++;
                }
            }

            return distance;
        }
    }
}
