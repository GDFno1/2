using System;

class UngaBung
{
    static void Main()
    {
        int prev = 0;
        int current = 1;
        int temp;
        int g;

        Console.WriteLine("Enter a col of fibbonachi numbers!");
        g = Int32.Parse(Console.ReadLine());
        Console.Clear();

        for (int i = 0; i <= g; i++)
        {
            Console.WriteLine(current);
            temp = current;
            current = current + prev;
            prev = temp;
        }
        Console.ReadKey();
    }
}