//// дз цифра
//// номер 1

//Console.Write("введите длину пароля ");
//int n = int.Parse(Console.ReadLine());
//string a = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
//Random random = new Random();
//string parol = "";
//for (int i = 1; i <= n; i++)
//{
//    int b = random.Next(a.Length);
//    parol += a[b];
//}
//Console.WriteLine("Ваш пароль = " + parol);





//// номер 2
//Random random = new Random();
//int temperature = 0;
//while (temperature < 90)
//{
//    temperature = random.Next(101);
//    Console.WriteLine(temperature);
//    if (temperature >= 90)
//    {
//        Console.WriteLine("Лимит температуры превышен!!!");
//    }
//}





//// дз телеграм
//// номер 1

//Console.WriteLine("введите количество элементов массива");
//int n = int.Parse(Console.ReadLine()); 
//int[] mas = new int[n];
//Random Random = new Random(); 
//int max = -101;
//int r1 = max; int count = 0;
//int kolich = 1; 
//for (int i = 0; i < mas.Length; i++)
//{
//    int r = Random.Next(-100, 101);
//    if (r >= r1)
//    {
//        mas[i] = r; 
//        Console.Write(mas[i] + " ");
//        r1 = r;
//    }
//    else
//    {
//        i--;
//    }
//}
//Console.WriteLine();
//for (int i = 1; i < mas.Length; i++)
//{
//    for (int j = i - 1; j >= 0; j--)
//    {
//        if (mas[i] == mas[j])
//        {
//            count++;
//        }
//    }
//    if (count == 0)
//    {
//        kolich += 1;
//    }
//    count = 0;
//}
//Console.WriteLine(kolich);


//// номер 2

//int count = 0;
//int max = 0;
//Console.WriteLine("Введите количество элементов массива ");
//int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random Random = new Random();
//for (int i = 0; i < n; i++)
//{
//    int r = Random.Next(11);
//    mas[i] = r;
//    Console.Write(r + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] % 2 != 0)
//    {
//        count++;
//        if (count > max)
//        }
//    }
//    else
//    {
//        {
//            max = count;
//        count = 0;
//    }
//}
//Console.WriteLine(max);