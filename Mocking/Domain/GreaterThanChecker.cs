namespace Mocking.Domain
{
    public class GreaterThanChecker
    {
        private readonly int _number;
        private readonly INumberProvider _numberProvider;

        public GreaterThanChecker(INumberProvider numberProvider, int number)
        {
            _numberProvider = numberProvider;
            _number = number;
        }

        public bool IsGreaterThan()
        {
            return _numberProvider.GetNumber() > _number;
        }
    }
}