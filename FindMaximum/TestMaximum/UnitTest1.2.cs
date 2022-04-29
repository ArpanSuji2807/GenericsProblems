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
        public void GivenSecondElement_WhenTestMax_ShouldReturnMaxElement()
        {
            FindMax<float> max = new FindMax<float>(20.5f,33.6f,15.6f);
            float actual = max.FindMaxElement();
            Assert.AreEqual(actual, 33.5f);
        }
    }
}
