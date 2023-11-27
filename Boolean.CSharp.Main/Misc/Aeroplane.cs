using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Aeroplane
    {
        private string _departureAirport;
        private string _arrivalAirport;
        private string _journeyDetails;
        private bool _flightCancelled;
        private int _passengerCount;
        
        public Aeroplane()
        {
            
        }
        public bool FlightDetails(string departureAirport, string arrivalAirport) 
        {
            _departureAirport = departureAirport;
            _arrivalAirport = arrivalAirport;
            _journeyDetails = $"##{_departureAirport}##{_arrivalAirport}##";
            _flightCancelled = false;
            return _flightCancelled;        
        }  
       
        public void FlightDetails(string cancelledMessage)
        {
            _journeyDetails = cancelledMessage;
            _flightCancelled = true;
        }
            
        public string FlightDetails()
        {
            return _journeyDetails;
        }

        
        
        //public int FlightDetails(List<string> Passengers)
        public int FlightDetails(AeroplanePassengerManifest plane)
        {
            return plane.NumberOfPassengers;
        }
        public int FlightDetails(AeroplanePassengerManifest plane, string Newpassenger)
        {
            plane.Passengers.Add(Newpassenger);
            return plane.NumberOfPassengers;
        }

        //public int Passengers = 
        public bool IsFlightCancelled => _flightCancelled;
    
    
    }
}
