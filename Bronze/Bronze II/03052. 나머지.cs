class Class
{
    static void Main()
    {
        int count = 0;
        bool[] isUnique = new bool[42];

        for (int i = 0; i < 10; i++)
        {
            isUnique[int.Parse(Console.ReadLine()!) % 42] = true;
        }

        foreach (bool number in isUnique)
        {
            if (number)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}