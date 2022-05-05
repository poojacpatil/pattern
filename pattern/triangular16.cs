using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    //ABCDE
    //ABCD
    //ABC
    //AB
    //A
    internal class triangular16
    {
        static void Main(string[] args)
        {
            for (char i='E';i>='A';i--)
            {
                for (char j='A';j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
