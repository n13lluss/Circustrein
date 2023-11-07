using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CircusTrainLibrary;

class Program
{
    static void Main()
    {
        Train train = new();

        train.AddAnimal("meat", "small");
        train.AddAnimal("plant", "medium");
        train.AddAnimal("plant", "medium");
        train.AddAnimal("plant", "medium");
        train.AddAnimal("plant", "large");
        train.AddAnimal("plant", "large");

        train.AddAnimalsToWagons();
    }
}