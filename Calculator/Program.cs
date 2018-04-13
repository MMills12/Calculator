using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Calculator: Addition");
                Console.WriteLine("----------+------------");
                Console.Write("Input 1 = ");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;
                int x = Convert.ToInt32(str);
                Console.Write("Input 2 = ");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
                Console.WriteLine();
            }
            while (true);
        }
    }
}
