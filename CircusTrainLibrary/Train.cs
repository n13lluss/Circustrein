using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainLibrary
{
    public class Train
    {
        public readonly List<Wagon> wagons = new List<Wagon>();
        private readonly List<Animal> animals= new List<Animal>();

        public void AddAnimal(string size, string diet)
        {
            Animal animal = new Animal(size, diet);
            animals.Add(animal);
        }

        public void AddAnimalsToWagons()
        {
            List<Animal> sortedAnimals = sortAnimals(animals);
            foreach (Animal animal in sortedAnimals)
            {
                bool added = false;
                
                foreach(Wagon wagon in wagons) { 
                
                    if(!added)
                    {
                        added = wagon.TryAddAnimal(animal); 
                    }

                }

                if (!added)
                {
                    Wagon Wagon = new Wagon();
                    Wagon.TryAddAnimal(animal);
                    wagons.Add(Wagon);
                }
            }
            PrintWagons();
        }

        public void PrintWagons()
        {
            int wagonCount = 1;
            foreach(Wagon wagon in wagons)
            {
                Console.WriteLine($"Wagon {wagonCount}, count = {wagon.Animals.Sum(animal => animal.GetSpaceRequired())}");
                foreach(Animal animal in wagon.Animals)
                {
                    Console.WriteLine($"{animal.Size} and is {animal.Diet}");
                }
                wagonCount++;
            }
        }

        public List<Animal> sortAnimals(List<Animal> animals)
        {
            int mediumCount = 0;
            List<Animal> sortedAnimals = new List<Animal>();
            foreach (Animal animal in animals)
            {
                if(animal.Size == AnimalSize.Medium && animal.Diet == DietType.PlantEater)
                {
                    mediumCount++;
                }
            }

            if(mediumCount % 3 == 0)
            {
                sortedAnimals = animals.Where(animal => animal.Diet == DietType.MeatEater).OrderByDescending(animal => animal.Size).ToList();
                sortedAnimals.AddRange(animals.Where(animal => animal.Diet == DietType.PlantEater).Where(animal => animal.Size == AnimalSize.Medium).ToList());
                sortedAnimals.AddRange(animals.Where(animal => animal.Diet == DietType.PlantEater).Where(animal => animal.Size == AnimalSize.Small || animal.Size == AnimalSize.Large).OrderBy(animal => animal.Size).ToList());
            }
            else
            {
                sortedAnimals = animals.OrderBy(animal => animal.Diet).ThenByDescending(animal => animal.Size).ToList();
            }
            return sortedAnimals;
        }
    }
}
