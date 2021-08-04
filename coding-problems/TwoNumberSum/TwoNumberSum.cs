using System;
using System.Collections.Generic;

namespace coding_problems.TwoNumberSum
{
    public class TwoNumberSum
    {
        // int[], int targetSum => int[] // max length of 2
        // Time O(n) | Space O(n)
        public static int[] twoNumberSum(int[] array, int targetSum)
        {
            Dictionary<int, bool> numbersMap = new Dictionary<int, bool>();
            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                int desiredNum = targetSum - currentNum;
                if (numbersMap.ContainsKey(desiredNum))
                    return new int[] { currentNum, desiredNum };

                numbersMap.Add(currentNum, true);
            }

            return new int[0];
        }
    }
}