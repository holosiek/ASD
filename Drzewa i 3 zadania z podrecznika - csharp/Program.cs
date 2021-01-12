using System;
using ASD.Struktury;

namespace ASD
{
    internal static class Program
    {
        private const string Separator = "---------------------";

        public static void AddHeader(string header)
        {
            Console.WriteLine("\n"+Separator);
            Console.WriteLine(">>> " + header);
            Console.WriteLine(Separator);
        }
        
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
            var arr = new[]{5, 5, 1, 0, 10};
            var struktA = new StrukturaA(10);

            AddHeader("Struktura A - 1.28 z podrecznika");
            Console.WriteLine(StrukturaA.Search(1, struktA));
            Console.WriteLine(StrukturaA.Search(-5, struktA));
            
            foreach (int val in arr)
            {
                Console.WriteLine(StrukturaA.Insert(val, struktA));
            }
            
            Console.WriteLine(StrukturaA.Search(10, struktA));
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(StrukturaA.Select(struktA));
            }
            
            foreach (int val in arr)
            {
                Console.WriteLine(StrukturaA.Insert(val, struktA));
            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(StrukturaA.Select(struktA));
            }
        }

        private static void TestStrukturyB()
        {
            var struktB = new StrukturaB(10);
            var arr = new[]{5, 5, 3, 1, 1};
            
            AddHeader("Struktura B - 1.29 z podrecznika");
            foreach (int val in arr)
            {
                Console.WriteLine(StrukturaB.Push(val, struktB));
            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(StrukturaB.Pop(struktB));
            }
            
            foreach (int val in arr)
            {
                Console.WriteLine(StrukturaB.Push(val, struktB));
            }
            
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(StrukturaB.Search(i, struktB));
            }
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(StrukturaB.Delete(i, struktB));
            }
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(StrukturaB.Search(i, struktB));
            }
        }
        
        private static void TestStrukturyC()
        {
            var struktC = new StrukturaC();
            
            AddHeader("Struktura C - 1.30 z podrecznika");
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
            string holdConsole = Console.ReadLine();
        }
    }
}
