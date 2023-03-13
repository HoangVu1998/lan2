using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>() { 0, 2, 3, 5, 4, 8, 9 };
            HashSet<int> set2 = new HashSet<int>() { 20, 2,23, 55, 44, 8, 9 };
            set1.IntersectWith(set2);
            foreach (var item in set1)
            { Console.WriteLine(item);}
        }
    }
}
