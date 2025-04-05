class Class
{
    static void Main()
    {
        int[] dicePips = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        Array.Sort(dicePips);

        if (dicePips[0] == dicePips[1] || dicePips[1] == dicePips[2])
        {
            Console.Write(1000 + dicePips[1] * 100);

            if (dicePips[0] == dicePips[2])
            {
                Console.WriteLine('0');
            }
        }
        else
        {
            Console.WriteLine(dicePips[2] * 100);
        }
    }
}