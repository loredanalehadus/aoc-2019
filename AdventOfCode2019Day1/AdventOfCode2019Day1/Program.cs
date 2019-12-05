using System;
using System.Linq;

namespace AdventOfCode2019Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalFuel = Part1();
            var totalFuelPlusMass = Part2();

            Console.WriteLine($"Total fuel: {totalFuel}.");
            Console.WriteLine($"Total fuel + it's mass: {totalFuelPlusMass}.");

        }

        private static int Part1()
        {
            var module = new Module();
            return new SpaceShip().Masses.Sum(mass => module.CalculateFuel(mass));
        }

        private static int Part2()
        {
            var module = new Module();

            return new SpaceShip().Masses.Sum(mass => module.CalculateFuelUntilFullTank(mass));
        }
    }
}
