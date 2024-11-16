using System.Collections.Generic;

namespace LABB4_Generics_SUT24
{
    internal class Order
    {
        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;
        private int _guestAmount; // Added amount of guests.

        public Order(List<MenuItem> orderItems, int tableNumber, int guests)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
            _guestAmount = guests;
        }
       public int OrderId
        {
            get { return _orderId; }
            private set { _orderId = value; }
        }
        //public int OrderId => _orderId;

        //Method to add items to the list 'MenuItem'.
        public void AddItem(MenuItem dish)
        {
            _orderItems.Add(dish);
        }
        public override string ToString()
        {
            //Loop to get the sum of ordered items.
            decimal total = 0m;
            foreach (var item in _orderItems)
            {
                total += item.Price;
            }

            // Joining the items togheter as a vertical list.
           string items = string.Join("\n", _orderItems);

            //Calculation to get total amount + tip.
            decimal tip = 1.15m;
            decimal totaltip = total * tip;

            return 
                $"Table: {_tableNumber}\n" +
                $"Guests: {_guestAmount}\n" +
                $"Ordered:\n{items}\n" +
                $"Amount to pay: {total:c}\n" +
                $"With tip: {totaltip:c}";
        }
    }
}

