using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Employee
    {
        private string _name;
        private int _wage;

        public string Name { get { return _name; } }
        public int Wage { get { return _wage; } }

        public Employee(string name,int wage)
        {
            _name = name;
            _wage = wage;
        }
    }
}
