using System;

namespace AdventOfCode2019Day2
{
    public class GravityAssist
    {
        private int OpcodeSum => 1;
        private int OpcodeMultiplication => 2;
        private int OpcodeHalt => 99;

        public int[] RestoreGravity(int[] intCodes)
        {
            //Console.WriteLine($"Initial state: {string.Join(", ", intCodes)}");

            for (var i = 0; i < intCodes.Length;)
            {
                if (intCodes[i] == OpcodeSum)
                {
                    //addition of the next 2 positions and store value in the third position
                    var sum = intCodes[intCodes[i + 1]] + intCodes[intCodes[i + 2]];
                    intCodes[intCodes[i + 3]] = sum;

                    i += 4;
                    continue;
                }

                if (intCodes[i] == OpcodeMultiplication)
                {
                    //same as before, but multiplication
                    var multiplication = intCodes[intCodes[i + 1]] * intCodes[intCodes[i + 2]];
                    intCodes[intCodes[i + 3]] = multiplication;

                    i += 4;
                    continue;
                }

                if (intCodes[i] == OpcodeHalt)
                {
                    break;
                }
            }

            return intCodes;
        }
    }
}