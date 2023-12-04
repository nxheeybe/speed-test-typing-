using Newtonsoft.Json;
using System.Diagnostics;


namespace SpeedTest
{
    internal class Program
    {
        static public bool typing = true;
        static void Main(string[] args)
        {
            GetName();

            for (int j = 0; j < Console.WindowWidth; j++)
            {
                Console.Write("-");
            }
            string hello = "Тест на скорость печати";
            Console.SetCursorPosition(Console.WindowWidth / 2 - hello.Length / 2, 0);
            Console.WriteLine(hello);

            Class_write.Writing();
            Records.SaveRecords();

            Console.WriteLine("Enter - попробовать еще\nESC - выход");
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(intercept: true);
                switch (Key.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Records.list.Clear();
                        Main(args);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void GetName()
        {
            if (File.Exists(Records.path) && File.ReadAllBytes(Records.path).Length != 0)
            {
                List<user> result = JsonConvert.DeserializeObject<List<user>>(File.ReadAllText(Records.path));
                foreach (var el in result)
                {
                    Records.list.Add(el);
                }
            }
            Console.WriteLine("Введите никнэйм для таблички: ");
            try
            {
                user.name = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Саламчик, " + user.name);
            Thread.Sleep(1500);
            Console.Clear();
            for (int i = 3; i >= 0; i--)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Начало через: " + i);
                Thread.Sleep(1000);
            }
            Console.Clear();
        }
        static public void Timer()
        {
            for (int stop = 60; stop >= 0; stop--)
            {
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, 0);
                if (stop >= 10)
                {
                    Console.Write($"00:{stop}");
                }
                else
                {
                    Console.Write($"00:0{stop}");
                }
                Console.SetCursorPosition(Class_write.x, Class_write.y);
                if (stop == 0)
                {
                    typing = false;
                }
                else
                {
                    typing = true;
                }
            }
        }
    }
}