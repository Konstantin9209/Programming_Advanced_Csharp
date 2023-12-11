namespace ExerciseOopHierarchy;
    public class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public MenuItem(string name, string description, decimal price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Description} - ${this.Price}";
        }
    }