using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    public class Index1Model : PageModel
    {
        InMemoryDatabase dataBase = new InMemoryDatabase();
        public List<TicketResponse> CurrentTicketResponses { get; set; }
        public void OnGet(int id)
        {
            CurrentTicketResponses = dataBase.GetTicketById(id).ResponseList;
        }
    }
}
