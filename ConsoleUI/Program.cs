using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = UserMessages.GetAString("What is your first name: ");

            WelcomeMessage.WelcomeUser(firstName);

            ConsoleFeature.LineBreak();

            double age = UserMessages.GetANumber("What is your age: ");

            UserMessages.GetAString(RequestAgeRelatedData.AgeInCurrentYear(age));

            Console.ReadLine();
        }
    }
}