using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace braktal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Först testar vi om konsollen skickar felmeddelande om nämnaren är noll");
            try
            {
                Fraction wrong = new Fraction(0, 0);
            }
            catch (IndexOutOfRangeException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            Console.WriteLine("Sedan skapar vi två bråktal och prövat att addera och multiplicera dessa");
            Fraction f = new Fraction(1, 3);

            Fraction f2 = new Fraction(1, 5);

            bool equal = f.isEqualTo(f2);
            string equalMessage;
            if (equal)
            {
                equalMessage = "De båda bråktalen är lika!";
            }
            else {
                equalMessage = "De båda talen är olika";
            }

            Fraction addedFractions = f.add(f2);
            Fraction multipiledFractions = f.multiply(f2);

            Console.WriteLine("Ditt första bråktal är {0}", f.toString());
            Console.WriteLine("Ditt andra bråktal är {0}", f2.toString());
            Console.WriteLine("Om du adderar talen blir resultatet {0}", addedFractions.toString());
            Console.WriteLine("Om du multiplicerar talen blir resultatet {0}", multipiledFractions.toString());
            Console.WriteLine(equalMessage);
            
            
        }

        public static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}