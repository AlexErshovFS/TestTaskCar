using System;

namespace TestCar
{
    class Truck : Car
    {
        private int _maxWeigth;
        private int _currentWeigth;

        public Truck(int averageFuelConsumption, int fuelTankCapacity, int averageSpeed, int maxWeigth, int currentWeigth)
            : base( averageFuelConsumption, fuelTankCapacity, averageSpeed)
        {
            _maxWeigth = maxWeigth;
            _currentWeigth = currentWeigth;
        }

        public override float MaximumMileage(int fuelQuantity)
        {
            if (_currentWeigth > _maxWeigth) throw new ArgumentException($"Вес груза {_currentWeigth} кг превысил допустимое {_maxWeigth} кг");
            float _distance = fuelQuantity / _averageFuelConsumption * 100 * (1 - _currentWeigth / Const.UnitOfWeight * Const.ReductionOfPowerReservePerUnitOfWeight);
            return (float)Math.Round(_distance, 3);
        }

    }
}
