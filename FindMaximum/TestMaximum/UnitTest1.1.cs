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
            float actual = max.FindMaxFloatNumber(20.5f,16.2f,17.3f);
            Assert.AreEqual(actual,20.5f);
        }
    }
}