using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string s = ""; 
                string revs = "";

                Console.WriteLine("Kan du skriva en palindrom?");

                s = Console.ReadLine();
                //Bakvänder strängen
                for (int i = s.Length - 1; i >= 0; i--) 
                {
                    revs += s[i].ToString();
                }
                //Tar bort blanksteg
                revs = revs.Replace(" ", "");
                s = s.Replace(" ", "");

                //Om strängen är en palindrom
                if (revs == s)
                {
                    Console.WriteLine("Finfint, du har skrivit en palindrom!");
                }
                //Om strängen inte är en palindrom
                else
                {
                    Console.WriteLine("Nehe du, mig lurar du inte - det där är ingen palindrom!");
                }
            }
        }
    }
}
