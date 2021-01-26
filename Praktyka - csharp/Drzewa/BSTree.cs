using System;

namespace ASD
{
    public class BSTree
    {
        public class Node
        {
            public Node Left;
            public Node Right;
            public int Value;
        }

        public Node Root;
     
        public bool Add(int value)
        {
            Node before = null;
            var after = Root;
     
            while (after != null)
            {
                before = after;
                if (value < after.Value)
                {
                    after = after.Left;
                }
                else if (value > after.Value)
                {
                    after = after.Right;
                }
                else
                {
                    return false;
                }
            }
     
            var newNode = new Node()
            {
                Value = value
            };
     
            if (Root == null){
                Root = newNode;
            }
            else
            {
                if (value < before.Value)
                {
                    before.Left = newNode;
                }
                else
                {
                    before.Right = newNode;
                }
            }
     
            return true;
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null)
            {
                return null;
            }

            if (key < parent.Value)
            {
                parent.Left = Remove(parent.Left, key);
            }
            else if (key > parent.Value)
            {
                parent.Right = Remove(parent.Right, key);
            }
            else
            {
                if (parent.Left == null)
                {
                    return parent.Right;
                }
                else if (parent.Right == null)
                {
                    return parent.Left;
                }
                parent.Value = MinValue(parent.Right);
                parent.Right = Remove(parent.Right, parent.Value);
            }
     
            return parent;
        }
     
        private int MinValue(Node node)
        {
            int val = node.Value;
     
            while (node.Left != null)
            {
                val = node.Left.Value;
                node = node.Left;
            }
     
            return val;
        }
     
        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Value)
                {
                    return parent;
                }
                if (value < parent.Value)
                {
                    return Find(value, parent.Left);
                } 
                return Find(value, parent.Right);
            }
     
            return null;
        }

        private int GetTreeDepth(Node parent)
        {
            return parent == null 
                ? 0 
                : Math.Max(GetTreeDepth(parent.Left), GetTreeDepth(parent.Right)) + 1;
        }
     
        public void PreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Value + " ");
                PreOrder(parent.Left);
                PreOrder(parent.Right);
            }
        }
     
        public void InOrder(Node parent)
        {
            if (parent != null)
            {
                InOrder(parent.Left);
                Console.Write(parent.Value + " ");
                InOrder(parent.Right);
            }
        }
     
        public void PostOrder(Node parent)
        {
            if (parent != null)
            {
                PostOrder(parent.Left);
                PostOrder(parent.Right);
                Console.Write(parent.Value + " ");
            }
        }

        public void Print(Action<Node> type, Node parent)
        {
            Program.AddHeader("BSTree");
            type.Invoke(parent);
            Console.Write("\n");
        }
    }
}