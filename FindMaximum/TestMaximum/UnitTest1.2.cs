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
            float actual = max.FindMaxFloatNumber(16.2f,20.5f,17.3f);
            Assert.AreEqual(actual, 20.5f);
        }
    }
}
