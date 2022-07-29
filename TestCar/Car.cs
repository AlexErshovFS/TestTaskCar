using System;

namespace TestCar
{
    abstract class Car
    {

        protected string _carType { get; }
        protected float _averageFuelConsumption { get; }
        protected float _fuelTankCapacity { get; }
        protected float _averageSpeed { get; }

        protected Car(int averageFuelConsumption, int fuelTankCapacity, int averageSpeed)
        {
            _averageFuelConsumption = averageFuelConsumption;
            _fuelTankCapacity = fuelTankCapacity;
            _averageSpeed = averageSpeed;
            _carType = GetType().Name;
        }


        /// <summary>
        /// Расчет запаса хода базовый - без нагрузки в зависимости от количества топлива
        /// </summary>
        public virtual float MaximumMileage(int fuelQuantity)
        {
            float _distance = fuelQuantity / _averageFuelConsumption * 100;
            return _distance;
        }

        /// <summary>
        /// Отображение текущей информации о запасе хода в зависимости от количества топлива
        /// </summary>
        public string OutVehicleRange(int fuelQuantity)
        {
            if (fuelQuantity > _fuelTankCapacity) throw new ArgumentException($"Для транспортного средства {_carType} Количество топлива {fuelQuantity} л не должно превышать объем бака {_fuelTankCapacity} л");
            return $"Запас хода транспортного средства {_carType} составляет { MaximumMileage(fuelQuantity) } км.";
        }


        /// <summary>
        /// Расчет времени преодоления пути при определенном количестве топлива
        /// </summary>
        /// <returns></returns>
        public string TripTime(int distance, int fuelQuantity)
        {
            if (fuelQuantity > _fuelTankCapacity) throw new ArgumentException($"Для транспортного средства {_carType} количество топлива {fuelQuantity} л не должно превышать объем бака {_fuelTankCapacity} л");
            if (MaximumMileage(fuelQuantity) < distance) throw new ArgumentException($"Для транспортного средства {_carType} количество топлива {fuelQuantity} л  не достаточно для преодоления дистанции {distance} км");

            float _tripTime = distance / _averageSpeed;
            return TimeSpan.FromHours(_tripTime).ToString(@"hh\:mm\:ss");
        }

    }



}







