using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person : INodeElement, IAcceptVisits
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public int GetValueToSum()
        {
            return this.Age;
        }

    }

   
}
