using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            INodeElement person1 = new Person(25, "Juan");
            INodeElement person2 = new Person(30, "María");
            INodeElement person3 = new Person(40, "Pedro");
            INodeElement person4 = new Person(18, "Ana");
            INodeElement person5 = new Person(35, "Luis");
            INodeElement person6 = new Person(27, "Laura");
            INodeElement person7 = new Person(50, "Carlos");
            INodeElement person8 = new Person(22, "Sofía");


            Node n1 = new Node(1, person1);
            Node n2 = new Node(2, person2);
            Node n3 = new Node(3, person3);
            Node n4 = new Node(4, person4);
            Node n5 = new Node(5, person5);
            Node n6 = new Node(6, person6);
            Node n7 = new Node(7, person7);
            Node n8 = new Node(8, person8);

            

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n4.AddChildren(n8);

            IComputable calculatePersonAge = new CalculatePersonAge(n1);
            Calculator calculator1 = new Calculator(calculatePersonAge);
            int PersonFamilyAge = calculator1.Calculate();
            Console.WriteLine($"Ages sum of Person's family: {PersonFamilyAge}");

            IComputable calculateOldestFamilyMember = new CalculateOldestFamilyMember(n1);
            Calculator calculator2 = new Calculator(calculateOldestFamilyMember);
            int OldestFamilyMember = calculator2.Calculate();
            Console.WriteLine($"Oldest family member: {OldestFamilyMember}");
            
        }
    }
}
