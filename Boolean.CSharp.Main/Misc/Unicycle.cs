using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Unicycle
    {
        private string _nameOfUnicyclist;
        private int _wheelCount;
        public Unicycle(string NameOfUnicyclist)
        {
            _nameOfUnicyclist = NameOfUnicyclist;
            _wheelCount = WheelCount;
        }
        
        public string NameOfUnicyclist { get => _nameOfUnicyclist; set => _nameOfUnicyclist = value; }
        public int WheelCount { get; set; } = 1;
    }
}
