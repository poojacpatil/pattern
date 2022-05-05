using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class triangular7
    {
        //E
        //ED
        //EDC
        //EDCB
        //EDCBA
        static void Main(string[] args)
        {
            for (char i='E';i>='A';i--)
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
