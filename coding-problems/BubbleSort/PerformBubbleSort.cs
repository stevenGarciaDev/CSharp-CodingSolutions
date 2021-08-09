using System;

/*
int[] array -> int[] sortedArray

	i  j
	[8, 5, 2, 9, 5, 6, 3]
	
		compare and swap 
	
			i  j
	[5, 8, 2, 9, 5, 6, 3]
		
		compare and swap 
		
				 i j
	[5, 2, 8, 9, 5, 6, 3]
	
						i j
	[5, 2, 8, 9, 5, 6, 3]
	
							 i j
	[5, 2, 8, 5, 9, 6, 3]
	
	 								i j
	[5, 2, 8, 5, 6, 9, 3]
	
	 									 i j
	[5, 2, 8, 5, 6, 3, 9]
	
	
	- start outer loop, i
		- hasPerformedSwap = false
		- start inner loop j = i + 1, j < array.Length
		
			- compare array[j - 1] and array[j]
				swap if array[j - 1] > array[j]
				hasPerformedSwap = true
				
		if !hasPerformedSwap
			return array
			
			
	
*/

namespace coding_problems.BubbleSort
{
    public class Program
    {
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool hasPerformedSwap = false;
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                        hasPerformedSwap = true;
                    }
                }

                if (!hasPerformedSwap) return array;
            }
            return array;
        }

        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}