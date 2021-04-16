using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {
        const int position = 0;
        static void Main(string[] args)
        {
            Random random = new Random();
            int dieValue = random.Next(1, 7);
            Console.WriteLine(" Player die roll position = " + dieValue);
            Console.ReadLine();
        }
    }
}