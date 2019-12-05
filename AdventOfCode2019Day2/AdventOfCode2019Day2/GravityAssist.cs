using System;

namespace AdventOfCode2019Day2
{
    public class GravityAssist
    {
        public int[] RestoreGravity(int[] intCodes)
        {
            Console.WriteLine($"Initial state: {string.Join(", ", intCodes)}");

            for (var i = 0; i < intCodes.Length;)
            {
                if (intCodes[i] == 1)
                {
                    //addition of the next 2 positions and store value in the third position
                    var sum = intCodes[intCodes[i + 1]] + intCodes[intCodes[i + 2]];
                    intCodes[intCodes[i + 3]] = sum;

                    i += 4;
                    continue;
                }

                if (intCodes[i] == 2)
                {
                    //same as before, but multiplication
                    var multiplication = intCodes[intCodes[i + 1]] * intCodes[intCodes[i + 2]];
                    intCodes[intCodes[i + 3]] = multiplication;

                    i += 4;
                    continue;
                }

                if (intCodes[i] == 99)
                {
                   break;
                }
            }

            return intCodes;
        }
    }
}