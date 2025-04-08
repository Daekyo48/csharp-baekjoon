class Class
{
    static void Main()
    {
        int maxNumber = 0;
        int maxNumberIndex = 0;

        for (int i = 1; i < 10; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine()!);

            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
                maxNumberIndex = i;
            }
        }

        Console.WriteLine(maxNumber);
        Console.WriteLine(maxNumberIndex);
    }
}