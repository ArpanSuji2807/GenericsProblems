using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class UnitTest
    {
        [Test]
        public void GivenFirst_WhenTestMax_ShouldReturnMaxElement()
        {
            FindMax<int> max = new FindMax<int>(1,2,3);
            int actual = max.FindMaxElement();
            Assert.AreEqual(actual,3);
        }
    }
}