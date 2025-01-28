
namespace RegularCustomer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var shop = new Shop(customer);
            
            var isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Нажмите A, чтобы добавить товар \r\n"
                    + "Нажмите D, чтобы удалить товар \r\n"
                    + "Нажмите Х, чтобы выйти из программы \r\n");
                var key = Console.ReadKey();
                Console.WriteLine();
                switch (key.KeyChar)
                {
                    case 'A':
                        AddItemToShop(shop);
                        break;
                    case 'D':
                        RemoveItemFromShop(shop);
                        break;
                    case 'X':
                        isRunning = false;
                        break;
                }
            }
        }

        private static void RemoveItemFromShop(Shop shop)
        {
            Console.WriteLine("Введите id товара: \r\n");
            var id = int.Parse(Console.ReadLine()!);
            shop.Remove(id);
        }

        private static void AddItemToShop(Shop shop)
        {
            var item = new Item
            {
                Name = $"Товар от {DateTime.Now}",
                Id = new Random().Next(0, 100000)
            };
            shop.Add(item);
        }
    }
}
