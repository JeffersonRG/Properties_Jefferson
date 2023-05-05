using System;

namespace Properties_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            //asigns an id to an object names new car
            Car car = new Car();
            
            //asigns a make and modelto car
            car.Make = "Ford";
            car.Model = "Mustang";

            //prints out the make and model of car
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            //asigns an id to an object names new car
            Car car2 = new Car();
            
            //asign a make and model to car2
            car2.Make = "Chevy";
            car2.Model = "Camero";

            //prints out the make and model of car2
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            //asigns an id to an object names new car
            Car car3 = new Car();

            //prints out the make and model of car3
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");

        }
    }
}
