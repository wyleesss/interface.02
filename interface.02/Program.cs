using System.Text;
using Tanks;
using Tanks.Comparers;

internal static class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Random random = new Random();
        List<Tank> tanks = new();

        tanks.Capacity = 10;

        Console.WriteLine("до сортування за вагою:\n");

        for (int i = 0; i < 3; i++) 
        {
            tanks.Add(new Tank($"{(char)random.Next(65, 72)}{random.Next(600, 700)}",
                               random.Next(1, 100),
                               random.Next(1, 100),
                               random.Next(1, 100),
                               (float)random.Next(1, 100) / 10));
            Console.WriteLine(tanks[i]);
        }

        Console.WriteLine($"порівняння за вагою першого і другого танків видало -> " +
                          $"{tanks[0].CompareTo(tanks[1], new WeightComparer())}");

        Console.WriteLine($"порівняння за вагою другого і третього танків видало -> " +
                          $"{tanks[1].CompareTo(tanks[2], new WeightComparer())}");

        tanks.Sort(new WeightComparer());

        Console.WriteLine("\n\nпісля сортування за вагою:\n");

        foreach (Tank tank in tanks)
            Console.WriteLine(tank);

        Console.WriteLine($"порівняння за вагою першого і другого танків видало -> " +
                          $"{tanks[0].CompareTo(tanks[1], new WeightComparer())}");

        Console.WriteLine($"порівняння за вагою другого і третього танків видало -> " +
                          $"{tanks[1].CompareTo(tanks[2], new WeightComparer())}");

    }
}