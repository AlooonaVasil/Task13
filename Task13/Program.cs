﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул.Сизова дом 3 кв.2", 1000, 5000, 6000);
            Console.WriteLine(building.Print());
            MulriBuilding multiBuilding = new MulriBuilding("ул.Черкасова дом 8 кв.442", 100, 222, 555, 0);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }



}
