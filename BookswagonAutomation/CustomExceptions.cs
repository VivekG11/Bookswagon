using System;
using System.Collections.Generic;
using System.Text;

namespace BookswagonAutomation
{
    public class CustomExceptions :Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            Null_Exception, Method_Not_Found_Exception, Class_Not_Found_Exception, NoSuchElementException, FileNotFoundException
        }

        public CustomExceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
