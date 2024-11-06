namespace LABB4_Generics_SUT24
{
    internal class Restaurant
    {
        private List<MenuItem> = _menuItem new List<MenuItem>();
        private Queue<Order> = _orders new Queue<Order>();

        
        void AddtoMenu(MenuItem menuItem)
        {
            _menuItem.Add(menuItem);
            Console.WriteLine($"{menuItem} was added to the menu.");
        }

    }
}
