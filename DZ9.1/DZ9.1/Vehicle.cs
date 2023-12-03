namespace Classes
{
    public class Vehicle
    {
        private double _weight = 1500;
        private double _maxSpeed = 200;

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Некорректная масса");
                }
                else
                {
                    _weight = value;
                }
            }
        }
        public double MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Некорректная максимальная скорость");
                }
                else
                {
                    _maxSpeed = value;
                }
            }
        }

        public Vehicle(double weight, double maxSpeed)
        {
            Weight = weight;
            MaxSpeed = maxSpeed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Характеристики данного транспортного средства: {Environment.NewLine}Максимальная скорость:{MaxSpeed}{Environment.NewLine}Масса:{Weight}");
        }
    }
}
