using System;

namespace coding_problems.SortedSquaredArray
{
    public class SortedSquaredArray
    {
        // int[] sortedNums => int[] squaredNumsSorted
        public static int[] sortedSquaredArray(int[] array)
        {
            int[] squaredArray = new int[array.Length];
            int leftMarker = 0;
            int rightMarker = array.Length - 1;
            int maxIndex = array.Length - 1;

            while (leftMarker <= rightMarker)
            {
                int leftSquared = (int)Math.Pow(array[leftMarker], 2);
                int rightSquared = (int)Math.Pow(array[rightMarker], 2);
                if (leftSquared >= rightSquared)
                {
                    squaredArray[maxIndex--] = leftSquared;
                    leftMarker++;
                }
                else
                {
                    squaredArray[maxIndex--] = rightSquared;
                    rightMarker--;
                }
            }
            return squaredArray;
        }
    }
}