using System;
using ClassLibrary;
namespace Practise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carlarin sayini daxil edin:");
            int CountCar = Convert.ToInt32(Console.ReadLine());
            Car[] cars = new Car[CountCar];
            for (int i = 0; i < CountCar; i++)
            {
                Console.WriteLine("Color-u daxil edin:");
                string color = Console.ReadLine();
                Console.WriteLine("Brand-i daxil edin:");
                string brand = Console.ReadLine();
                Console.WriteLine("Millage-ni daxil edin:");
                int millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hazirki benzini daxil edin:");
                int currentFuel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1km-e ne qeder benzin lazimdir :");
                int fuelFor1km = Convert.ToInt32(Console.ReadLine());
                cars[i] = new Car()
                {
                    Color = color,
                    CurrentFuel = currentFuel,
                    FuelFor1km = fuelFor1km,
                    Brand = brand,
                    Millage = millage
                };
            }
            Console.WriteLine("1-Maşınları millage-e göre filtirlə \n2-Bütün maşınları göstər \n3-Prosesi bitir");
            byte answer = Convert.ToByte(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Min ve Max Millage deyerlerini daxil edin:");
                    int minMillage = Convert.ToInt32(Console.ReadLine());
                    int maxMillage = Convert.ToInt32(Console.ReadLine());
                    FilterForMillage(cars, minMillage, maxMillage);
                    break;
                case 2:
                    ShowAllCars(cars);
                    break;
                default:
                    break;
            }
        }
        static void FilterForMillage(Car[] cars, int millageMin, int millageMax)
        {
            foreach (var item in cars)
            {
                if (item.Millage >= millageMin && item.Millage < millageMax)
                {
                    item.ShowInfo();
                }
            }
        }
        static void ShowAllCars(Car[] cars)
        {
            foreach (Car item in cars)
            {
                item.ShowInfo();
            }
        }

    }
}

