/*
int[] input => int[] threeLargestNumbers

	details 
	- at least 3 integers 
	- can't sort the input array 
	
	threeLargestNumbers = [Int32.MinValue, Int32.MinValue, Int32.MinValue]
	
						 i 
		[141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7]
		
			compare with threeLargestNumbers, from the end to 0
				if current value is greater,
					// shift left elements to make an empty slot
					// replace it 
				// once replacing, break out
				
	-
	[Int32.MinValue, 1, 141]
	
	[1, 1, 141]
	
	[1, 17, 141]

*/

using System;

namespace coding_problems.ThreeLargestNumbers
{
    public class ThreeLargestNumbersSolution
    {
        // Time O(n) | Space O(1)
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            int[] threeLargestNumbers = { Int32.MinValue, Int32.MinValue, Int32.MinValue };

            foreach (int currentNum in array)
            {
                for (int n = threeLargestNumbers.Length - 1; n >= 0; n--)
                {
                    if (currentNum > threeLargestNumbers[n])
                    {
                        // shift left values to make room
                        /*
                            n = 1
                            inserting 7
                            [Int32.MinValue, 1, 14]

                                shift to the left
                            [1, 1, 14]

                            [1, 7, 14]
                        */
                        for (int j = 1; j <= n; j++)
                        {
                            threeLargestNumbers[j - 1] = threeLargestNumbers[j];
                        }
                        threeLargestNumbers[n] = currentNum;
                        break;
                    }
                }
            }

            return threeLargestNumbers;
        }
    }
}