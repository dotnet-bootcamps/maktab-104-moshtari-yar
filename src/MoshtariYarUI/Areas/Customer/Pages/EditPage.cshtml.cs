using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    public class EditPageModel : PageModel
    {
        [BindProperty]
        public Ticket currentTicket { get; set; }
        public void OnGet(int id)
        {
            var DataBase = new InMemoryDatabase();
            var targetTicket = DataBase.GetTicketById(id);
            currentTicket = targetTicket;
        }


        [HttpPatch]
        public IActionResult OnPost()
        {
            var DataBase = new InMemoryDatabase();
            var targetTicket = DataBase.GetTicketById(currentTicket.Id);
            targetTicket.Title = currentTicket.Title;
            targetTicket.Description = currentTicket.Description;
            targetTicket.Priority = currentTicket.Priority;
            targetTicket.DepartmentName = currentTicket.DepartmentName;
            targetTicket.SubmittedBy = currentTicket.SubmittedBy;
            targetTicket.SubmittedAt = currentTicket.SubmittedAt;

            return RedirectToPage("Index");
        }
    }
}