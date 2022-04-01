using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Farm
    {
        Animal[] Animals = new Animal[0];
        
        
        public void AddAnimal(Animal animal)
        {
            Array.Resize(ref Animals, Animals.Length+1);
            Animals[Animals.Length - 1] = animal;
        }

        public Animal[] GetAnimalsByName(string name)
        {
            Animal[] FilteredAnimals = new Animal[0];
            int j = 0;
            foreach (var item in Animals)
            {
                if (item.Name == name)
                {
                    Array.Resize(ref FilteredAnimals, FilteredAnimals.Length + 1);
                    FilteredAnimals[FilteredAnimals.Length - 1] = item;
                    j++;
                }
            }
            return FilteredAnimals;
        }

        public Animal[] GetAnimalsByAge(int fromAge, int toAge)
        {
            Animal[] FilteredAnimals2 = new Animal[0];
            int j = 0;
            foreach (var item in Animals)
            {
                if (item.Age<toAge && item.Age>fromAge)
                {
                    Array.Resize(ref FilteredAnimals2, FilteredAnimals2.Length + 1);
                    FilteredAnimals2[FilteredAnimals2.Length - 1] = item;
                    j++;
                }
            }
            return FilteredAnimals2;
        }

    }
}
