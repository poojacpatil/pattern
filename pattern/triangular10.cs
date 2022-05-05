using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class triangular10
    {
        //11111
        //2222
        //333
        //44
        //5

        static void Main(string[] args)
        { 
            for (int i=1;i<=5;i++)
            {
                for (int j=i;j<=5;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }
}
