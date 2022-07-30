using System;

namespace Test_Task
{
    class Program
    {
        private void PassingTests()
        {
            Car[] cars = new Car[]
            {
                new PassengerCar(40, 4, 5, 5, 50, 40),
                new FreightCar(50, 10, 100, 90, 468, 800)
            };

            foreach(var car in cars)
            {
                Console.WriteLine($"Запас хода равен: {car.ShowDriveDistance(car.VolumeFuel)}");
                Console.WriteLine($"Время поездки равно: {car.DriveTime(car.VolumeFuel)}");
                Console.WriteLine($"Запас хода зависящий от веса равен: {car.DriveDistanceFromWeight(car.VolumeFuel)}");
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.PassingTests();

            Console.ReadKey();
        }
    }
}
