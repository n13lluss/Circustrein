using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainLibrary
{
    public class Wagon
    {
        private List<Animal> animals = new List<Animal>();
        public IReadOnlyList<Animal> Animals { get {  return animals; } }

        public bool TryAddAnimal(Animal animal)
        {
            if(SafeToAdd(animal) && EnoughSpace(animal))
            {         
                animals.Add(animal);
                return true;
            }
            return false;
        }

        private bool SafeToAdd(Animal animal) 
        {
            foreach(Animal AnimalInWagon in animals)
            {
                if (animal.CanEat(AnimalInWagon) && animal.GetsEaten(AnimalInWagon))
                {
                    return false;
                }
            }
            return true;
        }

        private bool EnoughSpace(Animal animal)
        {
            int sum = animals.Sum(anim => anim.GetSpaceRequired());
            int result = sum + animal.GetSpaceRequired();
            if (result <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
