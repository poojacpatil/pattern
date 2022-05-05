using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework14
    {
        //P
        static void Main(string[] args)
        {


            int row = 10;
            
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j == 1 || i == 1 || i == row / 2 + 1 || (i <= row / 2 + 1 && j == 10))
                   Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
