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

        public void AddItem(MenuItem dish)
        {
            _orderItems.Add(dish);
        }
        public override string ToString()
        {

           string items = string.Join("\n", _orderItems);
            return $"Order: {_orderId}\n" +
                $"Table: {_tableNumber}\n" +
                $"Guests: {_guestAmount}\n" +
                $"Ordered:\n{items}";
        }
    }
}
