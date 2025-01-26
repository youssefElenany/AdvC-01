using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_01
{
    public class StringProcessor
    {
        public static int FirstNonRepeatedCharacter(string input)
        {
            var charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[input[i]] == 1)
                    return i;
            }

            return -1; // No non-repeated character found
        }
    }

}
