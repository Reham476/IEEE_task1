namespace IEEE_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // 1
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);

            //2
            //string text = "123abc";
            //int result = int.Parse(text);
            //Console.WriteLine(result);
            //Unhandled exception. System.FormatException: The input string '123abc' was not in a correct format.

            //3
            //double a = 0.1;
            //double b = 0.2;
            //double sum = a + b;
            //Console.WriteLine(sum);
            // output : 0.30000000000000004

            //4
            //string text = "Hello World";
            //string sub = text.Substring(6, 5);
            //Console.WriteLine(sub);

            //5
            //int first = 10;
            //int second = first;
            //second = 25;
            //Console.WriteLine(first);
            //Console.WriteLine(second);
            //output : 10 25 
            //6 
            //int[] first = { 1, 2, 3 };
            //int[] second = first;
            //second[0] = 99;
            //Console.WriteLine(first[0]);
            //Console.WriteLine(second[0]);
            // same result because both have same address 

            //7
            //string part1 = "Hello";
            //string part2 = "C#";
            //string combined = part1 + " " + part2;
            //Console.WriteLine(combined);
            //8
            //double principal = double.Parse(Console.ReadLine());
            //double rate = double.Parse(Console.ReadLine());
            //double time = double.Parse(Console.ReadLine());
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine(interest);

            //9
            //double weight = double.Parse(Console.ReadLine());
            //double height = double.Parse(Console.ReadLine());
            //double bmi = weight / (height * height);
            //Console.WriteLine(bmi);

            //10
            //int temp = int.Parse(Console.ReadLine());
            //string result = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine(result);

            //11
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine($"date: {date.Day} , {date.Month} , {date.Year}");
            //Console.WriteLine($"date: {date.Day} / {date.Month} / {date.Year}");
            //Console.WriteLine($"date: {date.Day} - {date.Month} - {date.Year}");

            //12
            //int n = int.Parse(Console.ReadLine());
            //if (n % 3 == 0 && n % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            //13
            //int n = int.Parse(Console.ReadLine());
            //if (n < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");

            //14
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;

            //int min = a;
            //if (b < min) min = b;
            //if (c < min) min = c;

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");

            //15
            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");

            //16
            //char ch = char.ToLower(Console.ReadLine()[0]);
            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //    Console.WriteLine("Vowel");
            //else
            //    Console.WriteLine("Consonant");

            //17
            //int month = int.Parse(Console.ReadLine());
            //int days;
            //switch (month)
            //{
            //    case 2:
            //        days = 28;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    default:
            //        days = 31;
            //        break;
            //}
            //Console.WriteLine($"Days in Month: {days}");

            //18
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //19
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(n * i + " ");
            //}

            //20
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n; i += 2)
            //{
            //    Console.Write(i + " ");
            //}

            //21
            //int b = int.Parse(Console.ReadLine());
            //int exp = int.Parse(Console.ReadLine());
            //long result = 1;
            //for (int i = 0; i < exp; i++)
            //{
            //    result *= b;
            //}
            //Console.WriteLine(result);

            //22
            //int total = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    total += int.Parse(Console.ReadLine());
            //}
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100.0;
            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");

            //23
            //string s = Console.ReadLine()!;
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(s[i]);
            //}

            //24
            //int n = int.Parse(Console.ReadLine());
            //while (n != 0)
            //{
            //    Console.Write(n % 10);
            //    n /= 10;
            //}

            //25
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    if (i < 2) continue;
            //    bool isPrime = true;
            //    for (int j = 2; j * j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //        Console.Write(i + " ");
            //}

            //26
            //int n = int.Parse(Console.ReadLine());
            //string binary = "";
            //if (n == 0)
            //{
            //    binary = "0";
            //}
            //else
            //{
            //    while (n > 0)
            //    {
            //        binary = (n % 2) + binary;
            //        n /= 2;
            //    }
            //}
            //Console.WriteLine($"The Binary is: {binary}");

            //27
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());

            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //    Console.WriteLine("Points lie on single straight line.");
            //else
            //    Console.WriteLine("Points do not lie on single straight line.");

            //28
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write((i == j ? 1 : 0) + " ");
            //    }
            //    Console.WriteLine();
            //}

            //29
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);

            //30
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //int[] b = new int[n];
            //for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++) b[i] = int.Parse(Console.ReadLine());

            //int[] merged = new int[n * 2];
            //for (int i = 0; i < n; i++)
            //{
            //    merged[i] = a[i];
            //    merged[n + i] = b[i];
            //}

            //Array.Sort(merged);
            //foreach (int x in merged)
            //{
            //    Console.Write(x + " ");
            //}

            //31
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //bool[] visited = new bool[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    if (visited[i]) continue;
            //    int count = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            visited[j] = true;
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"{arr[i]} occurs {count} times");
            //}

            //32
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max) max = arr[i];
            //    if (arr[i] < min) min = arr[i];
            //}
            //Console.WriteLine($"Max = {max}, Min = {min}");

            //33
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;
            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = arr[i];
            //    }
            //    else if (arr[i] > secondLargest && arr[i] != largest)
            //    {
            //        secondLargest = arr[i];
            //    }
            //}
            //Console.WriteLine(secondLargest);

            //34
            //string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //int[] arr = new int[parts.Length];
            //for (int i = 0; i < parts.Length; i++) arr[i] = int.Parse(parts[i]);

            //int maxDist = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = arr.Length - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int dist = j - i - 1;
            //            if (dist > maxDist) maxDist = dist;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine(maxDist);

            //35
            //string[] words = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));

            //36
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());
            //int[,] first = new int[rows, cols];
            //int[,] second = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        first[i, j] = int.Parse(Console.ReadLine());
            //        second[i, j] = first[i, j];
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(second[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //37
            //int n = int.Parse(Console.ReadLine()!);
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine()!);

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}



        }
        static void ByValue(int x)
        {
            x = 50;
        }

        static void ByReference(ref int x)
        {
            x = 50;
        }
        static void RefByValue(int[] arr)
        {
            arr = new int[] { 10, 20 };
        }

        static void RefByReference(ref int[] arr)
        {
            arr = new int[] { 10, 20 };
        }
        static (int sum, int diff) CalculatePair(int a, int b, int c, int d)
        {
            return (a + b, c - d);
        }
        static int SumDigits(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
        }
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static string ChangeChar(string text, int index, char newChar)
        {
            char[] chars = text.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
    }
}
