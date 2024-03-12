using Contracts;
using Data;
using Databases;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    [Area("Customer")]
    public class TicketDetailsModel : PageModel
    {
        private readonly IRepository _repository;

        public TicketDetailsModel(IRepository repository)
        {
            _repository = repository;
        }


        #region Model
        [BindProperty]
        public Ticket CurrentTicket { get; set; }
        #endregion


        public IActionResult OnGet(int id)
        {
            var tickets = _repository.GetTickets();
            CurrentTicket = tickets.FirstOrDefault(t => t.Id == id);

            if (CurrentTicket == null)
                return NotFound();

            return Page();
        }
    }
}
