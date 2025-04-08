class Class
{
    static void Main()
    {
        bool[] hasNumbers = new bool[30];

        for (int i = 0; i < 28; i++)
        {
            hasNumbers[int.Parse(Console.ReadLine()!) - 1] = true;
        }

        for (int i = 0; i < 30; i++)
        {
            if (!hasNumbers[i])
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}