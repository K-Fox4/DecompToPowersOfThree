using System;
using System.Collections.Generic;
using System.Text;

namespace DecompositionPowersThree.structure
{
    public static class Decomposer
    {

        private static int FindNearPowerOfThree(int numberX)
        {
            // Declare local variables and initialize

            int powerofThree = 0;
            int absNumberX = Math.Abs(numberX);

            // Get the nearest power of three based on the intervals

            if (absNumberX == 1)
            {
                powerofThree = 1;
            }
            else if (absNumberX >= 2 & absNumberX <= 4)
            {
                powerofThree = 3;
            }
            else if (absNumberX >= 5 & absNumberX <= 13)
            {
                powerofThree = 9;
            }
            else if (absNumberX >= 14 & absNumberX <= 40)
            {
                powerofThree = 27;
            }
            else if (absNumberX >= 41 & absNumberX <= 121)
            {
                powerofThree = 81;
            }

            if (numberX < 0)
            {
                powerofThree = -1 * powerofThree;
            }

            return powerofThree;
        }

        private static string DecomposeToPowersOfThree(int inputNumber)
        {
            // Declare local variables and initialize

            string decomposePowersOfThree = "";
            int numberDifference = inputNumber;

            // Iterate and determine the decomposition powers three for the input number

            while (Math.Abs(numberDifference) > 0)
            {
                // Call FindNearPowerOfThree static method
                
                int powerOfThree = Decomposer.FindNearPowerOfThree(numberX: numberDifference);

                // Update numberDifference

                numberDifference = numberDifference - powerOfThree;

                // Format the decomposition 

                if (powerOfThree < 0)
                {
                    decomposePowersOfThree += String.Format("- {0} ", Math.Abs(powerOfThree));
                }
                else
                {
                    if (decomposePowersOfThree == "")
                    {
                        decomposePowersOfThree += String.Format("{0} ", powerOfThree);
                    }
                    else
                    {
                        decomposePowersOfThree += String.Format("+ {0} ", powerOfThree);
                    }
                }
            }

            return decomposePowersOfThree.Trim();
        }

        public static string GetTheDecomposition(int inputNumber)
        {
            // Declare local variables and initialize

            string decomposition = "";

            // Call DecomposeToPowersOfThree static method

            string decompositionSplit = Decomposer.DecomposeToPowersOfThree(inputNumber: inputNumber);

            // Format the final output containing the input integer and decomposition to display
            
            if (inputNumber > 0)
            {
                decomposition = String.Format("{0} = {1}", inputNumber, decompositionSplit);
            }
            else
            {
                decomposition = String.Format("- {0} = {1}", Math.Abs(inputNumber), decompositionSplit);
            }

            return decomposition;
        }
    }
}
