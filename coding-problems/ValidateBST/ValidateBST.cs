using System;

namespace coding_problems.ValidateBST
{
    public class ValidateBST
    {
        public class BST
        {
            public int Value { get; set; }
            public BST Left { get; set; }
            public BST Right { get; set; }
        }

        public static bool IsValidBST(BST root)
        {
            return _ValidateBST(root, Int32.MinValue, Int32.MaxValue);
        }

        public static bool _ValidateBST(BST root, int min, int max)
        {
            if (root == null) return true;

            if (root.Value < min || root.Value >= max)
                return false;

            return _ValidateBST(root.Left, min, root.Value) && _ValidateBST(root.Right, root.Value, max);
        }
    }
}