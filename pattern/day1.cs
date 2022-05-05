using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    //       1
    //      12
    //     123
    //    1234
    //   12345

    internal class day1
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                for (int space = 1; space <= 5 - i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
    class day2
    {
        //       6
        //      56
        //     456
        //    3456
        //   23456
        //  123456
        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)
            {
                for (int space = 1; space <i ; space++)
                {
                    Console.Write(" ");
                }
                    for (int j = i; j <= 6; j++)
                    {
                         Console.Write(j);
                    }
                        Console.WriteLine();
            }   
        }
    }
}
