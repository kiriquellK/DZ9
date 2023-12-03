namespace Classes
{
    internal class ElectricCar:Car
    {
        private int _chargeCapacity;
        private double _rangeOnFullCapacity;

        public int ChargeCapacity
        {
            get
            {
                return _chargeCapacity;
            }
            set
            {
                if (value < 0 || value>100)
                {
                    Console.WriteLine("Некорректный заряд");
                }
                else
                {
                    _chargeCapacity = value;
                }
            }
        }
        public double RangeOnFullCapacity
        {
            get
            {
                return _rangeOnFullCapacity;
            }
            set
            {
                if (value < 0 || value > 1500)
                {
                    Console.WriteLine("Некорректный запас хода");
                }
                else
                {
                    _rangeOnFullCapacity = value;
                }
            }
        }
        public ElectricCar(double weight, double maxSpeed, int doorCount, string fuelType, int chargeCapacity, int rangeOnFullCapacity):base(weight,maxSpeed,doorCount,fuelType)
        {
            ChargeCapacity = chargeCapacity;
            RangeOnFullCapacity = rangeOnFullCapacity;
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Это электромобиль со следующими характеристиками: {Environment.NewLine}Емкость батареи:{ChargeCapacity}{Environment.NewLine}Максимальная дистанция на одном заряде:{RangeOnFullCapacity}");
        }
    }
}
