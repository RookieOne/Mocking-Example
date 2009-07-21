using System;

namespace Mocking.Domain
{
    public class NumberProvider : INumberProvider
    {
        public int GetNumber()
        {
            return new Random().Next(0, 100);
        }
    }
}