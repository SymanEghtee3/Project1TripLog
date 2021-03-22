using Microsoft.AspNetCore.Mvc;
using Project1TripLog.Models;

namespace Project1TripLog.Controllers
{
    public class ToDoController : Controller
    {
        private TripContext Context { get; set; }

        public ToDoController(TripContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult ToDo()
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
                sessionTrip.ThingToDo1 = trip.ThingToDo1;
                sessionTrip.ThingToDo2 = trip.ThingToDo2;
                sessionTrip.ThingToDo3 = trip.ThingToDo3;
                Context.Trips.Add(sessionTrip);
                Context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(trip);
        }
    }
}
