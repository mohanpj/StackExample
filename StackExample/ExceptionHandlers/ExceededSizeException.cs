using System;
namespace StackExample.ExceptionHandlers
{
    public class ExceededSizeException : Exception
    {
        public ExceededSizeException(string message) : base(message)
        {
        }
    }
}
