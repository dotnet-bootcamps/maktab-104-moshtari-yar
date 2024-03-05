using Data;
using Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerUI.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

        #region Model
        public List<Ticket> Tickets { get; set; }
        #endregion


        public void OnGet()
        {
            var database = new MemoryRepository();
            Tickets = database.GetTickets();
        }
        
    }
}
