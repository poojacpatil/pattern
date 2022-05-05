using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    //EDCBA
    //EDCB
    //EDC
    //ED
    //E
    internal class triangular17
    {
        static void Main(string[] args)
        {
            for (char i='A';i<='E';i++)
            {
                for (char j='E';j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
