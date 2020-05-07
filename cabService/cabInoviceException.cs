using System;
using System.Collections.Generic;
using System.Text;

namespace cabService
{
    public class cabInoviceException : Exception
    {
        public enum ExceptionType {ENTER_PROPER_DISTANCE,ENTER_PROPER_TIME,
            ENTER_PROPER_INPUT
        }
        public ExceptionType type;
        public cabInoviceException(cabInoviceException.ExceptionType type,string massage):base(massage)
        {
            this.type = type;
        }
    }
}
