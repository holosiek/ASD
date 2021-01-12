using System;
using ASD.Struktury;

namespace ASD
{
    internal static class Program
    {
        private static void TestyDrzew()
        {
            int[] pre = { 10, 5, 1, 7, 40, 50, -5, 1929 };
            var avltree = new AVLTree();
            var bsttree = new BSTree();
            var rbtree = new RedBlackTree();
            
            var currentNode = avltree.Root;
            foreach (int i in pre)
            {
                bsttree.Add(i);
                rbtree.Insert(i);
                currentNode = avltree.Insert(currentNode, i);
            }
            
            avltree.Print(currentNode);
            rbtree.Print();
            bsttree.Print(bsttree.InOrder, bsttree.Root);
        }

        private static void TestStrukturyA()
        {
            var struktA = new StrukturaA(10);
            Console.WriteLine(StrukturaA.Search(1, struktA));
            Console.WriteLine(StrukturaA.Search(-5, struktA));
            Console.WriteLine(StrukturaA.Insert(5, struktA));
            Console.WriteLine(StrukturaA.Insert(5, struktA));
            Console.WriteLine(StrukturaA.Insert(1, struktA));
            Console.WriteLine(StrukturaA.Insert(0, struktA));
            Console.WriteLine(StrukturaA.Insert(10, struktA));
            Console.WriteLine(StrukturaA.Search(10, struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Insert(5, struktA));
            Console.WriteLine(StrukturaA.Insert(5, struktA));
            Console.WriteLine(StrukturaA.Insert(1, struktA));
            Console.WriteLine(StrukturaA.Insert(0, struktA));
            Console.WriteLine(StrukturaA.Insert(10, struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
            Console.WriteLine(StrukturaA.Select(struktA));
        }

        private static void TestStrukturyB()
        {
            var struktB = new StrukturaB(10);
            Console.WriteLine(StrukturaB.Push(5, struktB));
            Console.WriteLine(StrukturaB.Push(5, struktB));
            Console.WriteLine(StrukturaB.Push(3, struktB));
            Console.WriteLine(StrukturaB.Push(1, struktB));
            Console.WriteLine(StrukturaB.Push(1, struktB));
            Console.WriteLine(StrukturaB.Pop(struktB));
            Console.WriteLine(StrukturaB.Pop(struktB));
            Console.WriteLine(StrukturaB.Pop(struktB));
            Console.WriteLine(StrukturaB.Pop(struktB));
            Console.WriteLine(StrukturaB.Pop(struktB));
            Console.WriteLine("---------");
            Console.WriteLine(StrukturaB.Push(5, struktB));
            Console.WriteLine(StrukturaB.Push(3, struktB));
            Console.WriteLine(StrukturaB.Push(1, struktB));
            Console.WriteLine("---------");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(StrukturaB.Search(i, struktB));
            }
            Console.WriteLine("---------");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(StrukturaB.Delete(i, struktB));
            }
            Console.WriteLine("---------");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(StrukturaB.Search(i, struktB));
            }
        }
        
        private static void TestStrukturyC()
        {
            var struktC = new StrukturaC();
            StrukturaC.Push(5, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(6, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(7, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(8, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Pop(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Pop(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Pop(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Pop(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Pop(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(3, struktC);
            StrukturaC.Push(2, struktC);
            StrukturaC.Push(5, struktC);
            StrukturaC.Push(1, struktC);
            StrukturaC.Push(4, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.UpToMin(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.UpToMin(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.UpToMin(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(5, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(6, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(2, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(8, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(2, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.Push(8, struktC);
            StrukturaC.Print(struktC);
            StrukturaC.UpToMin(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.UpToMin(struktC);
            StrukturaC.Print(struktC);
            StrukturaC.UpToMin(struktC);
            StrukturaC.Print(struktC);
        }
        
        private static void TestyStruktur()
        {
            TestStrukturyA();
            TestStrukturyB();
            TestStrukturyC();
        }
        
        public static void Main(string[] args)
        {
            TestyDrzew();
            TestyStruktur();
        }
    }
}
