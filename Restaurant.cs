namespace LABB4_Generics_SUT24
{
    internal class Restaurant
    {
        private List<MenuItem> _menuItem = new List<MenuItem>();
        private Queue<Order> _orders = new Queue<Order>();

        
        public void AddtoMenu(MenuItem menuItem)
        {
            _menuItem.Add(menuItem);
            Console.WriteLine($"{menuItem} was added to the menu.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("La Mafioso's Menu:");
            foreach(var item in _menuItem)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("::--------------------------------------------------------::");
        }

        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order);
            Console.WriteLine($"::------------------::New orders::--------------------::");
            Console.WriteLine($"{order}\n");
        }

        public void HandleOrder()
        {
            var orderReady = _orders.Dequeue();
            Console.WriteLine($"::-------------::Order ready for service::---------------::");
            Console.WriteLine($"{orderReady}\n");
        }
        public void ShowOrders()
        {
            
            if(_orders.Count == 0)
            {
                Console.WriteLine("There are no current orders.");
            }
            else
            {
                var count = 0;
                foreach (var order in _orders)
                {
                    
                    count++;
                    Console.WriteLine($"::---------------------::Order: {count}::-----------------------::");
                    Console.WriteLine(order);
                }
            }
        }
        public void ShowNextOrder()
        {
            if (_orders.Count == 0)
            {
                Console.WriteLine("There are no current orders.");
            }
            else
            {
                var nextOrder = _orders.Peek();
                Console.WriteLine($"::--------------------::Next Order::----------------------::");
                Console.WriteLine($"{nextOrder}\n");
            }
            
        }
        public void ShowOrderCount()
        {
            if (_orders.Count == 0)
            {
                Console.WriteLine("There are no current orders.");
            }
            else
            {
                Console.WriteLine("::--------------------------------------------------------::");
                Console.WriteLine($"Currently we have {_orders.Count} orders");
            }
        }
    }
}
