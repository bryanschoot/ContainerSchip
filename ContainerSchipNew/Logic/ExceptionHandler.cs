using System;

namespace ContainerSchipNew.Logic
{
    public class ExceptionHandler : Exception
    {
        public ExceptionHandler() { }

        public ExceptionHandler(string message) : base(message)
        {

        }
    }
}