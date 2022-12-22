Random rand = new Random();
            Console.Write("введите количество строк массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("введите количество столбцов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            Console.WriteLine("массив:");
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    arr[i, k] = rand.Next(1, 100);
                    Console.Write(" " + arr[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите первую позицию элемента:");
            int firstPosition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую позицию элемента:");
            int secondPosition = Convert.ToInt32(Console.ReadLine());

            if (firstPosition > m && secondPosition > n)
                Console.WriteLine("Такого числа введенному индексу не обнаружено!");
            else
            {
                object Element = arr.GetValue(firstPosition, secondPosition);
                Console.WriteLine("Ваш элемент по идексу: " + Element);
            }

            Console.ReadLine();
