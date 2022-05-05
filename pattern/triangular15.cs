using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pattern
{
    internal class triangular15
    {
        //ABCDE
        //BCDE
        //CDE
        //DE
        //E
        static void Main(string[] args)
        {
            for (char i='A'; i<='E';i++)
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
