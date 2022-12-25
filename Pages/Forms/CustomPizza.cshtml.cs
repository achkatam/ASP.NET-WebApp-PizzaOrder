using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzeria.Models;

namespace MyPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        private const float addedTopping = 1.75F;
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float Price { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Price = Pizza.BasePrice;

            if (Pizza.ExtraPizzaSauce)
                Price += addedTopping;
            if (Pizza.ExtraCheese)
                Price += addedTopping;
            if (Pizza.Onions)
                Price += addedTopping;
            if (Pizza.Tuna)
                Price += addedTopping;
            if (Pizza.Bacon)
                Price += addedTopping;
            if (Pizza.Ham)
                Price += addedTopping;
            if (Pizza.GreenPeppers)
                Price += addedTopping;
            if (Pizza.Beef)
                Price += addedTopping;
            if (Pizza.Pineapple)
                Price += addedTopping;
            if (Pizza.Mushrooms)
                Price += addedTopping;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, Price});
        }
    }
}
