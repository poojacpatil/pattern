using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class triangular19
    {
        //E
        //DE
        //CDE
        //BCDE
        //ABCDE
        static void Main(string[] args)
        {
            for (char i='E'; i>='A';i--)
            {
                for (char j=i;j<='E';j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
