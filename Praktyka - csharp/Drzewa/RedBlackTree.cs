using System;

namespace ASD
{
    public class RedBlackTree
    {
        public enum EColor
        {
            Red,
            Black
        }

        public class Node
        {
            public EColor Color;
            public Node Left;
            public Node Right;
            public Node Parent;
            public int Value;

            public Node(int value)
            {
                Value = value;
            }
        }

        public Node Root;
        
        private void LeftRotate(Node node)
        {
            var tempNode = node.Right;
            node.Right = tempNode.Left;
            
            if (tempNode.Left != null)
            {
                tempNode.Left.Parent = node;
            }
            if (tempNode != null)
            {
                tempNode.Parent = node.Parent;
            }
            if (node.Parent == null)
            {
                Root = tempNode;
            }
            
            if (tempNode.Parent != null && node.Parent != null && node == node.Parent.Left)
            {
                node.Parent.Left = tempNode;
            }
            else if(node.Parent != null && tempNode.Parent != null)
            {
                node.Parent.Right = tempNode;
            }
            
            tempNode.Left = node;
            node.Parent = tempNode;
        }

        private void RightRotate(Node node)
        {
            var tempNode = node.Left;
            node.Left = tempNode.Right;
            
            if (tempNode.Right != null)
            {
                tempNode.Right.Parent = node;
            }
            if (tempNode != null)
            {
                tempNode.Parent = node.Parent;
            }
            if (node.Parent == null)
            {
                Root = tempNode;
            }
            if (node.Parent != null && node == node.Parent.Right)
            {
                node.Parent.Right = tempNode;
            }
            if(node.Parent != null && node == node.Parent.Left)
            {
                node.Parent.Left = tempNode;
            }
 
            tempNode.Right = node;
            node.Parent = tempNode;
        }
        
        public void Print()
        {
            Program.AddHeader("RedBlackTree");
            InOrder(Root);
            Console.Write("\n");
        }
        
        public void Insert(int value)
        {
            var newNode = new Node(value);
            
            if (Root == null)
            {
                Root = newNode;
                Root.Color = EColor.Black;
                return;
            }
            
            Node tempNode = null;
            var tempNode2 = Root;
            
            while (tempNode2 != null)
            {
                tempNode = tempNode2;
                tempNode2 = newNode.Value < tempNode2.Value 
                    ? tempNode2.Left 
                    : tempNode2.Right;
            }
            
            newNode.Parent = tempNode;
            
            if (tempNode == null)
            {
                Root = newNode;
            }
            else if (newNode.Value < tempNode.Value)
            {
                tempNode.Left = newNode;
            }
            else
            {
                tempNode.Right = newNode;
            }
            
            newNode.Left = null;
            newNode.Right = null;
            newNode.Color = EColor.Red;
            
            InsertFix(newNode);
        }
        
        private void InOrder(Node current)
        {
            if (current != null)
            {
                InOrder(current.Left);
                Console.Write(current.Value + " ");
                InOrder(current.Right);
            }
        }
        
        private void InsertFix(Node node)
        {
            while (node != Root && node.Parent.Color == EColor.Red)
            {
                if (node.Parent == node.Parent.Parent.Left)
                {
                    var tempNode = node.Parent.Parent.Right;
                    if (tempNode != null && tempNode.Color == EColor.Red)
                    {
                        node.Parent.Color = EColor.Black;
                        tempNode.Color = EColor.Black;
                        node.Parent.Parent.Color = EColor.Red;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Right)
                        {
                            node = node.Parent;
                            LeftRotate(node);
                        }
                        node.Parent.Color = EColor.Black;
                        node.Parent.Parent.Color = EColor.Red;
                        RightRotate(node.Parent.Parent);
                    }
 
                }
                else
                {
                    var tempNode = node.Parent.Parent.Left;
                    if (tempNode != null && tempNode.Color == EColor.Black)
                    {
                        node.Parent.Color = EColor.Red;
                        tempNode.Color = EColor.Red;
                        node.Parent.Parent.Color = EColor.Black;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Left)
                        {
                            node = node.Parent;
                            RightRotate(node);
                        }
                        node.Parent.Color = EColor.Black;
                        node.Parent.Parent.Color = EColor.Red;
                        LeftRotate(node.Parent.Parent);
                    }
 
                }
                Root.Color = EColor.Black;
            }
        }
    }
}