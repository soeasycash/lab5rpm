using System;

class Program
{
    static int ConvertToSeconds(int hours, int minutes)
    {
        if (hours < 0 || minutes < 0 || minutes >= 60)
        {
            throw new ArgumentException("Недопустимые значения часов и минут.");
        }

        int seconds = (hours * 3600) + (minutes * 60);
        return seconds;
    }

    static void Main()
    {
        Console.Write("Write hourse: ");
        int hours = Int32.Parse(Console.ReadLine());
        Console.Write("Write minutes: ");
        int minutes = Int32.Parse(Console.ReadLine());

        int seconds = ConvertToSeconds(hours, minutes);
        Console.WriteLine($"{hours} часа(ов) и {minutes} минут(ы) составляют {seconds} секунд.");
    }
}
