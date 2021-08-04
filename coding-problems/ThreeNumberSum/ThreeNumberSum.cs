using System;
using System.Collections.Generic;
using System.Linq;

namespace coding_problems.ThreeNumberSum
{
    public class ThreeNumberSum
    {
        /*
        Could use a hash table to store all values. Then two for loops.

        But there is a better way.
        Sort the input array.
            then have left pointer and right pointer 
            
        ....
        */

        // Time complexity O(n^2) | Space O(n)
        public static List<int[]> performThreeNumberSum(int[] array, int targetSum)
        {
            int[] sortedNums = array.OrderBy(num => num).ToArray();
            // could also do Array.Sort(array) to sort in-place

            List<int[]> threeNumberSums = new List<int[]>();

            // loop through,
            for (int i = 0; i < sortedNums.Length; i++)
            {
                // making left and right markers
                int leftMarker = i + 1;
                int rightMarker = sortedNums.Length - 1;

                while (leftMarker < rightMarker)
                {
                    // see if those three values, sum to the targetSum
                    int currentSum = sortedNums[i] + sortedNums[leftMarker] + sortedNums[rightMarker];
                    if (targetSum == currentSum)
                    {
                        int[] newSum = { sortedNums[i], sortedNums[leftMarker], sortedNums[rightMarker] };
                        threeNumberSums.Add(newSum.OrderBy(n => n).ToArray());

                        leftMarker++;
                        rightMarker--;
                    }
                    else if (currentSum < targetSum)
                    {
                        leftMarker++;
                    }
                    else
                    {
                        rightMarker--;
                    }
                }
            }

            return threeNumberSums;
        }

        // This method is not actually used for the final solution.
        // Time O(log n) | Space O(1)
        public static bool BinarySearch(int[] sortedArray, int numToFind)
        {
            int start = 0;
            int end = sortedArray.Length - 1;
            while (start <= end)
            {
                int midIndex = (int)((start + end) / 2);

                if (sortedArray[midIndex] == numToFind) return true;

                if (numToFind < sortedArray[midIndex])
                {
                    start = midIndex + 1;
                }
                else
                {
                    end = midIndex - 1;
                }
            }
            return false;
        }
    }
}