using System;
using Rebus.Exceptions;

namespace Elsa.Exceptions
{
    public class WorkflowException : Exception, IFailFastException
    {
        public WorkflowException(string message) : base(message)
        {
        }
        
        public WorkflowException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}