using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ASD.Struktury
{
    public class StrukturaC
    {
        private int MinIndex { get; set; }
        private int Ind { get; set; }
        public List<int> ElemList = new List<int>();
        public List<int> MinList = new List<int>();

        public static void Push(int val, StrukturaC set)
        {
            if (set.ElemList.Count == 0 || set.Ind >= set.ElemList.Count)
            {
                set.ElemList.Add(val);
                set.Ind++;
            }
            else
            {
                set.ElemList[set.Ind] = val;
                set.Ind++;
            }
            if (set.MinList.Count == 0)
            {
                set.MinList.Add(set.Ind-1);
                set.MinIndex++;
            }
            else
            {
                if (set.MinIndex < 0 || val < set.ElemList[set.MinList[set.MinIndex]])
                {
                    if (set.MinIndex + 1 < set.MinList.Count)
                    {
                        set.MinList[set.MinIndex+1] = set.Ind;
                    }
                    else
                    {
                        set.MinList.Add(set.Ind);
                    }
                    set.MinIndex++;
                }
            }
        }

        public static int Pop(StrukturaC set)
        {
            if (set.Ind > 0)
            {
                int whatToReturn = set.ElemList[set.Ind-1];
                set.Ind--;
                return whatToReturn;
            }
            return -1;
        }
        
        public static void UpToMin(StrukturaC set)
        {
            if (set.MinIndex >= 0)
            {
                set.Ind = set.MinList[set.MinIndex]-1;
                set.MinIndex--;
                if (set.Ind < 0)
                {
                    set.Ind = 0;
                }
            }
        }

        public static void Print(StrukturaC set)
        {
            for(int i=0; i<set.Ind; i++)
            {
                Console.Write(set.ElemList[i] + " ");
            }
            Console.Write("\n");
        }
        
        public StrukturaC()
        {
            Ind = 0;
            MinIndex = -1;
        }
    }
}