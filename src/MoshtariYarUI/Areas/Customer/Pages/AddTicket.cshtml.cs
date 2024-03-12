using Contracts;
using Data;
using Databases;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    [Area("Customer")]
    public class AddTicketModel : PageModel
    {
        private readonly IRepository _repository;

        public AddTicketModel(IRepository repository)
        {
            _repository = repository;
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

            _repository.AddTicket(Ticket);
            return RedirectToPage("Index");
        }
    }
}
