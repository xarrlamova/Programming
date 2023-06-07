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
                if (value <= 0)
                    throw new ArgumentException("Продолжительность в минутах должна быть больше нуля");
                _flightTimeInMinutes = value;
            }
        }

    } 

    
}
