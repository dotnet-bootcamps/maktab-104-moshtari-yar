using Contracts;
using Data;
using Databases;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoshtariYarUI.Areas.Customer.Pages
{
    [Area("Customer")]
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository _repository;

        public IndexModel(ILogger<IndexModel> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        #region Model
        public List<Ticket> Tickets { get; set; }
        #endregion


        public void OnGet()
        {
            Tickets = _repository.GetTickets();
        }
        
    }
}
