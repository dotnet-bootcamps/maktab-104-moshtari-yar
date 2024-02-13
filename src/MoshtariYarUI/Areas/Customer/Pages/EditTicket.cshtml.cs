using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    [Area("Customer")]
    public class EditTicketModel : PageModel
    {
        InMemoryDatabase _db;
        public EditTicketModel()
        {
            _db = new InMemoryDatabase();
        }


        [BindProperty]
        public Ticket Ticket { get; set; }


        public void OnGet(int id)
        {
            Ticket = _db.GetTicketById(id);
        }

        [HttpPost]
        public IActionResult OnPost(Ticket ticket)
        {
            _db.UpdateTicket(ticket);
            return RedirectToPage("Index");
        }
    }
}
