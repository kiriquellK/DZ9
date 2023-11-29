namespace Classes
{
    public class Vehicle
    {
        private int _weight;
        private int _maxSpeed;

        internal Vehicle(){ }
        internal Vehicle(int weight, int maxSpeed)
        {
            _weight = weight;
            _maxSpeed = maxSpeed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Характеристики данного транспортного средства: {Environment.NewLine}Максимальная скорость:{_maxSpeed}{Environment.NewLine}Масса:{_weight}");
        }
    }
}
