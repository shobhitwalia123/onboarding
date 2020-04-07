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
        // 1 Point 
        public IEnumerable<IGrouping<int, Employee>> GetGroupByDepartmentId()
        {
            var result =  from e in this.employess
                          group e by e.DepartmentId;
            return result;
        }
        // 2 Point
        public void GetHighestSalaryUnderEachDepartment()
        {
            var deptCodes = new HashSet<int>(departments.Select(a => a.DepartmentId));
            var result = employess.Where(b => deptCodes.Contains(b.DepartmentId));

            var higestSalaryUnderEachDept = from emp in result
                                            group emp by emp.DepartmentId into g
                                            select new { Department = g.Key, highestSalary = g.OrderByDescending(m => m.Salary).FirstOrDefault() };
        }

        // 3 Point
        public void HikeSalaryBasedonRule()
        {
            var deptCodes = new HashSet<int>(departments.Select(a => a.DepartmentId));
            var result = employess.Where(b => deptCodes.Contains(b.DepartmentId));

            foreach (var item in result)
            {
                int isIncremented = item.Gender == "Male" ? item.Salary += 1000 : item.Salary += 1500;
            }
        }

        // 4 Point
        public void GetManaagerDetail_UsingSelfJoin()
        {
            var deptCodes = new HashSet<int>(departments.Select(a => a.DepartmentId));
            var result = employess.Where(b => deptCodes.Contains(b.DepartmentId));
            //Get the details of the Manager (Manager ID and Name) whose reportees > 2 using self join (Point 4)
            var q = (from employee in result
                     join employee2 in result on employee.EmployeeID equals employee2.ManagerId
                     select new { ManagerID = employee.EmployeeID, Name = employee.Name }).FirstOrDefault();
        }

        public void GetSalaryDetailUnderSpecificManager()
        {
            var deptCodes = new HashSet<int>(departments.Select(a => a.DepartmentId));
            var result = employess.Where(b => deptCodes.Contains(b.DepartmentId));

         
            List<Employee> cloneresult = result.Select(p => (Employee)p.Clone()).ToList();

          
            foreach (var salariedEmployee in cloneresult.Where(p => p.ManagerId == 201))
            {
                salariedEmployee.Salary = Convert.ToInt32(salariedEmployee.Salary + (0.1 * salariedEmployee.Salary));
            }
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
