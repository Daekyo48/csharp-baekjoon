class Class
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();

        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);
        int[,] sumMatrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] rowA = Console.ReadLine()!.Split();

            for (int j = 0; j < m; j++)
            {
                sumMatrix[i, j] = int.Parse(rowA[j]);
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            string[] rowB = Console.ReadLine()!.Split();

            for (int j = 0; j < m; j++)
            {
                sumMatrix[i, j] += int.Parse(rowB[j]);
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(sumMatrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}