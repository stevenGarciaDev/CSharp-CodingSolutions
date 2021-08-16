using System;
using System.Collections.Generic;

namespace coding_problems.DepthFirstSearch
{
    public class DepthFirstSearch
    {
        // Do not edit the class below except
        // for the DepthFirstSearch method.
        // Feel free to add new properties
        // and methods to the class.
        public class Node
        {
            public string name;
            public List<Node> children = new List<Node>();

            public Node(string name)
            {
                this.name = name;
            }

            public List<string> DepthFirstSearch(List<string> array)
            {
                if (children.Count == 0) return array;

                Stack<Node> stack = new Stack<Node>();
                stack.Push(children[0]);

                while (stack.Count > 0)
                {
                    Node top = stack.Pop();
                    array.Add(top.name);
                    Console.WriteLine(top.name);
                    foreach (Node childNode in top.children)
                        stack.Push(childNode);
                }

                return array;
            }

            public Node AddChild(string name)
            {
                Node child = new Node(name);
                children.Add(child);
                return this;
            }

        }
    }
}