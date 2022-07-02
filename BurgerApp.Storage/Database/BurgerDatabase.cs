using BurgerApp.Domain.Entities;

namespace BurgerApp.Storage.Database
{
    public static class BurgerDatabase
    {
        public static List<Burger> BURGERS = new List<Burger>()
        {
            new Burger(1, "OLIVER TWIST", 240, false, false, false, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Meat Patty"),
                    new Ingredient(3, "Olive & Cream Cheese"),
                    new Ingredient(4, "Ranch Sauce"),
                    new Ingredient(5, "Tomato")
                }),
            new Burger(2, "FISH FILLET SANDWICH", 220, true, true, false, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Grilled Fish"),
                    new Ingredient(3, "Cheddar"),
                    new Ingredient(4, "Garlic"),
                    new Ingredient(5, "Iceberg Sauce")
                }),
            new Burger(3, "THE COWBOY", 210, false, false, true, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Meat Patty"),
                    new Ingredient(3, "Mac'n'Cheese"),
                    new Ingredient(4, "Bacon"),
                    new Ingredient(5, "BBQ Sauce")

                }),
            new Burger(4, "THE ZUCCHINI", 180, true, true, false, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Grilled Veggies"),
                    new Ingredient(3, "Mozzarella"),
                    new Ingredient(4, "Tartar Sauce"),
                    new Ingredient(5, "Ranch Sauce")
                }),
            new Burger(5, "THE PIONEER", 240, false, false, true, new List<Ingredient>()
                {
                    new Ingredient(1, "Bread"),
                    new Ingredient(2, "Meat Patty"),
                    new Ingredient(3, "Bacon"),
                    new Ingredient(4, "Cheddar"),
                    new Ingredient(5, "Caramelized Onion")
                }),
        };

        public static List<Order> ORDERS = new List<Order>()
        {
            new Order(1, "David Shumanski", "Bul. ASNOM br. 21-15", true, new List<Burger>()
            {
                BURGERS[0],
                BURGERS[1],
            },"Bul. ASNOM br. 21-15"),
            new Order(2, "Marko Markovski", "Bul. Partizanski Odredi br. 13", true, new List<Burger>()
            {
                BURGERS[1]
            },"Bul. ASNOM br. 21-15"),
            new Order(3, "Darko Darkovski", "Bul. Kuzman Josifovski Pitu br. 6", false, new List<Burger>()
            {
                BURGERS[0],
                BURGERS[1],
            },"Bul. ASNOM br. 21-15"),
        };
    }
}
