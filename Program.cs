using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16,17,18,19 };
            Random rng = new Random();
            int index = rng.Next(0,19);
            list.RemoveAt(index);
            Console.WriteLine($"Удален {index} элемент списка");
            Output(list);
            Console.ReadKey();
        }
        static void Output(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
