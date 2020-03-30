using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            #region ListMethods test
            List<int> aList = new List<int> { 23, 86, 51, 11, 39 };

            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine($"The smallest number in the list is : {smallest}");

            int average = ListMethods.FindAverage(aList);
            Console.WriteLine($"The average of the list is : {average}"); 
            #endregion

            Car hatchBack = new Car("3EME926", 5000);
            Car sedan = new Car("XOS 846", 6969);
            Car mPV = new Car("JX 9817" , 4000);
            Car sUV = new Car("8DR 592", 8000);

            hatchBack.Price = 300000;
            sedan.Price = 200000;
            Console.WriteLine(hatchBack.Price);
            Console.WriteLine(hatchBack.LicensePlate);
            Console.WriteLine(mPV.LicensePlate);

            Car.PrintUsageStatistics();

            // The LAST line of code should be ABOVE this line
        }
    }
}