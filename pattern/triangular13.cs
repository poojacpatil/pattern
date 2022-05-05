using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class triangular13
    {
        //AAAAA
        //BBBB
        //CCC
        //DD
        //E
        static void Main(string[] args)
        {
            for (char i='A'; i<='E';i++ )
            {
                for (char j = i; j <= 'E'; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            
            
        }
    }
}
