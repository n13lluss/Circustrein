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
        public List<Animal> animals = new List<Animal>();

        public bool CanBeAdded(Animal animal)
        {
            if(SaveToAdd(animal) && EnoughSpace(animal))
            {           
                return true;
            }
            return false;
        }

        public bool SaveToAdd(Animal animal) 
        {
            if(!animal.CanEat(animals) && !animal.GetsEaten(animals))
            {
                return true;
            }
            return false;
        }

        public bool EnoughSpace(Animal animal)
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
