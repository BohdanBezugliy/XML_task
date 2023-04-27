using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання__1
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Programmer { get; private set; }
        public Employee(string Name, int Age, bool Programmer) 
        {
            this.Name = Name;
            this.Age = Age;
            this.Programmer = Programmer;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
