using System;

namespace ASD
{
    public class AVLTree
    {
        public class Node
        {
            public int Value;  
            public Node Left;  
            public Node Right;  
            public int Height;  
        };

        public Node Root;
        
        private int Height(Node node)  
        {
            if (node == null)
            {
                return 0; 
            }
            return node.Height;
        }

        private Node NewNode(int value)  
        {
            return new Node()
            {
                Value = value,
                Left = null,
                Right = null,
                Height = 1
            };
        }  

        private Node RightRotate(Node node)  
        {  
            var leftNode = node.Left;
            var tempNode = leftNode.Right;

            leftNode.Right = node;
            node.Left = tempNode;  

            node.Height = Math.Max(Height(node.Left), Height(node.Right))+1;  
            leftNode.Height = Math.Max(Height(leftNode.Left), Height(leftNode.Right))+1;  

            return leftNode;  
        }  

        private Node LeftRotate(Node node)  
        {  
            var rightNode = node.Right;  
            var tempNode = rightNode.Left;  

            rightNode.Left = node;  
            node.Right = tempNode;  

            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;  
            rightNode.Height = Math.Max(Height(rightNode.Left), Height(rightNode.Right)) + 1;  

            return rightNode;  
        }  

        private int GetBalance(Node node)  
        {
            return node == null
                ? 0
                : Height(node.Left)-Height(node.Right);  
        }  

        public Node Insert(Node node, int value)  
        {
            if (node == null)
            {
                return NewNode(value); 
            }

            if (value < node.Value)
            {
                node.Left = Insert(node.Left, value);  
            }
            else if (value > node.Value)
            {
                node.Right = Insert(node.Right, value); 
            }
            else
            {
                return node;
            }

            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
            int balance = GetBalance(node);

            if (balance > 1 && value < node.Left.Value)
            {
                return RightRotate(node);
            }
            if (balance < -1 && value > node.Right.Value)
            {
                return LeftRotate(node);
            }
            if (balance > 1 && value > node.Left.Value)
            {  
                node.Left = LeftRotate(node.Left);  
                return RightRotate(node);  
            }
            if (balance < -1 && value < node.Right.Value)  
            {  
                node.Right = RightRotate(node.Right);  
                return LeftRotate(node);  
            }  

            return node;  
        }  

        public void PreOrder(Node node)  
        {  
            if (node != null)  
            {  
                Console.Write(node.Value + " ");  
                PreOrder(node.Left);
                PreOrder(node.Right);  
            }  
        }

        public void Print(Node node)
        {
            Console.Write("AVLTree:\n");
            PreOrder(node);
            Console.Write("\n");
        }
        
        public AVLTree()
        {
            Root = null;
        }
    }
}