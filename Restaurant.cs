namespace LABB4_Generics_SUT24
{
    internal class Restaurant
    {
        //List of all items on the menu.
        public List<MenuItem> _menuItem = new List<MenuItem>();

        //Queue to handle orders with FIFO method.
        public Queue<Order> _orders = new Queue<Order>();

        //DateTime to register when the order is placed, to calculate how long it took to get it done.
        public DateTime TimeStamp { get; set; } // To see how long the orders take from order to being ready.

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
            Console.WriteLine($"Order: {order.OrderId} was sent to the kitchen!");
            Console.WriteLine($"The order was placed at {TimeStamp}");
        }
        //Method to "handle" or take away first order in queue.
        public void HandleOrder()
        {
            DateTime Time = DateTime.Now;
            Console.WriteLine($"::-------------::Order is ready for service::---------------::");
            Console.WriteLine($"{_orders.Dequeue()}\n");
            Console.WriteLine($"The order took {Time - TimeStamp} to handle.");
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
                    Console.WriteLine($"::---------------------::Order: {order.OrderId}::-----------------------::");
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
