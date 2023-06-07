using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : IAcceptVisits
    {
        private int number;
        public INodeElement Person { get; set; }

        private List<Node> Nodechildren = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.Nodechildren.AsReadOnly();
            }
        }

        public Node(int number, INodeElement person)
        {
            this.number = number;
            this.Person = person;
        }

        public void AddChildren(Node n)
        {
            this.Nodechildren.Add(n);
        }
        
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
