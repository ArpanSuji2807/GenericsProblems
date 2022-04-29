using FindMaximum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class Test3
    {
        [Test]
        public void GivenThirdStringElement_WhenTestMax_ShouldReturnMaxElement()
        {
            FindMax max = new FindMax();
            string actual = max.FindMaxStringElement("Peach","Apple","Banana");
            Assert.AreEqual(actual, "Banana");
        }
    }
}
