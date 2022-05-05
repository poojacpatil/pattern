using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework5
    {
        static void Main(string[] args)
        {
            //F
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                  if(r==1 ||  r==3 || c==1)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
