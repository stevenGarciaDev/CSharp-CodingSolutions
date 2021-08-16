using System.Collections.Generic;

namespace coding_problems.BinarySearch
{
    public class BinarySearch
    {
        public static int performBinarySearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
                return -1;

            int startIndex = 0;
            int endIndex = array.Length - 1;

            while (startIndex <= endIndex)
            {
                int midIndex = (int)((startIndex + endIndex) / 2);

                if (array[midIndex] == target)
                    return midIndex;

                if (target < array[midIndex])
                    endIndex = midIndex - 1;
                else
                    startIndex = midIndex + 1;
            }

            return -1;
        }
    }
}