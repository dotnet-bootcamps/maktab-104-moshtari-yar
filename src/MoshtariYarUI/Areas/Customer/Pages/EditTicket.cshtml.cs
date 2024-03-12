using Contracts;
using Data;
using Databases;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    [Area("Customer")]
    public class EditTicketModel : PageModel
    {
        private readonly IRepository _repository;
        public EditTicketModel(IRepository repository)
        {
            _repository = repository;
        }


        [BindProperty]
        public Ticket Ticket { get; set; }


        public void OnGet(int id)
        {
            Ticket = _repository.GetTicketById(id);
        }

        [HttpPost]
        public IActionResult OnPost(Ticket ticket)
        {
            _repository.UpdateTicket(ticket);
            return RedirectToPage("Index");
        }
    }
}
