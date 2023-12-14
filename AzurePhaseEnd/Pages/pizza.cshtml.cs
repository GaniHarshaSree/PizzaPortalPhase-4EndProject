using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AzurePhaseEnd.Pages
{
    public class pizzaModel : PageModel
    {
        [BindProperty]
        public string SelectedPizza { get; set; }

        [BindProperty]
        public int Quantity { get; set; }

        public List<SelectListItem> PizzaTypes { get; } = new List<SelectListItem>
    {
        new SelectListItem("Margherita", "Margherita"),
        new SelectListItem("Pepperoni", "Pepperoni"),
        new SelectListItem("Vegetarian", "Vegetarian"),
        // Add more pizza types as needed
    };

        public IActionResult OnPostAddToCart()
        {
            // Implement the logic to add the selected pizza to the shopping cart
            // You can store the selected pizza and quantity in a session variable or a database

            // Redirect to the Order Checkout page
            return RedirectToPage("OrderCheckout", new { pizza = SelectedPizza, quantity = Quantity });

        }
    }
}
