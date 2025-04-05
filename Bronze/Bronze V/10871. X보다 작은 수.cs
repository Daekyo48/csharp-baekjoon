class Class
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine()!.Split()[1]);
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        foreach (int number in numbers)
        {
            if (number < x)
            {
                Console.Write($"{number} ");
            }
        }
    }
}