using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFordBronco = new Car(40000, "Ford", "Bronco", 2020);

            Car mySubaru = new Car(2000)
            {
                Make = "Subaru",
                Model = "Outback",
                Year = 2020,
            };

            myFordBronco.Drive(9999);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Drive(70);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Service(true);
        }
    }
}