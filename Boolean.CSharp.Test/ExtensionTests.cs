using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Misc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private Extension _extension;
        public ExtensionTests()
        {
            _extension = new Extension();
        }
        [Test]
        public void TestQuestion1()
        {
            Aeroplane plane = _extension.Question1();
            Assert.IsTrue(plane.FlightDetails(new AeroplanePassengerManifest()) >1 );
        }
        [Test]
        public void TestQuestion2()
        {
            Aeroplane plane = _extension.Question2();
            Assert.IsTrue(plane.FlightDetails(new AeroplanePassengerManifest(), "Nikita") > 1);
        }
    }
}
