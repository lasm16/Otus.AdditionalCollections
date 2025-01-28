using System.Collections.ObjectModel;

namespace RegularCustomer
{
    internal class Shop
    {
        public Shop(Customer customer)
        {
            items.CollectionChanged += customer.OnItemChanged;
        }
        private ObservableCollection<Item> items = [];

        public void Add(Item item) => items.Add(item);
        public void Remove(int id)
        {
            var item = items.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                items.Remove(item);
            }
            else
            {
                Console.WriteLine($"Товар с id {id} не найден!");
            }
        }
    }
}
