using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Unordernumber = {-90,10,-25,15,-78 };
            int nTemp = 0;
            Console.WriteLine("Sorted numbers are : ");

            for (int i = 0; i < Unordernumber.Length ; i++)
            {
                for (int j = i+1; j < Unordernumber.Length ; j++)
                {
                    if (Unordernumber[i] > Unordernumber[j])
                    {
                        nTemp = Unordernumber[j];
                        Unordernumber[j] = Unordernumber[i];
                        Unordernumber[i] = nTemp;
                    }
                }
                Console.WriteLine(Unordernumber [i]);
            }
            
            Console.ReadLine();
        }

        
    }

}
