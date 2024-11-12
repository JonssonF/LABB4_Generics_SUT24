namespace LABB4_Generics_SUT24 //Fredrik Jonsson SUT_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a restaurant.
            Restaurant LaMafioso = new Restaurant();
            /*::--------------------------------------------------------::*/
            // Making a italian style menu.
            MenuItem Garlic = new MenuItem(1, "Garlic Bread", 75m, "Starter");
            MenuItem Caprese = new MenuItem(2, "Caprese Salad", 125m, "Starter");
            MenuItem Bolognese = new MenuItem(3, "Ragu alla Bolognese", 125m, "Main");
            MenuItem Alfredo = new MenuItem(4, "Pasta Alfredo", 145m,"Main");
            MenuItem Carbonara = new MenuItem(5, "Pasta alla Carbonara", 135m,"Main");
            MenuItem Vongele = new MenuItem(6, "Pasta Vongele", 175m,"Main");
            MenuItem Tiramisu = new MenuItem(7, "Tiramisu", 125m,"Dessert");
            MenuItem Pannacotta = new MenuItem(8, "Pannacotta", 95m,"Dessert");
            Console.WriteLine("::--------------------------------------------------------::");
            // Adding courses to the restaurant 'LaMafioso'
            LaMafioso.AddtoMenu(Garlic);
            LaMafioso.AddtoMenu(Caprese);
            LaMafioso.AddtoMenu(Bolognese);
            LaMafioso.AddtoMenu(Alfredo);
            LaMafioso.AddtoMenu(Carbonara);
            LaMafioso.AddtoMenu(Vongele);
            LaMafioso.AddtoMenu(Tiramisu);
            LaMafioso.AddtoMenu(Pannacotta);
            LaMafioso.ShowMenu(); // Displays the menu at the restaurant.
            /*::--------------------------------------------------------::*/
            // Making some orders.
            Order order1 = new Order(new List<MenuItem>(), 6, 2);
            order1.AddItem(Garlic);
            order1.AddItem(Caprese);
            order1.AddItem(Alfredo);
            order1.AddItem(Vongele);
            order1.AddItem(Pannacotta);
            order1.AddItem(Tiramisu);
            LaMafioso.CreateOrder(order1);
            /*::--------------------------------------------------------::*/
            Order order2 = new Order(new List<MenuItem>(), 8, 4);
            order2.AddItem(Garlic);
            order2.AddItem(Garlic);
            order2.AddItem(Garlic);
            order2.AddItem(Caprese);
            order2.AddItem(Alfredo);
            order2.AddItem(Alfredo);
            order2.AddItem(Carbonara);
            order2.AddItem(Vongele);
            LaMafioso.CreateOrder(order2);
            ///*::--------------------------------------------------------::*/
            Order order3 = new Order(new List<MenuItem>(), 2, 6);
            order3.AddItem(Bolognese);
            order3.AddItem(Bolognese);
            order3.AddItem(Alfredo);
            order3.AddItem(Carbonara);
            order3.AddItem(Vongele);
            order3.AddItem(Vongele);
            LaMafioso.CreateOrder(order3);
            /*::--------------------------------------------------------::*/
            LaMafioso.ShowOrders();
            LaMafioso.ShowOrderCount();
            LaMafioso.ShowNextOrder();
            LaMafioso.HandleOrder();
            LaMafioso.ShowOrderCount();
            ///*::--------------------------------------------------------::*/
            Order order4 = new Order(new List<MenuItem>(), 5, 1);
            order4.AddItem(Vongele);
            order4.AddItem(Tiramisu);
            LaMafioso.CreateOrder(order4);
            ///*::--------------------------------------------------------::*/
            LaMafioso.ShowOrderCount();
            LaMafioso.HandleOrder();
            LaMafioso.HandleOrder();
            LaMafioso.ShowOrderCount();
            LaMafioso.ShowNextOrder();
            LaMafioso.HandleOrder();
            LaMafioso.ShowOrderCount();

            
            Console.ReadLine();
        }
    }
}
