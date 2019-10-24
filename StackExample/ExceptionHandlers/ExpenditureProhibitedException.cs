using System;
namespace StackExample.ExceptionHandlers
{
    public class ExpenditureProhibitedException : Exception
    {
        public ExpenditureProhibitedException(string message) : base(message)
        {
        }
    }
}
