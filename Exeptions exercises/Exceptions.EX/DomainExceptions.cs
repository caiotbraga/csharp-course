using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Ex.Entities.Exceptions
{
    internal class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
