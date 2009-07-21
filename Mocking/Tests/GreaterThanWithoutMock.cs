using Mocking.Domain;
using Mocking.Mocks;
using NUnit.Framework;

namespace Mocking.Tests
{
    [TestFixture]
    public class GreaterThanWithoutMock
    {
        [Test]
        public void IsGreaterThan()
        {
            MockNumberProvider numberProvider = new MockNumberProvider(50);
            GreaterThanChecker checker = new GreaterThanChecker(numberProvider, 10);

            bool result = checker.IsGreaterThan();
            
            Assert.IsTrue(numberProvider.GetNumberCalled);
            Assert.IsTrue(result);            
        }

        [Test]
        public void IsNotGreaterThan()
        {
            MockNumberProvider numberProvider = new MockNumberProvider(50);
            GreaterThanChecker checker = new GreaterThanChecker(numberProvider, 70);

            bool result = checker.IsGreaterThan();

            Assert.IsTrue(numberProvider.GetNumberCalled);
            Assert.IsFalse(result);
        }
    }
}