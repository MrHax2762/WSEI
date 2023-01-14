using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[10];
            for (int i = 0; i < 10; i++)
            {
               liczby[i] = i;

            }
            //int[] liczby = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 };
			int test = 4;
            
            var result =        
            	from n in liczby
                where n < test
                select n;

            foreach (var x in result)  
            {
                Console.WriteLine(x + ", ");
            }
            Console.ReadKey();
        }
    }
}

