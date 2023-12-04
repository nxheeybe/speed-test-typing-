using System.Threading;

namespace SpeedTest
{
    internal class Class_write
    {
        static public int x = 0;
        static public int y = 1;
        static public void Writing()
        {
            Thread thread = new Thread(new ThreadStart(Program.Timer));
            thread.Start(); 
            string path = "C:\\Users\\danil\\Desktop\\text\\";
            Random random = new Random();
            int num = random.Next(Convert.ToInt32(Directory.GetFiles(path).Length) - 1);
            string text = File.ReadAllText($"{path}{num}.txt");
            List<char> chars = new();

            foreach (char l in text)
            {
                chars.Add(l);
                Console.Write(l);
            }

            int i = 0;
            int miss = 0;
            while (i < chars.Count && Program.typing == true)
            {
                Console.SetCursorPosition(x, y);
                ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                Console.CursorVisible = false;

                if (key.KeyChar.Equals(chars[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(chars[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    i++;
                    x++;
                    if (x == Console.BufferWidth)
                    {
                        x = 0;
                        y++;
                    }
                }
                else
                {
                    i += 0; 
                    miss++;
                }
            }
            user.SimPerMin = i;
            user.SimPerSec = user.SimPerMin / 60;
            user.miss = miss;
        }
    }
}