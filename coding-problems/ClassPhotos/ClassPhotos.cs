using System.Collections.Generic;
using System.Linq;

namespace coding_problems.ClassPhotos
{
    /*
 
 List<int> heightsOfRedShirts, List<int> heightsOfBlueShirts -> bool canBeTaken
 
 		details:
			- same length, has at least 2 students
			- reds shirts in same row
			- blue shirts in same row
			- students in back row, must be taller than students in front of them 
			
			f [] b
 		// sort in ascending 
 	
	sort both input arrays,
	
		[5, 8, 1, 3, 4]
		
		[6, 9, 2, 4, 5]
		
			-> after being sorted
			
			
			red [1, 3, 4, 5, 8]
			
			blue [2, 4, 5, 6, 9]
			
			
			
			based on comparing the first element in each sorted array,
			
			areStudentsInRedTaller set based on above condition;
			
			loop through,
			
					must satisfy the bool, areStudentsInRedTaller
					// otherwise return false
					
			// return true
			
	
*/
    public class ClassPhotos
    {
        public bool CanTakeClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights)
        {
            List<int> sortedRedShirtHeights = redShirtHeights.OrderBy(h => h).ToList();
            List<int> sortedBlueShirtHeights = blueShirtHeights.OrderBy(h => h).ToList();

            if (sortedRedShirtHeights[0] == sortedBlueShirtHeights[0])
                return false;

            bool areRedShirtsTaller = (sortedRedShirtHeights[0] > sortedBlueShirtHeights[0]) ? true : false;

            for (int i = 1; i < sortedRedShirtHeights.Count; i++)
            {
                int redHeight = sortedRedShirtHeights[i];
                int blueHeight = sortedBlueShirtHeights[i];

                if (redHeight == blueHeight) return false;

                if (areRedShirtsTaller)
                {
                    if (blueHeight > redHeight)
                        return false;
                }
                else
                {
                    if (redHeight > blueHeight)
                        return false;
                }
            }

            return true;
        }
    }
}