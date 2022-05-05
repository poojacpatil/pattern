using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class triamgular14
    {
        //EEEEE
        //DDDD
        //CCC
        //BB
        //A
        static void Main(string[] args)
        {
            for (char i='E';i>='A';i--)
            {
                for (char j=i;j>='A';j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
