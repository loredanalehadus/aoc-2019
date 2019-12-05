namespace AdventOfCode2019Day1
{
    public class Module
    {
        public int CalculateFuel(int mass)
        {
            return mass / 3 - 2;
        }

        public int CalculateFuelUntilFullTank(int mass)
        {
            var fuel = CalculateFuel(mass);
            int totalFuel = fuel;

            while (fuel > 0)
            {
                fuel = CalculateFuel(fuel);

                if (fuel > 0)
                {
                    totalFuel += fuel;
                }
            }

            return totalFuel;
        }
    }
}