using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperShoes.Exceptions
{
    public class RecordNotFoundException : SuperShoesException
    {
        public RecordNotFoundException() : base() { }
        public RecordNotFoundException(string message):base(message) { }
        public RecordNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}