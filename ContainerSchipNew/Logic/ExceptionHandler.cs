using System;

namespace ContainerSchipNew.Logic
{
    public class ExceptionHandler : Exception
    {
        public ExceptionHandler() { }

        /// <summary>
        /// Constructor for custom exception with message.
        /// </summary>
        /// <param name="message">Custom message</param>
        public ExceptionHandler(string message) : base(message)
        {

        }
    }
}