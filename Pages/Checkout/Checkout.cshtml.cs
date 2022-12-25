using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzeria.Data;
using MyPizzeria.Models;

namespace MyPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public string PizzaName { get; set; }
        public float Price { get; set; }
        public string ImageTitle { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
                PizzaName = "Custom";

            if (string.IsNullOrWhiteSpace(ImageTitle))
                ImageTitle = "Create";

            PizzaOrder pizzaOrder = new PizzaOrder();

            pizzaOrder.CustomerName = PizzaName;
            pizzaOrder.BasePrice = Price;

            _context.Orders.Add(pizzaOrder);
            _context.SaveChanges();
        }

    }
}
