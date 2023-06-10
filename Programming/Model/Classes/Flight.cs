using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTimeInMinutes;

        public string DeparturePoint { get; set; }

        public string Destination { get; set; }

        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }
        
        public Flight()
        {

        }

        public Flight(int flightTimeInMinutes, string departurePoint, string destination)
        {
            FlightTimeInMinutes = flightTimeInMinutes;
            DeparturePoint = departurePoint;
            Destination = destination;
        }
    } 
    
}
