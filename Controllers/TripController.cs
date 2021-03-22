using Microsoft.AspNetCore.Mvc;
using Project1TripLog.Models;

namespace Project1TripLog.Controllers
{
    public class TripController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Trip());
        }

        [HttpPost]
        public IActionResult Add(Trip trip)
        {
            if (ModelState.IsValid)
            {
                var session = new TripSession(HttpContext.Session);
                session.SetTrip(trip);
                return RedirectToAction("Index", "AdditionalInfo");
            }
            return View(trip);
        }
    }
}
