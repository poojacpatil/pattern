using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework12
    {
        //Z
        static void Main(string[] args)
        {
            int row = 5;
            int end = row;
        
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j ++)
                {
                    if(i==1 || i==row || j==end  )
                        
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                end = end - 1;
            }
        }
    }
}
