using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the min number");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max number");
            int max = int.Parse(Console.ReadLine());
            int temp;
            for (int i = min; i <= max; i++)
            {
                temp = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        temp++;
                        break;
                    }
                }
                if (temp == 0 && i != 1)
                    Console.Write("{0} ", i);
            }
            Console.Write("\n");
        }
    }
}
