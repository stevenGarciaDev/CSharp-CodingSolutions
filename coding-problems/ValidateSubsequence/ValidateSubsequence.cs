using System.Collections.Generic;

namespace coding_problems.ValidateSubsequence
{
    public class ValidateSubsequence
    {
        // List<int>[] array, List<int>[] sequence => bool
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int seqIdx = 0;
            foreach (int num in array)
            {
                if (seqIdx == sequence.Count) return true;
                if (num == sequence[seqIdx]) seqIdx++;
            }
            return seqIdx == sequence.Count;
        }
    }
}