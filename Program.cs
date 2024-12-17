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
            List<int> list = new List<int>();
            Output(list,10);
            Console.ReadLine();
        }
        static void Output(List<int> list, int size )
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++) 
            
            {
                list.Add(rnd.Next(1, 20));
                Console.WriteLine(list[i]);
            }
        }
    }
}
