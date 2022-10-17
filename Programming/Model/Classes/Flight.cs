namespace Programming.Model
{
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTimeInMinutes;

        public Flight(string departurePoint, string destination, int flightTimeMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = flightTimeMinutes;
        }

        public Flight(){}
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(nameof(FlightTimeInMinutes), value);
                _flightTimeInMinutes = value;
            }
        }
    }
}
