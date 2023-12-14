using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzurePhaseEnd.Pages
{
    public class OrderCheckoutModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SelectedPizza { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Quantity { get; set; }

        public double TotalPrice => CalculateTotalPrice();

        public IActionResult OnPostPlaceOrder()
        {
            // Implement the logic to place the order
            // You can generate an order ID, store the order details in a database, etc.

            // Redirect to the Order Confirmation page
            return RedirectToPage("OrderConfirmation", new { orderId = 123, amount = TotalPrice, pizza = SelectedPizza });
        }

        private double CalculateTotalPrice()
        {
            // Implement the logic to calculate the total price based on the selected pizza and quantity
            // This could involve querying a database for pizza prices or using a predefined price list

            // For simplicity, let's assume a fixed price per pizza
            double pizzaPrice = 10.0;
            return Quantity * pizzaPrice;
        }
    }

}

