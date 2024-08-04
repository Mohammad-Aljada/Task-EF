using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EF.Model
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Salary { get; set; }
        public int Age { get; set; }
    }
}
