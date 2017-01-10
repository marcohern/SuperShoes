using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperShoes.Exceptions
{
    public class NanException : SuperShoesException 
    {
        public NanException() : base() {}
        public NanException(string message) : base(message) { }
        public NanException(string message, Exception inner) : base(message, inner) { }
    }
}