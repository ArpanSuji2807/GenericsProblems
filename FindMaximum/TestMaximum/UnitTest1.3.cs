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
        public void GivenThirdElement_WhenTestMax_ShouldReturnMaxElement()
        {
            FindMax<string> max = new FindMax<string>("Peach", "Apple", "Banana");
            string actual = max.FindMaxElement();
            Assert.AreEqual(actual, "Banana");
        }
    }
}
