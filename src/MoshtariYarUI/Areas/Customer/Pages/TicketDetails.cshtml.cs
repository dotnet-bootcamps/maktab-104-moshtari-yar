using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    [Area("Customer")]
    public class TicketDetailsModel : PageModel
    {
        EfRepository dataBase = new EfRepository();

        #region Model
        [BindProperty]
        public Ticket CurrentTicket { get; set; }
        #endregion


        public IActionResult OnGet(int id)
        {
            var tickets = dataBase.GetTickets();
            CurrentTicket = tickets.FirstOrDefault(t => t.Id == id);

            if (CurrentTicket == null)
                return NotFound();

            return Page();
        }
    }
}
