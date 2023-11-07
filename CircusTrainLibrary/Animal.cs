using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainLibrary
{
    public class Animal
    {
        public DietType Diet { get; private set; }
        public AnimalSize Size { get; private set; }

        public Animal(string diet, string size)
        {
            if (diet == "plant")
            {
                Diet = DietType.PlantEater;
            }
            else if (diet == "meat")
            {
                Diet = DietType.MeatEater;
            }

            if (size == "small")
            {
                Size = AnimalSize.Small;
            }
            else if (size == "medium")
            {
                Size = AnimalSize.Medium;
            }
            else if (size == "large")
            {
                Size = AnimalSize.Large;
            }
        }

        public bool CanEat(Animal AnimalInWagon)
        {
            if (Diet == DietType.MeatEater && Size >= AnimalInWagon.Size)
            {
                return true;
            }
            return false;
        }

        public bool GetsEaten(Animal AnimalInWagon)
        {
            if (AnimalInWagon.Diet == DietType.MeatEater && Size <= AnimalInWagon.Size)
            {
                return true;
            }
            return false;
        }

        public int GetSpaceRequired()
        {
            switch (Size) {
                case AnimalSize.Small:
                    return 1;
                case AnimalSize.Medium:
                    return 3;
                case AnimalSize.Large:
                    return 5;
                default
                    : return 0;
            }
        }
    }
}
