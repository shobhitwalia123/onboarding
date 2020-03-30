using Assign.Exception_Handling;
using Assign.MemoryManagment;
using Assign.Task_Linq;
using System;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //MemoryManamgentTask1();
            //ExceptionHandling();

            MyClassTask m = new MyClassTask();
            m.GetGroupByDepartmentId();

            Console.ReadKey();
        }

        #region Exception Handling
        private static void ExceptionHandling()
        {
            var exception = new SampleException();
            exception.Exception();
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
    }
}
