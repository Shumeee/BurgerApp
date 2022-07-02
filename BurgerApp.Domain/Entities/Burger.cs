namespace BurgerApp.Domain.Entities
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Burger(int id, string name, decimal price, bool isVegeterian, bool isVegan, bool hasFries, List<Ingredient> ingredients)
        {
            Id = id;
            Name = name;
            Price = price;
            IsVegetarian = isVegeterian;
            IsVegan = isVegan;
            HasFries = hasFries;
            Ingredients = ingredients;
        }
    }
}
