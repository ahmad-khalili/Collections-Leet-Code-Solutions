namespace LeetCode.Collections;

public class Program
{
    public static int WateringPlants(int[] plants, int capacity) {
        int steps = 0;
        int cap = capacity;
        int i = 0;
        while (i < plants.Length)
        {
            if (plants[i] > cap)
            {
                int j = i;
                while (j > 0)
                {
                    j -= 1;
                    steps += 1;
                }

                cap = capacity;

                while (j < i)
                {
                    j += 1;
                    steps += 1;
                }
                
                cap -= plants[i];
                i++;
                steps++;
            }
            else
            {
                cap -= plants[i];
                i += 1;
                steps += 1;
            }
        }

        return steps;
    }
    
    static void Main()
    {
        int[] plants = new[] { 2, 2, 3, 3 };
        int capacity = 5;
        var steps = WateringPlants(plants, capacity);
        Console.WriteLine($"Total number of steps are: {steps}");
    }
}