using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    //E
    //DD
    //CCC
    //BBBB
    //AAAAA
    internal class triangular21
    {
        static void Main(string[] args)
        {
            for (char i='E';i>='A';i--)
            {
                for (char j=i;j>='A'; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        

    }
}
