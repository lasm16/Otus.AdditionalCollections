using System.Collections.Specialized;

namespace RegularCustomer
{
    internal class Customer
    {
        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            
            switch (e.Action)
            {
                
                case NotifyCollectionChangedAction.Add:
                    var newItem = (Item)e.NewItems![0]!;
                    Console.WriteLine($"Добавлен элемент {newItem.Id}, {newItem.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    var oldItem = (Item)e.OldItems![0]!;
                    Console.WriteLine($"Удален элемент {oldItem.Id}, {oldItem.Name}");
                    break;
            }
        }
    }
}
