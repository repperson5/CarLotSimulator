using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new CarLot();


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var honda = new Car();

            honda.Year = 2019;
            honda.Make = "Honda";
            honda.Model = "Civic";
            honda.EngineNoise = "Small Vroom";
            honda.HonkNoise = "Tiny Honk";
            honda.IsDrivable = true;

            parkingLot.CarList.Add(honda);
            CarLot.numberOfCars++;

            Console.WriteLine($" Number of cars in Lot: {CarLot.numberOfCars}");


            // Object Initializer Syntax
            var fiat = new Car()
            {
                Year = 2022,
                Make = "Fiat",
                Model = "Fiat 500",
                EngineNoise = "super small vroom",
                HonkNoise = "tiny beep beep",
                IsDrivable = true

            };

            parkingLot.CarList.Add(fiat);
            CarLot.numberOfCars++;

            Console.WriteLine($" Number of cars in Lot: {CarLot.numberOfCars}");

            //Custom Constructor
            var audi = new Car(2021, "Audi", "Audi q5", "VROOM", "HONK", true);

            parkingLot.CarList.Add(audi);
            CarLot.numberOfCars++;
            Console.WriteLine($" Number of cars in Lot: {CarLot.numberOfCars}");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            foreach (var car in parkingLot.CarList)
            {
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);

            }
        }
    }
}
