namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle=new Vehicle(1700,200);
            vehicle.DisplayInfo();
            Vehicle vehicle0 = new Car(1750,240,4,"Diesel");
            vehicle0.DisplayInfo();
            Car car = new Car(1600,220,2,"Gasoline");
            car.DisplayInfo();
            Vehicle vehicle1 = new Truck(4500,230,3400);
            vehicle1.DisplayInfo();
            Truck truck = new Truck(6000, 180, 5000);
            truck.DisplayInfo();
            Vehicle vehicle2 = new ElectricCar(1550,250,2,"Energy",70,450);
            vehicle2.DisplayInfo();
            Car car1 = new ElectricCar(1550, 250, 2, "Energy", 50, 500);
            car1.DisplayInfo();
            ElectricCar electricCar = new ElectricCar(1550, 250, 2, "Energy", 60, 350);
            electricCar.DisplayInfo();
        }
    }
}