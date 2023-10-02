using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static readonly int[] MyNumbers = { 5, 13, 22, 33 };
    static readonly int MyBonusBall = 27;
    static readonly Random random = new Random();

    static void Main()
    {
        int drawings = 0;
        int totalCost = 0;
        int totalWon = 0;

        while (true)
        {
            drawings++;
            totalCost++;

            var drawnNumbers = DrawNumbers();
            var drawnBonus = DrawBonusBall();

            var matchingNumbers = MyNumbers.Intersect(drawnNumbers).Count();
            var matchingBonus = MyBonusBall == drawnBonus ? 1 : 0;

            int prize = CalculatePrize(matchingNumbers, matchingBonus);
            totalWon += prize;

            if (prize == 500000) // Jackpot
            {
                Console.WriteLine($"Hit the Jackpot after {drawings:N0} drawings!");
                Console.WriteLine($"Total Cost: ${totalCost:N0}, Total Won: ${totalWon:N0}");
                break;
            }

            if (drawings % 100000 == 0) // Just to show progress
            {
                Console.WriteLine($"After {drawings:N0} drawings, Total Cost: ${totalCost:N0}, Total Won: ${totalWon:N0}");
            }
        }
    }

    static List<int> DrawNumbers()
    {
        var numbers = new HashSet<int>();
        while (numbers.Count < 4)
        {
            numbers.Add(random.Next(1, 36));
        }
        return numbers.ToList();
    }

    static int DrawBonusBall()
    {
        return random.Next(1, 36);
    }

    static int CalculatePrize(int matchingNumbers, int matchingBonus)
    {
        if (matchingNumbers == 4 && matchingBonus == 1) return 500000; // Jackpot
        if (matchingNumbers == 4 && matchingBonus == 0) return 1500;
        if (matchingNumbers == 3 && matchingBonus == 1) return 50;
        if (matchingNumbers == 3 && matchingBonus == 0) return 30;
        if (matchingNumbers == 2 && matchingBonus == 1) return 20;
        if (matchingNumbers == 1 && matchingBonus == 1) return 7;
        if (matchingNumbers == 0 && matchingBonus == 1) return 5;
        return 0;
    }
}
