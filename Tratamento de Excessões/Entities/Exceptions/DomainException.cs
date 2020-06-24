using System;
using System.Collections.Generic;
using System.Text;

namespace Tratamento_de_Excessões.Entities.Exceptions {
    internal class DomainException : ApplicationException{

        internal DomainException(string message) : base(message) {

        }
    }
}
