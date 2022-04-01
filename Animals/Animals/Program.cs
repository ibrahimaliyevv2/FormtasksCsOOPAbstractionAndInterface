using System;
using Models;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm();
            Horse horse1 = new Horse();
            horse1.Name = "at1";
            horse1.Gender = true;
            horse1.Age = 10;
            horse1.Sort = "Qarabag";
            farm.AddAnimal(horse1);

            Sheep sheep1 = new Sheep();
            sheep1.Name = "qoyun1";
            sheep1.Gender = true;
            sheep1.Age = 10;
            sheep1.Type = "Merinos";
            farm.AddAnimal(sheep1);

            foreach (var item in farm.GetAnimalsByName("at1"))
            {
                Console.WriteLine($"Name: {item.Name}, Gender: {item.Gender}, Age: {item.Age}");
            }

            Console.WriteLine("===========================");

            foreach (var item in farm.GetAnimalsByAge(2, 18))
            {
                Console.WriteLine($"Name: {item.Name}, Gender: {item.Gender}, Age: {item.Age}");
            }
        }
    }
}
