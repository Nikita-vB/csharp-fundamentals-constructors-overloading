using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Car
    {
        private string _model;
        private string _make;

        public Car()
        {
            _model = string.Empty;
            _make = string.Empty;
        }
        public Car(string Make, string Model)
        {
            _make = Make;
            _model = Model;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

    }
}
