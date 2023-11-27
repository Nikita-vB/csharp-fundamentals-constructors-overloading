using Boolean.CSharp.Main.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Extension
    {
        private Core _core;
        public Extension()
        {
            Core core = new Core();
        }

        public Aeroplane Question1()
        {
            Aeroplane plane = new Aeroplane();
            //plane.FlightDetails("LHR", "JFK");

            //TODO: 1.  Add a method on the Aeroplane class that returns the number of passengers on the flight.
            ////TIP: Examine the FlightDetails and find the one that has the AeroplanePassingerManifest as a parameter.  Pass that into the method
            /// and return the count?
            /// 
            
            //AeroplanePassengerManifest currentListOfPassingers = new AeroplanePassengerManifest();

            //write calling code here and method inside the Aeroplane class.

            //plane.FlightDetails(currentListOfPassingers);

            return plane;
        }
        public Aeroplane Question2()
        {
            Aeroplane plane = new Aeroplane();
            plane.FlightDetails("LHR", "JFK");

            //TODO 2.  Overload FlightDetails (add new method) that adds another passenger to the flight.  
            //TIP - you cant write a method that takes a single string as the cancelled flight one already does this, so use a 
            //      different number of params            

            //write calling code here and method inside the Aeroplane class.

            return plane;

        }
    }
}
