using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework7
    {
        static void Main(string[] args)
        {
            //T
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    if (r==1 || c == 3)

                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
