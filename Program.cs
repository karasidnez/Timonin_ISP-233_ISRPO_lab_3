namespace lab_3

{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //for(;i<=10 ;i++ ) {
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int sum = 0;
            //for(int i = 1; i <=10; i++) {
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            //for (int i = 0, j = 0; i <= 10; i++,j++) {
            //    Console.WriteLine($"{i*j}");
            //int k = -1;
            //do {
            //    Console.WriteLine(k);
            //    k--;


            //}
            //while (k > 0);

            //int i = 10;
            //while (i > 0) {
            //    Console.WriteLine(i);
            //    i--;
            //}

            //string text = "Hello world";
            //foreach (char symbol in text) {
            //    Console.WriteLine(symbol);

            //}

            //for(int i = 0; i < 10; i++) {
            //    if (i == 6) break;
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 10; i++) {
            //    for(int j = 1; j < 10; j++) {
            //        Console.WriteLine($"{i * j}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Салам,напиши что нибудь(для выхода напиши 'спасите')");
            //while (true) {
            //    var s = Console.ReadLine();
            //    if (s.ToLower() == "спасите") break;
            //    Console.WriteLine(s);
            //}

            //Задание 1
            //Console.Write("Введите состояние (Red/Yellow/Green): ");
            //string input = Console.ReadLine();

            //TrafficLight next = input switch
            //{
            //    "Red" => TrafficLight.Yellow,
            //    "Yellow" => TrafficLight.Green,
            //    "Green" => TrafficLight.Red,
            //};

            //Console.WriteLine($"Следующее: {next}");

            //Задание 2
            //Console.Write("Статус заказа: ");
            //string input = Console.ReadLine();

            //OrderStatus status = input.ToLower() switch
            //{
            //    "new" => OrderStatus.New,
            //    "processing" => OrderStatus.Processing,
            //    "shipped" => OrderStatus.Shipped,
            //    "delivered" => OrderStatus.Delivered
                
            //};

            //Console.WriteLine(status == OrderStatus.New || status == OrderStatus.Processing);

            //Задание 3
            //int a = 10;
            //for (int i = 1;i<=10; i++)
            //{
            //    Console.WriteLine(a);
            //    a--;
            //}

            //Задание 4
            //int a = 1;
            //for (int i = 1;i<=10; i++)
            //{
            //    Console.WriteLine($"5 x {a} = {a*5}");
            //    a++;
            //}

            //Задание 5
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Запомни: всего одна ошибка и ты ошибся");

            //}

            //Задание 6
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine($"Квадрат числа {i} равен {i*i}");
            //}

            //Задание 7
            //string? a = Console.ReadLine();
            //int b = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= b; i++)
            //{
            //    Console.WriteLine(a);
            //}

            //Задание 8
            //int b = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    if (a % 2 == 0)
            //    {
            //        b++;
            //    }
            //}

            //if (b == 10)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            //Задание 9
            //int a = 0;
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine("Нажмите Enter для выстрела: ");
            //    string b = Console.ReadLine();
            //    if (b == "")
            //    {
            //        a++;
            //        Console.WriteLine("Пиу");
            //    }
            //    if (b == "Стоп")
            //    {
            //        Console.WriteLine("Стрельба завершена");
            //        Console.WriteLine($"Израсходовано боеприпасов {a}");
            //        break;
            //    }
            //}

        }
    }
}
enum TrafficLight { Red, Yellow, Green }
enum OrderStatus { New, Processing, Shipped, Delivered }