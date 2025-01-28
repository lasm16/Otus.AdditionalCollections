
using System.Collections.Concurrent;

namespace Librarian
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var isRunning = true;
            var dict = new ConcurrentDictionary<string, int>();
            //var task1 = new Task(() => CalculateBooksPercent(dict));
            //task1.Start();

            Parallel.Invoke(
                () => CalculateBooksPercent(dict));
            while (isRunning)
            {
                Console.WriteLine("1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");
                var key = Console.ReadKey();
                Console.WriteLine();

                switch (key.KeyChar)
                {
                    case '1':
                        AddBook(dict);
                        break;
                    case '2':
                        ShowBooks(dict);
                        break;
                    case '3':
                        isRunning = false;
                        break;
                }
            }
        }

        private static void CalculateBooksPercent(ConcurrentDictionary<string, int> dictionary)
        {
            if (!dictionary.IsEmpty)
            {
                foreach (var keyValue in dictionary)
                {
                    dictionary.AddOrUpdate(keyValue.Key, keyValue.Value, (key, oldValue) => oldValue + 1);
                    var val = dictionary.TryGetValue(keyValue.Key, out var value);
                    if (value == 100)
                    {
                        dictionary.TryRemove(keyValue);
                    }
                }
            }
            Task.Delay(1000);
        }

        private static void ShowBooks(ConcurrentDictionary<string, int> dictionary)
        {
            if (!dictionary.IsEmpty)
            {
                foreach (var keyValue in dictionary)
                {
                    Console.WriteLine($"{keyValue.Key} - {keyValue.Value}%");
                }
            }
        }

        private static void AddBook(ConcurrentDictionary<string, int> dictionary)
        {
            Console.WriteLine("Введите название книги:");
            var bookName = Console.ReadLine();
            var isBookInDict = dictionary.ContainsKey(bookName!);
            if (isBookInDict)
            {
                return;
            }
            else
            {
                dictionary.TryAdd(bookName!, 0);
                Console.WriteLine("Книга добавлена в библиотеку! \r\n");
            }
        }
    }
}
