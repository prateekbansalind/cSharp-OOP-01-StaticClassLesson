using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class WelcomeMessage
    {
        public static void WelcomeUser(string firstName)
        {
            Console.Clear();

            int output = DateTime.UtcNow.Hour;

            if (output > 0 && output < 6)
            {
                Console.WriteLine($"Hello {firstName}");
                Console.WriteLine("Welcome it's NZL evening shift (S1).");
            }
            else if (output > 6 && output < 12)
            {
                Console.WriteLine($"Hello {firstName}");
                Console.WriteLine("Welcome it's GSY morning shift (S2).");
            }
            else if (output > 12 && output < 18)
            {
                Console.WriteLine($"Hello {firstName}");
                Console.WriteLine("Welcome it's GSY evening shift (S3).");
            }
            else             {
                Console.WriteLine($"Hello {firstName}");
                Console.WriteLine("Welcome it's NZL morning shift (S4).");
            }
        }
    }
}
