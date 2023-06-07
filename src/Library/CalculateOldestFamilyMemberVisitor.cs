using System;
using System.Collections.Generic;

namespace Library
{
    public class CalculateOldestFamilyMemberVisitor : Visitor
    {
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
            if (FinalResult < person.GetValueToSum())
            {
                FinalResult = person.GetValueToSum();
            }
            
        }
    }
}


    