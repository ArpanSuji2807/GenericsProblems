using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaximum
    {
        [Test]
        public void GivenFirstInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            int actual=max.FindMaxInteger(3,1,2);
            Assert.AreEqual(actual,3);
        }
        [Test]
        public void GivenSecondInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(1, 3,2);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenThirdInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(1, 2, 3);
            Assert.AreEqual(actual, 3);
        }
    }
}