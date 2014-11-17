using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mata in ett heltal:");
            int N = int.Parse(Console.ReadLine());
            int zeroCount = 0;
            int evenCount = 0;
            int unevenCount = 0;

            string numberString = N.ToString();

            char[] character = numberString.ToCharArray();

            for (int i = 0; i <= (numberString.Length - 1); i++)
            {
                if(character[i] == '0') {
                    
                    zeroCount++;
                }

                else if (character[i] % 2 == 0 )
                {
                    evenCount++;
                }
                else
                {
                    unevenCount++;
                }
            }
            Console.WriteLine("Nollor: {0}, jämna: {1}, udda: {2}", zeroCount, evenCount, unevenCount);

        }
    }
}
