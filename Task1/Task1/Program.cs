using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!\n"
                               + "And hi again!");
            Random random = new Random();
            for (int i = 0; i < random.Next(5, 50); ++i)
            {
                Console.Write("!");
            }
        }
    }
}
