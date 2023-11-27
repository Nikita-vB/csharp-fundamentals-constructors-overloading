using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boolean.CSharp.Main.Misc;

namespace Boolean.CSharp.Main
{
    public class Core
    {
        public Car Question1()
        {
           
            /*
                Examine the code in the Car class.  There are 2 constructor methods, identified because they
                have the same name as the class which in this case is Car..

                
                
                public Car()
                {
                    _model = string.Empty;
                    _make = string.Empty;       
                }
                public Car(string Make)
                {
                    _make = Make;
                    _model = string.Empty;
                }
            */
            
            Car car = new Car("Volkswagen", "Beetle");
            /*  When the car in instantiated, the constructor is passed a string
             in this case Volkswagen which is a Make of car is passed in.
             Within the constructor the 'string Make' variable has scope within the constructor and assiged to the _make member now visible to the whole class
             You can pass multiple variables in by placing a comma after the first, then the next variable
            e.g. In the Constructor signature:     public Car(string Make, string Model) 
            e.g. Instantiating:                    Car car = new Car("Volkswagen", "Beetle");
            */
            
            //TODO: 1.  Change car instantiation code above,  pass in the make AND model. 

            //TIP if you click on the Car class name above, right click and then select 'Go to Definition' it'll take you straight to the code




            return car;

        }

        public bool Question2()
        {
            // Examine the Motorbike class
            // Note there are two contructors.  T
            /*             
                public Motorbike()
                {
                    _cc = 373;
                    _make = string.Empty;
                    _model = string.Empty;
                }
                public Motorbike(string Make, string Model)
                {            
                    _make = Make;
                    _model = Model;         
            
                }
            
            See how the top constructor sets the _cc = 373, yet when we run the code to instantiate
            on line 78 we are using a different constructor.
            This means our Motorcycles cc does not get set.
            Having to 2 constructors is an example of Overloading.  

             */
            //TODO 2. Ensure both constructors on the Motorbike class set the cc of the Motorcycle to 373.
            Motorbike myMotorbike = new Motorbike("KTM", "Duke");

            if(myMotorbike.CC > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Bicycle Question3()
        {
            //Examine the Bicycle class
            //See there is somewhere to store the number of wheels the bike has 
            //but no constructor to set this
            //TODO: 3. Add a constructor to the Bicycle class that populates the _wheelCount variable
            Bicycle bike = new Bicycle();

            return bike;

        }
        public Unicycle Question4()
        {
            //Examine the Unicycle class
            //A unicycle is a bike with one wheel
            //Note the wheelcount has been assigned on the class's property in this case.            
            //Also note we are instantiating the class below even though there is no constructor on the class?!
            
            //TODO: 3. Add a constructor to the Unicycle class to accept/store the rider name and instantiate with your name below
            
            //TIP  see we already have an internal member for the unicyclist name:  _nameOfUnicyclist so you can use this to store the name internally
            //      it is good practice to name internal class variable with an _ at the beginning
            Unicycle unicycle = new Unicycle("Nikita");
                      
            

            return unicycle;

        }

        public Aeroplane Question5()
        {

            /*
             
            Method overloading is possible too.
            Examine the Aeroplane class.  
            Consider the following..
            How many FlightDetails methods are there? = 4
            What are the return types of each of the FlightDetails methods? = bool, void, string, int
            What are the parameters and types? 
            Parameters: departureAirport, arrivalAirport, cancelledMessage, AeroplanePassengerManifest
            Types: string, string, string, list

            Overloading is simply multiple methods that have the same name but do different things

             */
            Aeroplane plane = new Aeroplane();            
            plane.FlightDetails("LHR", "JFK");

            //TODO:  5.  Call the FlightDetails method that sets the cancelled message and  cancel the flight

            //TIP  as soon as you type plane.FlightDetails(   Visual Studios intellisense will present you with a dialog where you can see how many overloads there are

            //write code here and inside the Aeroplane class
            plane.FlightDetails("The flight is cancelled");

            return plane;
        }

    }
}
