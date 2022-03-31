using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    abstract class Person
    {
        public Person(string name, string surname, byte age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
       public string Name { get; set; }
       public string Surname { get; set; }
       public byte Age { get; set; }
    }
}
