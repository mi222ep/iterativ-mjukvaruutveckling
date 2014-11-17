using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in valfritt antal heltal, när du är nöjd mata in 0 för att visa det näst största talet:");

            int maxNumber = 0;
            int secondMax = 0;
            int N;
            
           
            do
            {

                N = int.Parse(Console.ReadLine());
                
                if (N > maxNumber)
                {
                    secondMax = maxNumber;
                    maxNumber = N;
                }

                else if (N <= maxNumber && N >= secondMax)
                {
                    secondMax = N;
                }


            } while (N != 0);
            Console.WriteLine("Det näst största talet är {0}", secondMax);
        }
    }
}
