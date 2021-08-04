using System.Collections.Generic;

namespace coding_problems.FirstNonRepeatingChar
{
    public class FirstNonRepeatingCharacter
    {
        public int firstNonRepeatingCharacter(string str)
        {
            Dictionary<char, int> charMap = new Dictionary<char, int>();

            foreach (char currentChar in str)
            {
                if (charMap.ContainsKey(currentChar))
                {
                    charMap[currentChar] += 1;
                }
                else
                {
                    charMap.Add(currentChar, 1);
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (charMap[currentChar] == 1)
                    return i;
            }

            return -1;
        }
    }
}