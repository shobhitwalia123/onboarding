using Assign.Exception_Handling;
using Assign.Expando;
using Assign.MemoryManagment;
using Assign.Task_Linq;
using Assign.TaskOnCollectionAndGeneric;
using Assign.TaskOnExpressionBodiedMembers;
using Assign.TaskOnTuple;
using System;
using System.Dynamic;
using System.Linq;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //MemoryManamgentTask1();
            //ExceptionHandling();
            //TaskonCollectionGeneric();
            //CustomTuple.Execute();
            //ExecuteExpressionBodied();
            // ExecuteExpando();
            Console.ReadKey();
        }

        #region Exception Handling
        private static void ExceptionHandling()
        {
            var exception = new SampleException();
            exception.Exception();
        }

        #endregion

        #region TaskLinq
        private static void TaskLinq()
        {
            var exception = new MyClassTask();
            exception.GetHighestSalaryUnderEachDepartment();
        }

        #endregion

        #region MemorManagmentTask Assignemnt
        private static void MemoryManamgentTask1()
        {
            using (var myclass = new MyClass())
            {
                Console.WriteLine("Value is " + myclass.myInteger.ToString());
            }


            var myclass1 = new MyClass();
            try
            {
                Console.WriteLine("Value is " + myclass1.myInteger.ToString());

            }
            finally
            {
                myclass1.Dispose();
            }
        }
        #endregion

        #region TaskOnCollectionAndGeneric
        public static void TaskonCollectionGeneric()
        {
            var students = Student.GetSampleData();

            Student.Print(students.Where(p => p.RegistrationNumber == 1025).Select(p => p).FirstOrDefault());
            Array.Sort(students, delegate (Student x, Student y) { return x.totalScore.CompareTo(y.totalScore); });
        }
        #endregion

        # region ExecuteExpressionBodied
        private static void ExecuteExpressionBodied()
        {
            ExpressionBodiedMemberForConstructor expforConstructor = new ExpressionBodiedMemberForConstructor();

            ExpressionBodiedMemberForFinalizer expforFinalizer = new ExpressionBodiedMemberForFinalizer();
        }
        #endregion

        #region Expando
        public static void ExecuteExpando()
        {
            dynamic employee = new ExpandoObject();
            employee.Name = "Shobhit";
            employee.Email = "shobhitwalia@gmail.com";

            ExpandoCustomClass.PrintEmployeeDetails(employee);
        }
        #endregion

    }
}
