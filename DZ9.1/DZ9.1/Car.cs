namespace Classes
{
    internal class Car : Vehicle
    {
        private int _doorCount;
        private string _fuelType = "Gasoline";

        public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    Console.WriteLine("Некорректное количество дверей");
                }
                else
                {
                    _doorCount = value;
                }
            }
        }
        public string FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Некорректный тип топлива");
                }
                else
                {
                    _fuelType = value;
                }
            }
        }
        internal Car(double weight, double maxSpeed,int doorCount,string fuelType):base(weight,maxSpeed)
        {
            DoorCount = doorCount;
            FuelType = fuelType;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Характеристики указанного автомобиля: {Environment.NewLine}Количество дверей:{DoorCount}{Environment.NewLine}Тип топлива:{FuelType}{Environment.NewLine}Максимальная скорость:{MaxSpeed}{Environment.NewLine}Масса:{Weight}");
        }
    }
}
