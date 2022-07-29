using System;

namespace TestCar
{
    class PassengerCar : Car
    {
        private int _maxPassenger;
        private int _currentPassenger;

        public PassengerCar(int averageFuelConsumption, int fuelTankCapacity, int averageSpeed, int maxPassenger, int currentPassenger)
    : base( averageFuelConsumption, fuelTankCapacity, averageSpeed)
        {
            _maxPassenger = maxPassenger;
            _currentPassenger = currentPassenger;
        }

        public override float MaximumMileage(int fuelQuantity)
        {
            if (_currentPassenger > _maxPassenger) throw new ArgumentException($"Количество пассажиров {_currentPassenger} превысило допустимое {_maxPassenger}");
            float _distance = fuelQuantity / _averageFuelConsumption * 100 * (1 - _currentPassenger * Const.ReductionOfPowerReservePerPassenger);
            return (float)Math.Round(_distance, 3);
        }






    }
}
