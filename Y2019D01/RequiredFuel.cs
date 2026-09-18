using System.ComponentModel.Design;

namespace Y2019D01;

public class RequiredFuel
{
    public double CalculateRequiredFuel(int[] masses)
    {
        double totalFuel = 0;

        foreach (int mass in masses)
        {
            double fuel = (mass / 3) - 2;
            totalFuel += fuel > 0 ? fuel : 0;
        }

        return totalFuel;
    }

    public double CalculateRequiredFuelWithFuel(int[] masses)
    {
        int totalFuel = 0;

        foreach (int mass in masses)
        {
            int fuel = (mass / 3) - 2;
            if (fuel > 0)
            {
                while (fuel > 0)
                {
                    totalFuel += fuel;
                    fuel = (fuel / 3) - 2;
                }
            }
            else
            {
                return 0;
            }
            /*while (fuel > 0)
            {
                totalFuel += fuel;
                fuel = (fuel / 3) - 2;
            }*/
            
        }

        return totalFuel;
    }
}