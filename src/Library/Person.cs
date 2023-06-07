using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person : INodeElement, IAcceptVisits
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }

        public Person(int age, string name, int personId)
        {
            this.Age = age;
            this.Name = name;
            this.PersonId = personId;
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public int GetValue()
        {
            return this.Age;
        }
        public int GetNodeElementId()
        {
            return this.PersonId;
        }

        public string GetNodeElementName()
        {
            return this.Name;
        }

    }

   
}
