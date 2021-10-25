using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class UserMessages
    {
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        } 

        public static double GetANumber(string message)
        {
            Console.Write(message);
            string outputText = Console.ReadLine();

            bool isValidEntry = false;

            double output;

            isValidEntry = double.TryParse(outputText, out output);

            while (isValidEntry == false)
            {
                Console.Write(message);
                outputText = Console.ReadLine();

                isValidEntry = double.TryParse(outputText, out output);

            }
            return output;
        }
    }
}
