using Microsoft.AspNetCore.Mvc;
using Project1TripLog.Models;

namespace Project1TripLog.Controllers
{
    public class AdditionalInfoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var session = new TripSession(HttpContext.Session);
            var trip = session.GetTrip();
            return View(trip);
        }

        [HttpPost]
        public IActionResult AddInfo(Trip trip)
        {
            if (ModelState.IsValid)
            {
                var session = new TripSession(HttpContext.Session);
                var sessionTrip = session.GetTrip();
                sessionTrip.AccomodationPhone = trip.AccomodationPhone;
                sessionTrip.AccomodationEmail = trip.AccomodationEmail;
                session.SetTrip(sessionTrip);
                return RedirectToAction("ToDo", "ToDo");
            }
            return View(trip);
        }
    }
}
