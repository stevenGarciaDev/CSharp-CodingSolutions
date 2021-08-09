using System.Collections.Generic;

namespace coding_problems.BreadthFirstSearch
{
    public class BreadthFirstSearch
    {
        public class Node
        {
            public string name;
            public List<Node> children = new List<Node>();

            public Node(string name)
            {
                this.name = name;
            }

            public List<string> BreadthFirstSearch(List<string> array)
            {
                // Write your code here.
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(this);

                while (queue.Count > 0)
                {
                    Node frontOfQueue = queue.Dequeue();
                    array.Add(frontOfQueue.name);
                    foreach (Node child in frontOfQueue.children)
                        queue.Enqueue(child);
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