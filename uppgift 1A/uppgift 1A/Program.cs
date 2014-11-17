using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mata in en textrad så räknar jag antal a och A:");
            int counta = 0;
            int countA  = 0;
            string input = Console.ReadLine();

            char[] character = input.ToCharArray();

            for (int i = 0; i <= (character.Length - 1); i++) {
                
                if (character[i] == 'A') {
                    countA++;
                }
                if (character[i] == 'a') {
                    counta++;
                }
            }

            Console.WriteLine("antal a: {0}, antal A: {1}.", counta, countA);
            
        }
    }
}
