using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class UnitTest
    {
        [Test]
        public void GivenFirstInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            int actual=max.FindMaxInteger(3,1,2);
            Assert.AreEqual(actual,3);
        }
    }
}