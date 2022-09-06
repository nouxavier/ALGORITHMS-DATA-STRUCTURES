using System;
namespace Algorithms.Exceptions
{
    public class DomainException: Exception
    {
        public DomainException()
        {
        }
        public DomainException(string msg): base (msg)
        {
        }
    }
}

