using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о рейсах.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Длительность полета в минутах.
        /// </summary>
        private int _flightTimeInMinutes;
        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string DeparturePoint { get; set; }
        /// <summary>
        /// Возвращает и задает точку отправления. 
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        /// Возвращает и задает длительность полета в минутах. Должна быть положительной.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }
        /// <summary>
        /// Создает объект класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {

        }
        /// <summary>
        /// Создает объект класса <see cref="Flight"/>. 
        /// </summary>
        /// <param name="flightTimeInMinutes">Длительность полета в минутах. Должна быть положительной.</param>
        /// <param name="departurePoint">Пункт назначения.</param>
        /// <param name="destination">Точка отправления. </param>
        public Flight(int flightTimeInMinutes, string departurePoint, string destination)
        {
            FlightTimeInMinutes = flightTimeInMinutes;
            DeparturePoint = departurePoint;
            Destination = destination;
        }
    } 
    
}
