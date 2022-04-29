using FindMaximum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class UnitTest2
    {
        [Test]
        public void GivenSecondStringElement_WhenTestMax_ShouldReturnMaxElement()
        {
            FindMax max = new FindMax();
            string actual = max.FindMaxStringElement("Apple","Banana","Peach");
            Assert.AreEqual(actual, "Banana");
        }
    }
}
