using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperShoes.Exceptions
{
    public class SuperShoesException : ApplicationException
    {
        public SuperShoesException() :base() {}
        public SuperShoesException(string message) : base(message) { }
        public SuperShoesException(string message, Exception inner) : base(message, inner) { }
    }
}