using Mocking.Domain;

namespace Mocking.Mocks
{
    public class MockNumberProvider : INumberProvider
    {
        private readonly int _numberToReturn;
        public bool GetNumberCalled;

        public MockNumberProvider(int numberToReturn)
        {
            _numberToReturn = numberToReturn;
            GetNumberCalled = false;
        }

        public int GetNumber()
        {
            GetNumberCalled = true;
            return _numberToReturn;
        }
    }
}