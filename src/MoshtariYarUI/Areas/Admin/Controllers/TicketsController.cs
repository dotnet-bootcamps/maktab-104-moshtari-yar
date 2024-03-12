using Contracts;
using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MoshtariYarUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TicketsController : Controller
    {
        //private readonly EfRepository _database = new EfRepository();
        private readonly IRepository _database;

        public TicketsController(IRepository database)
        {
            _database = database;
        }


        public IActionResult List()
        {
            var model = _database.GetTickets();
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteTicket(int id)
        {
            var isDeleted = _database.DeleteTicket(id);

            if (isDeleted)
            {
                TempData["Success"] = "تیکت با موفقیت حذف شد";
                return RedirectToAction("List");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult TicketResponse(int id)
        {
            var targetTikcet = _database.GetTicketById(id);
            return View(targetTikcet);
        }


        [HttpPost]
        public IActionResult TicketResponse(Ticket ticket)
        {
            var CheckresponseIsAdded = _database.AddTicketResponse(ticket.Id, ticket.TicketResponse);

            if (CheckresponseIsAdded)
            {
                TempData["AddResponse"] = "پاسخ ذخیره شد";
                return RedirectToAction("TicketResponse");
            }
            else
                return NotFound();
        }
    }
}
