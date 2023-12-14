using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzurePhaseEnd.Pages
{
    public class OrderConfirmationModel : PageModel
    {
        public int OrderId { get; set; }

        public double Amount { get; set; }

        public string SelectedPizza { get; set; }

        public void OnGet(int orderId, double amount, string pizza)
        {
            OrderId = orderId;
            Amount = amount;
            SelectedPizza = pizza;
        }

    }
}
