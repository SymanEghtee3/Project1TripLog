using Microsoft.AspNetCore.Http;

namespace Project1TripLog.Models
{
    public class TripSession
    {
        private const string TripKey = "trip";
        private ISession session { get; set; }

        public TripSession(ISession session)
        {
            this.session = session;
        }

        public void SetTrip(Trip trip)
        {
            session.SetObject(TripKey, trip);
        }

        public Trip GetTrip()
        {
            return session.GetObject<Trip>(TripKey) ?? new Trip();
        }
    }
}
