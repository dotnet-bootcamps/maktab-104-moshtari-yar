using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerUI.Pages
{
    public class TicketDetailsModel : PageModel
    {
        MemoryRepository dataBase = new MemoryRepository();

        #region Model
        [BindProperty]
        public Ticket CurrentTicket { get; set; }
        #endregion


        public IActionResult OnGet(int id)
        {
            var tickets = dataBase.GetTickets();
            var CurrentTicket = tickets.FirstOrDefault(t => t.Id == id);

            if (CurrentTicket == null)
                return NotFound();

            return Page();
        }
    }
}
