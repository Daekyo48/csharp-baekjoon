class Class
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        int minNumber = numbers[0];
        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            minNumber = number < minNumber ? number : minNumber;
            maxNumber = number > maxNumber ? number : maxNumber;
        }

        Console.WriteLine($"{minNumber} {maxNumber}");
    }
}