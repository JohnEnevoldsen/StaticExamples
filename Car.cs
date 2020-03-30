using System;

namespace StaticExamples
{
    /// <summary>
    /// A very simple representation of a car
    /// </summary>
    public class Car
    {
        #region Instance fields
        private string _licensePlate;
        private int _price;
        private static int _numberOfCars;
        private static int _usesOfLicensePlate;
        private static int _usesOfPrice;
        #endregion

        #region Constructor
        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            _numberOfCars++;
        }
        #endregion

        #region Properties
        public string LicensePlate
        {
            get { _usesOfLicensePlate++; return _licensePlate; }
            set { _licensePlate = value; _usesOfLicensePlate++;}
        }

        public int Price
        {
            get { _usesOfPrice++; return _price; }
            set { _price = value; _usesOfPrice++;}
        } 
        #endregion
        public static void PrintUsageStatistics(){
            Console.WriteLine($"There are a total of {_numberOfCars} car(s)");
            Console.WriteLine($"The property LicensePlate have been used {_usesOfLicensePlate} time(s)");
            Console.WriteLine($"The property Price have been used {_usesOfPrice} time(s)");
        }
    }
}