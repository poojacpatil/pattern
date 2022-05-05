using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    //   *
    //  ***
    // *****
    //

    internal class pyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of row");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                for (int space = 1; space <= r - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }


    class pyramid2
    {
        /*
           *******
            *****
             ***
              *
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of star");
            int r=Convert.ToInt32(Console.ReadLine());

            for (int i = r; i >= 1; i--)
            {
                for (int space = 1; space <= r - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class pyramid3
    {
        /*
           1
           AB
           123
           ABCD
           12345
         */  
         static void Main(string[] args)
         {
            Console.WriteLine("Enter the no of rows");
            int r= Convert.ToInt32(Console.ReadLine());

              for (int i = 1;i<=r;i++)
              {
                  for (int j = 1; j <= i; j++)
                  {
                    if (i % 2 == 1)
                        Console.Write(j);
                    else
                        Console.Write((char)(64 + j));
                  }
                    Console.WriteLine();
                
              }
         }
    }
}
