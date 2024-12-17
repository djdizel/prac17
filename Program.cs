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
            List<int> list = new List<int>() {20,15,13,145,15,113,14,15,16,16,113,
                12,56,67,13,24,45,243,35,89};
            Random rng = new Random();
            int index = rng.Next(0,19);
            list.Remove(index);
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
