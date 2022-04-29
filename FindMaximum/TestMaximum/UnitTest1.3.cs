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
        public void GivenThirdInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            float actual = max.FindMaxFloatNumber(16.2f, 17.3f, 20.5f);
            Assert.AreEqual(actual, 20.5f);
        }
    }
}
