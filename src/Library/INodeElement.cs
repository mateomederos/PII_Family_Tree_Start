using System;
using System.Collections.Generic;

namespace Library
{
    public interface INodeElement
    {
        int GetValueToSum();

        void Accept(Visitor visitor);
    }
}