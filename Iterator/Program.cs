namespace Iterator
{
    internal class Program
    {
        public class MenuItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        //Define the Iterator and Aggregate interfaces
        public interface IIterator<T>
        {
            bool HasNext();
            T Next();
        }
        public interface IAggregate<T>
        {
            IIterator<T> CreateIterator();
        }
        //Implement the Menus
        public class Menu : IAggregate<MenuItem>
        {
            private List<MenuItem> _items = new List<MenuItem>();
            public void AddItem(MenuItem item)
            {
                _items.Add(item);
            }
            public IIterator<MenuItem> CreateIterator()
            {
                return new MenuIterator(this);
            }
            private class MenuIterator : IIterator<MenuItem>
            {
                private Menu _menu;
                private int _currentIndex = 0;
                public MenuIterator(Menu menu)
                {
                    _menu = menu;
                }
                public bool HasNext()
                {
                    return _currentIndex < _menu._items.Count;
                }
                public MenuItem Next()
                {
                    return _menu._items[_currentIndex++];
                }
            }
        }
        static void Main(string[] args)
        {
            var livingRoomMenu = new Menu();
            livingRoomMenu.AddItem(new MenuItem { Name = "Sofa", Price = 599.99 });
            livingRoomMenu.AddItem(new MenuItem { Name = "Coffee Table", Price = 299.99 });
            livingRoomMenu.AddItem(new MenuItem { Name = "TV Stand", Price = 199.99 });

            var bedroomMenu = new Menu();
            bedroomMenu.AddItem(new MenuItem { Name = "Bed Frame", Price = 799.99 });
            bedroomMenu.AddItem(new MenuItem { Name = "Dresser", Price = 499.99 });
            bedroomMenu.AddItem(new MenuItem { Name = "Nightstand", Price = 149.99 });

            var kitchenMenu = new Menu();
            kitchenMenu.AddItem(new MenuItem { Name = "Kitchen Table", Price = 399.99 });
            kitchenMenu.AddItem(new MenuItem { Name = "Kitchen Cabinets", Price = 1999.99 });
            kitchenMenu.AddItem(new MenuItem { Name = "Kitchen Island", Price = 799.99 });

            var menus = new List<Menu> { livingRoomMenu, bedroomMenu, kitchenMenu };
            foreach (var menu in menus)
            {
                var iterator = menu.CreateIterator();
                while (iterator.HasNext())
                {
                    var item = iterator.Next();
                    Console.WriteLine($"Item: {item.Name}, Price: ${item.Price}");
                }
            }
        }
    }
}