using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCollections
{
    
}
namespace Collections
{
    public class Employee
    {
        public int Eid { get; set; }
        public float Salary { get; set; }
        public string Ename { get; set; }

        public Employee(int i, float f, string s)
        {
            Eid = i;
            Salary = f;
            Ename = s;
        }

        public int add(int i)
        {
            return Eid + i;
        }
    }
}
