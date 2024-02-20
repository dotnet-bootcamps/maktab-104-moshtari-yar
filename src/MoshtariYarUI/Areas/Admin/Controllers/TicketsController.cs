using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Experimental.ProjectCache;

namespace MoshtariYarUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TicketsController : Controller
    {
        private readonly InMemoryDatabase _database = new InMemoryDatabase();
        public IActionResult List()
        {
            var model = _database.GetTickets();
            return View(model);
        }

        [HttpGet]
        public IActionResult TicketDetails(int id)
        {
            var targetTicket = _database.GetTicketById(id);
            return View(targetTicket);
        }

        [HttpGet]
        public IActionResult TicketResponses(int id)
        {
            var targetTicket = _database.GetTicketById(id);
            return View(targetTicket.ResponseList);
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
            var ticketModel = new TicketDTO(/*targetTikcet.Id, targetTikcet.Title, targetTikcet.Description, targetTikcet.SubmittedBy*/);
            ticketModel.Id = targetTikcet.Id;
            ticketModel.Title = targetTikcet.Title;
            ticketModel.Description = targetTikcet.Description;
            ticketModel.SubmittedBy = targetTikcet.SubmittedBy;

            return View(ticketModel);
        }


        [HttpPost]
        public IActionResult TicketResponse(TicketDTO ticketModel)
        {
            var CheckresponseIsAdded = _database.AddTicketResponse(ticketModel.Id, ticketModel.TicketResponse, ticketModel.SubmittedBy);

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
