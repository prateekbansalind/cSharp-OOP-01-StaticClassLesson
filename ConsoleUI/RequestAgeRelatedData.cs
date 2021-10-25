using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class RequestAgeRelatedData
    {
        public static string AgeInCurrentYear(double age)
        {
            int yearRightNow = DateTime.Now.Year;

            //string yearRightNowString = yearRightNow.ToString();
            //string ageText = age.ToString();

            return $"your age is {age.ToString()} in year {yearRightNow.ToString()}.";
        }


    }
}
