using System;

namespace NoDefaultCase
{
    public static class Program
    {
        public const string Database = "MongoDB";

        public static string GetDb()
        {
            switch (Database)
            {
                case "MongoDB":
                    return Database;
            }
        }

        public static void Main()
        {
            Console.WriteLine($"The value returned is \"{GetDb()}\".");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
