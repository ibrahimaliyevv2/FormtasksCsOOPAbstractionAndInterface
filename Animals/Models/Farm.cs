using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Farm
    {
        public Animal[] Animals = new Animal[0];
        
        public void AddAnimal(Animal animal)
        {
            Array.Resize(ref Animals, Animals.Length+1);
            Animals[Animals.Length - 1] = animal;
        }

        public void GetAnimalsByName(string name)
        {
            foreach (var item in Animals)
            {
                if (item.Name == name)
                {
                    Console.WriteLine($"{item.Name} {item.Gender} {item.Age}");
                }
            }
        }

        public void GetAnimalsByAge(int fromAge, int toAge)
        {
            foreach (var item in Animals)
            {
                if (item.Age<toAge && item.Age>fromAge)
                {
                    Console.WriteLine($"{item.Name} {item.Gender} {item.Age}");
                }
            }
        }

    }
}
