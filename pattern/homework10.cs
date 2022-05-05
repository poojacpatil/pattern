using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework10
    {
        static void Main(string[] args)
        {
            int i = 2, j = 4;
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || r == 5)
                        Console.Write("*");
                
                
                    else if (r == i && c == j)
                        Console.Write("*");
               
                   
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
