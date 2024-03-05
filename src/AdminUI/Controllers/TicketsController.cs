using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{
    public class TicketsController : Controller
    {
        private readonly MemoryRepository _database = new MemoryRepository();

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
            else if (isDeleted == false)
            {
                TempData["Error"] = "مشکلی پیش آمد!";
                return RedirectToAction("List");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
