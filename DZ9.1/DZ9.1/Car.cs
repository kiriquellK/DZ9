namespace Classes
{
    internal class Car : Vehicle
    {
        private int _doorCount;
        private string _fuelType;

        internal Car() { }
        internal Car(int doorCount,string fuelType)
        {
            _doorCount = doorCount;
            _fuelType = fuelType;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Характеристики указанного автомобиля: {Environment.NewLine}Количество дверей:{_doorCount}{Environment.NewLine}Тип топлива:{_fuelType}");
        }
    }
}
