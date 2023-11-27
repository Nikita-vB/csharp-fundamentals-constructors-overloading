

namespace Boolean.CSharp.Main.Misc
{
    public class AeroplanePassengerManifest
    {
        List<string> _passengers = new List<string>()        
        {
                    "Adele",
                    "Damon Albarn",
                    "Seal",
                    "Julie Andrews",
                    "Ari Up",                    
                    "Joan Armatrading",
                    "Frederic Austin",
                    "Syd Barrett",
                    "Shirley Bassey",
                    "Victoria Beckham",
                    "Richard Rodney Bennett",
                    "David Bowie",
                    "Susan Boyle",
                    "Billy Bragg",
                    "Kate Bush",
                    "Eric Clapton",
                    "Joe Cocker",
                    "Elvis Costello",
                    "Jamie Cullum",
                    "Maurice Gibb",
                    "Mick Jagger",
                    "Elton John",
                    "Cliff Richard",
                    "Sade",
                    "Stormzy",
                    "Sam Smith",
                    "Dusty Springfield",
                    "Rod Stewart",
                    "Sting",
                    "Michael Waterson",
                    "Elisabeth Welch",
                    "Florence Welch",
                    "Amy Winehouse",
                    "Steve Winwood",
                    "Rick Wright"
         };
        
        

        public List<string> Passengers => _passengers;

        public int NumberOfPassengers { get { return _passengers.Count; } }
    }
}

 