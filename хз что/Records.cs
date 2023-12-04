using Newtonsoft.Json;

namespace SpeedTest
{
    internal class Records
    {
        static public List<user> list = new();
        static public string path = "C:\\Users\\danil\\Desktop\\text\\records.json";
        static public void SaveRecords()
        {
            user user_Table = new();

            Console.Clear();
            File.WriteAllText(path, "");
            Console.WriteLine($"{user.name}, брат, это твои результаты:");
            user_Table.name_table = user.name;
            Console.WriteLine($"{user.SimPerMin} брат,это  символов в минуту");
            user_Table.SimPerMin_table = user.SimPerMin;
            Console.WriteLine($"{user.SimPerSec} братанчик,это символов в секунду");
            user_Table.SimPerSec_table = user.SimPerSec;
            Console.WriteLine($"{user.miss} опечаток");
            user_Table.miss_table = user.miss;

            list.Add(user_Table);
            string RecordsJson = JsonConvert.SerializeObject(list);
            File.AppendAllText(path, RecordsJson);

            Console.WriteLine("\n Рекорды: ");
            List<user> result = JsonConvert.DeserializeObject<List<user>>(File.ReadAllText(path));
            foreach (var el in result)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(el.name_table);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(el.SimPerMin_table + " символов в минуту");
                Console.WriteLine(el.SimPerSec_table + " символов в секунду");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(el.miss_table + " опечаток");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("....................");
            }
        }
    }
}