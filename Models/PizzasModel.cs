namespace MyPizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 14;
        public bool PizzaSauce { get; set; }
        public bool ExtraPizzaSauce { get; set; }
        public bool Cheese { get; set; }
        public bool ExtraCheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Ham { get; set; }
        public bool Bacon { get; set; }
        public bool Pineapple { get; set; }
        public bool Beef { get; set; }
        public bool Mushrooms { get; set; }
        public bool Tuna { get; set; }
        public bool GreenPeppers { get; set; }
        public bool Onions { get; set; }

        public decimal FinalPrice { get; set; }  
    }
}
