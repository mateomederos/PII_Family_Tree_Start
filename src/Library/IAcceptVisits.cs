using System;
using System.Collections.Generic;

namespace Library
{
    public interface IAcceptVisits
    {
        void Accept(Visitor visitor); 
    }
}