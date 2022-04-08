using System;
using CutomListTask.Models;

namespace CutomListTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> vali = new CustomList<int>();
            vali.Add(1);
            vali.Add(2);
            vali.Add(3);
            vali.Add(4);
            vali.CustomInsert(7, 3);
            for (int i = 0; i < vali.Count; i++)
            {
                Console.WriteLine(vali[i]);
            }
        }
    }
}
