using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    [Area("Customer")]
    public class AddTicketModel : PageModel
    {
        public AddTicketModel()
        {
            
        }

        #region Model
        [BindProperty]
        public Ticket Ticket { get; set; }
        #endregion


        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //    return Page();

            var database = new EfRepository();
            database.AddTicket(Ticket);
            return RedirectToPage("Index");
        }
    }
}
