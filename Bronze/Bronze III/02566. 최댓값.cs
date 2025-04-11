class Class
{
    static void Main()
    {
        int maxNumber = 0;
        int maxNumberRow = 0;
        int maxNumberColumn = 0;

        for (int i = 0; i < 9; i++)
        {
            int[] rowNumbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            for (int j = 0; j < 9; j++)
            {
                if (rowNumbers[j] > maxNumber)
                {
                    maxNumber = rowNumbers[j];
                    maxNumberRow = i;
                    maxNumberColumn = j;
                }
            }
        }

        Console.WriteLine(maxNumber);
        Console.WriteLine($"{maxNumberRow + 1} {maxNumberColumn + 1}");
    }
}