using System;
using System.Collections.Generic;

namespace Library
{

    public class CalculateLongestPersoNameVisitor : Visitor
    {
        private string LongestName { get; set; } = "";
        public override void Visit(Node node)
        {
          Visit(node.Person);
          foreach (var n in node.Children) // n = current node in list
          {
            Prueba(n);
          }
        }
        
        private void Prueba(Node node)
        {
            Visit(node.Person);
            foreach (var n in node.Children)
            {
                Prueba(n);
            }
        }

        public override void Visit(INodeElement person)
        {
            if (LongestName.Length < person.GetNodeElementName().Length)
            {
                LongestName = person.GetNodeElementName();
                FinalResult = person.GetNodeElementId();

            }
            
        }
    }
}


    
