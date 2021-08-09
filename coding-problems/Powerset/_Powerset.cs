using System.Collections.Generic;

namespace coding_problems.Powerset
{
    public class _Powerset
    {
        // Time complexity is O(2^n * (n))
        // Space complexity is O(2^n * (n))
        public static List<List<int>> PowersetsIterative(List<int> array)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            foreach (int num in array)
            {
                int length = subsets.Count;
                for (int i = 0; i < length; i++)
                {
                    List<int> newSubset = new List<int>(subsets[i]);
                    newSubset.Add(num);
                    subsets.Add(newSubset);
                }
            }

            return subsets;
        }

        public static List<List<int>> PowersetsRecursively(List<int> array)
        {
            return PowersetsRecursively(array, array.Count - 1);
        }

        public static List<List<int>> PowersetsRecursively(List<int> array, int idx)
        {
            if (idx < 0)
            {
                List<List<int>> emptySet = new List<List<int>>();
                emptySet.Add(new List<int>());
                return emptySet;
            }

            int number = array[idx];

            List<List<int>> subsets = PowersetsRecursively(array, idx - 1);

            int length = subsets.Count;

            for (int i = 0; i < length; i++)
            {
                List<int> newSubset = new List<int>(subsets[i]);
                newSubset.Add(number);
                subsets.Add(newSubset);
            }

            return subsets;
        }
    }
}