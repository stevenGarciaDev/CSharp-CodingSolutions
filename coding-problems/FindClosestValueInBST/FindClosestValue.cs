using System;

/*
	BST root, int targetValue -> int closestValue
	
		int closestValue = Int32.MaxValue;
		
		then after comparing the absolute difference
		
		closestValue = 10
		
		search in right subtree,
		
		closestValue = 13
		
*/

namespace coding_problems.FindClosestValueInBST
{
    public class FindClosestValue
    {
        public static int FindClosestValueInBst(BST tree, int target)
        {
            if (tree == null) return -1;

            int closestValue = Int32.MaxValue;
            BST currentNode = tree;

            while (currentNode != null)
            {
                int currentDifference = Math.Abs(currentNode.value - target);
                if (currentDifference < Math.Abs(closestValue - target))
                    closestValue = currentNode.value;

                if (target < currentNode.value)
                    currentNode = currentNode.left;
                else
                    currentNode = currentNode.right;
            }

            return closestValue;
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }
    }
}