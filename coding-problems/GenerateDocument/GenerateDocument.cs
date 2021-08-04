using System.Collections.Generic;

namespace coding_problems.GenerateDocument
{
    public class GenerateDocument
    {
        public static bool canGenerateDocument(string availableChars, string documentToGenerate)
        {
            Dictionary<char, int> charCount = GenerateCharCountMap(availableChars);
            Dictionary<char, int> documentCharCount = GenerateCharCountMap(documentToGenerate);

            foreach (KeyValuePair<char, int> entry in documentCharCount)
            {
                if (!charCount.ContainsKey(entry.Key)) return false;
                if (entry.Value > charCount[entry.Key]) return false;
            }
            return true;
        }

        public static Dictionary<char, int> GenerateCharCountMap(string str)
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
            return charMap;
        }
    }
}