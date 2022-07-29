using System;
using System.Collections.Generic;

namespace TestCar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;


            List<Car> cars = new List<Car>();

            cars.Add(new PassengerCar(averageFuelConsumption: 10, fuelTankCapacity: 50, averageSpeed: 90, maxPassenger: 4, currentPassenger: 3));
            cars.Add(new SportCar(averageFuelConsumption: 10, fuelTankCapacity: 50, averageSpeed: 180));
            cars.Add(new Truck(averageFuelConsumption: 10, fuelTankCapacity: 50, averageSpeed: 60, maxWeigth: 4000, currentWeigth: 3000));

            foreach (var currentCar in cars)
            {
                try
                {
                    Console.WriteLine(currentCar.OutVehicleRange(fuelQuantity: 31));
                    Console.WriteLine($"Время в пути для { currentCar.GetType().Name} " + currentCar.TripTime(distance: 10, fuelQuantity: 10)); ;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



            }












        }


    }
}


