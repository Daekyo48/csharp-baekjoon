class Class
{
    static void Main()
    {
        int testScore = int.Parse(Console.ReadLine()!);

        if (testScore >= 90)
        {
            Console.WriteLine('A');
        }
        else if (testScore >= 80)
        {
            Console.WriteLine('B');
        }
        else if (testScore >= 70)
        {
            Console.WriteLine('C');
        }
        else if (testScore >= 60)
        {
            Console.WriteLine('D');
        }
        else
        {
            Console.WriteLine('F');
        }
    }
}