namespace MyPizzeria.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using MyPizzeria.Models;

    public class PizzaModel : PageModel
    {
        private const decimal addedTopping = 1.75M;

        public List<PizzasModel> FakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName = "Margharita",
            BasePrice = 14, PizzaSauce = true, Cheese = true
            , FinalPrice = 17.50M },
            new PizzasModel(){ImageTitle="Bolognese", PizzaName = "Bolognese  ",
            BasePrice = 14, PizzaSauce = true, Cheese = true, Beef= true
            ,FinalPrice = 19.25M },
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName = "Hawaiian",
            BasePrice = 14, PizzaSauce = true, Cheese = true, Ham = true, Pineapple = true
            ,FinalPrice = 21M },
            new PizzasModel(){ImageTitle="Carbonara", PizzaName = "Carbonara",
            BasePrice = 14, PizzaSauce = true, Cheese = true, Ham = true, Mushrooms = true
            ,FinalPrice = 21M },
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName = "Meatlover",
            BasePrice = 14, PizzaSauce = true, Cheese = true, Bacon= true, Ham = true, Beef = true
            ,FinalPrice = 22.75M },
            new PizzasModel(){ImageTitle="Mushroom", PizzaName = "Mushrooms",
            BasePrice = 14, PizzaSauce = true, Cheese = true , Mushrooms = true
            ,FinalPrice = 19.25M },
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName = "Pepperoni",
            BasePrice = 14, PizzaSauce = true, Cheese = true, Pepperoni = true
            ,FinalPrice = 19.25M },
            new PizzasModel(){ImageTitle="Seafood", PizzaName = "Seafood",
            BasePrice = 14, PizzaSauce = true, Cheese = true , Tuna = true
            ,FinalPrice = 19.25M },
            new PizzasModel(){ImageTitle="Vegetarian", PizzaName = "Vegetarian",
            BasePrice = 14, PizzaSauce = true, Cheese = true, Mushrooms = true, Pineapple = true
            ,FinalPrice = 21M }
        };
        public void OnGet()
        {
        }

    }
}
