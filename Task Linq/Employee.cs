using System;
using System.Collections.Generic;
using System.Text;

namespace Assign.Task_Linq
{
   public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        public int? ManagerId { get; set; }
    }
}
