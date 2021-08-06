namespace coding_problems.PalindromeCheck
{
    public class PalindromeCheck
    {
        // Time O(n) | Space O(1)
        public static bool IsPalindrome(string str)
        {
            int startIdx = 0;
            int endIdx = str.Length - 1;
            while (startIdx <= endIdx)
            {
                if (str[startIdx] != str[endIdx])
                    return false;
                startIdx++;
                endIdx--;
            }
            return true;
        }
    }
}