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
        public void GivenSecondInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(1, 3, 2);
            Assert.AreEqual(actual, 3);
        }
    }
}
