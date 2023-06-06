using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
