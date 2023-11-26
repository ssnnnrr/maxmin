using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Сколько дней вы записывали температуру? O.O: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] m = new int[n];

        Console.WriteLine("Введите записанную температуру:");

        for (int i = 0; i < n; i++)
        {
            m[i] = Convert.ToInt32(Console.ReadLine());

        }
        // арей индекс оф мы еще вроде не прошли но в метаните про него написано!
        int min = Array.IndexOf(m, m.Min());
        int max = Array.IndexOf(m, m.Max());
        Console.WriteLine($"day {min}: " + m.Min());
        Console.WriteLine($"day {max}: " + m.Max());
               
        }

    }
