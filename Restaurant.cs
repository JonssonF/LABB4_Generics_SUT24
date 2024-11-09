namespace LABB4_Generics_SUT24
{
    internal class Restaurant
    {
        private List<MenuItem> _menuItem = new List<MenuItem>();
        private Queue<Order> _orders = new Queue<Order>();
        public DateTime TimeStamp { get; set; }

        //Method to add items to the menu.
        public void AddtoMenu(MenuItem menuItem)
        {
            _menuItem.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} was added to the menu.");
            
        }
        //Method to show the restaurants menu.
        public void ShowMenu()
        {
            Console.WriteLine("::--------------------------------------------------------::");
            Console.WriteLine("La Mafioso's Menu:");
            foreach (var item in _menuItem)
            {
                Console.WriteLine(item);
            }
        }
        // Method to add orders in que.
        public void CreateOrder(Order order)
        {
            TimeStamp = DateTime.Now;
            _orders.Enqueue(order);
            Console.WriteLine($"::--------------------::New order::----------------------::");
            Console.WriteLine($"{order}\n");
            Console.WriteLine($"The order was placed at {TimeStamp}");
        }

        public void HandleOrder()
        {
            DateTime Time = DateTime.Now;

            Console.WriteLine($"::-------------::Order ready for service::---------------::");
            Console.WriteLine($"{_orders.Dequeue()}\n");
            Console.WriteLine($"The order took {TimeStamp - Time} to handle.");
        }
        // Method to display all orders in que.
        public void ShowOrders()
        {
            if(_orders.Count == 0)
            {
                Console.WriteLine("::--------------------------------------------------------::");
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
        //Method to display next order in que.
        public void ShowNextOrder()
        {
            if (_orders.Count == 0)
            {
                Console.WriteLine("::--------------------------------------------------------::");
                Console.WriteLine("There are no current orders.");
            }
            else
            {
                Console.WriteLine($"::--------------------::Next Order::----------------------::");
                Console.WriteLine($"{_orders.Peek()}\n");
            }
            
        }
        //Method to display how many items are in que.
        public void ShowOrderCount()
        {
            if (_orders.Count == 0)
            {
                Console.WriteLine("::--------------------------------------------------------::");
                Console.WriteLine("There are no current orders.");
            }
            else
            {
                Console.WriteLine("::--------------------------------------------------------::");
                if(_orders.Count <= 1)
                {
                Console.WriteLine($"Currently we have {_orders.Count} order.");
                }
                else
                {
                Console.WriteLine($"Currently we have {_orders.Count} orders.");
                }
            }
        }
    }
}
