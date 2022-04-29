using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class UnitTest
    {
        [Test]
        public void GivenFirstStringElement_WhenTestMax_ShouldReturnMaxElement()
        {
            FindMax max = new FindMax();
            string actual = max.FindMaxStringElement("Banana","Peach","Apple");
            Assert.AreEqual(actual,"Banana");
        }
    }
}