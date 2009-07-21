using Mocking.Domain;
using NUnit.Framework;
using Rhino.Mocks;

namespace Mocking.Tests
{
    [TestFixture]
    public class GreaterThanWithMock
    {
        [SetUp]
        public void SetUp()
        {
            _mock = new MockRepository();
        }

        private MockRepository _mock;

        [Test]
        public void IsGreaterThan()
        {
            INumberProvider numberProvider = _mock.DynamicMock<INumberProvider>();
            GreaterThanChecker checker = new GreaterThanChecker(numberProvider, 10);

            Expect.Call(numberProvider.GetNumber()).Return(50);

            _mock.ReplayAll();

            bool result = checker.IsGreaterThan();

            _mock.VerifyAll();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsNotGreaterThan()
        {
            INumberProvider numberProvider = _mock.DynamicMock<INumberProvider>();
            GreaterThanChecker checker = new GreaterThanChecker(numberProvider, 70);

            Expect.Call(numberProvider.GetNumber()).Return(50);

            _mock.ReplayAll();

            bool result = checker.IsGreaterThan();

            _mock.VerifyAll();

            Assert.IsFalse(result);
        }
    }
}