using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework6
    {
        //H
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 11; c++)
                {
                    if (c == 1 || c == 11 || r == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
}
