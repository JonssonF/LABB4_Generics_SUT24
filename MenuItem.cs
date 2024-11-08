namespace LABB4_Generics_SUT24
{
    internal class MenuItem
    {
        // I denna klass använder vi auto-implemented properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public MenuItem(int id, string name, decimal price, string type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
