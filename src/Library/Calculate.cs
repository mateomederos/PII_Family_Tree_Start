using System;
using System.Collections.Generic;

namespace Library
{
    // class strategy OCP extension
    public class CalculateOldestFamilyMember : IComputable
    {
        private Node Node { get; set; }

        public CalculateOldestFamilyMember(Node node)
        {
            Node = node;
        }

        public int Calculate()
        {
            Visitor visitor = new CalculateOldestFamilyMemberVisitor();
            this.Node.Accept(visitor);
            return visitor.FinalResult;
        }
    }
    
    public class CalculatePersonAge : IComputable
    {
        private Node Node { get; set; }

        public CalculatePersonAge(Node node)
        {
            Node = node;
        }

        public int Calculate()
        {
            Visitor visitor = new CalculatePersonAgeVisitor();
            this.Node.Accept(visitor);
            return visitor.FinalResult;
        }
    }

    // Main calculator
    public class Calculator 
    {
        private IComputable CalculationStrategy { get; set; }
        public Calculator(IComputable calculationStrategy)
        {
            this.CalculationStrategy = calculationStrategy;
        }
        public int Calculate()
        {
            int result = this.CalculationStrategy.Calculate();
            return result;
        }
    }
}

        
        
        
        
        // public INodeElement INodeElement { get; set; }
    
        // public Calculate(INodeElement iNodeElement) 
        // {
        //     this.INodeElement = iNodeElement;
   
        // }
        // public int CalculateSum()
        // {
        //    int result = computable.CalculateSum(INodeElement);
        //    return result;
        // }
