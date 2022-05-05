using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class triangular22
    {
        /*1
          232
          34543
          4567654
        */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 2 * i - 1; j++)
                {
                    Console.Write(j);
                }
                for (int k = 2 * i - 2; k >= i; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();  
            }
        }
    }
}
