using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitDemonstration;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace TestTringle
{
    //Gautam Shrivastav Test
    public class TestTriangle
    {
        [TestFixture]

        //
        public class TestTriangle1
        {
            [Test]

            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(expected, actual);
            }
        }


    }
}