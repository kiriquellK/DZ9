namespace Classes
{
    internal class Truck : Vehicle
    {
        private double _liftingCapacity;

        public double LiftingCapacity
        {
            get
            {
                return _liftingCapacity;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Некорректная грузоподъемность");
                }
                else
                {
                    _liftingCapacity = value;
                }
            }
        }

        internal Truck(double weight, double maxSpeed, double liftingCapacity) : base(weight, maxSpeed)
        {
            LiftingCapacity = liftingCapacity;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Характеристики указанного грузовика: {Environment.NewLine}Грузоподъемность:{LiftingCapacity}{Environment.NewLine}Максимальная скорость:{MaxSpeed}{Environment.NewLine}Масса:{Weight}");
        }
    }
}