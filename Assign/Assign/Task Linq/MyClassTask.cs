using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign.Task_Linq
{
    public class MyClassTask
    {
        private IList<Employee> employess;
        private IList<Department> departments;

        public MyClassTask()
        {
            employess = new List<Employee>();
            departments = new List<Department>();

            InitEmployee(employess);
            InitDepartments(departments);
           
        }

        public IEnumerable<IGrouping<int, Employee>> GetGroupByDepartmentId()
        {
            var result =  from e in this.employess
                          group e by e.DepartmentId;
            return result;
        }

        public IEnumerable<IGrouping<int, Employee>> GetHighestSalaryUnderEachDepartment()
        {
            var result = from e in this.employess
                         group e by e.DepartmentId ;
            return result;
        }

        private void InitDepartments(IList<Department> departments)
        {
            departments.Add(new Department { DepartmentId = 1, Name = "IT Department" });
        }

        private void InitEmployee(IList<Employee> employess)
        {
            employess.Add(new Employee { Name = "shobhit", Age = 20, DepartmentId = 1, Gender = "Male", Salary = 1200000 });
            employess.Add(new Employee { Name = "Ram", Age = 9, DepartmentId = 1, Gender = "Male", Salary = 200000 });
            employess.Add(new Employee { Name = "Varun", Age = 24, DepartmentId = 1, Gender = "Male", Salary = 100000 });
            employess.Add(new Employee { Name = "Vivek", Age = 22, DepartmentId = 1, Gender = "Male", Salary = 10000 });
        }
    }
}
