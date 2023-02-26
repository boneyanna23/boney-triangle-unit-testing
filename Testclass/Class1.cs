using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnitDemonstration;
namespace Testclass

{
    public class Testclass
    {
        [TestFixture]
        public class Testcalss1
        { 
            [Test]
            public void  ValidTriangle_Input60and60and60_OutputValidTriangle()
            { 
                int firstAngle = 60;
                int secondAngle =60;
                int thirdAngle = 60;
                string expected = "The triangle is valid.";
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                Console.WriteLine(actual);
                Assert.AreEqual(expected,actual);
            }
        }
    }
}