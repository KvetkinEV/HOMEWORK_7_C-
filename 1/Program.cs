Random rand = new Random();
            Console.Write("введите количество строк массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("введите количество столбцов массива: ");
            int n = int.Parse(Console.ReadLine());
            double[,] arr = new double[m,n];
            Console.WriteLine("массив:");
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    arr[i, k] = rand.NextDouble() * 100;
                    Console.Write("{0,6:F2}", arr[i, k]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
