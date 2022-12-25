using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzeria.Data;
using MyPizzeria.Models;

namespace MyPizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>(); 
        public void OnGet()
        {
            PizzaOrders = _context.Orders.ToList();
        }
    }
}
