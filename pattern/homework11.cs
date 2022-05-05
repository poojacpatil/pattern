using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework11
    {
        //K
        static void Main(string[] args)
        {
            int row = 15;
            int end = row;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j == 1 || j == end)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

                if (i <= row / 2)
                {
                    end = end - 2;
                }
                else
                {
                    end = end + 2;
                }
            }
        }
    }
}
