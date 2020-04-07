using System;
using System.Collections.Generic;
using System.Text;

namespace Assign.Expando
{
   public static class ExpandoCustomClass
    {
        public static void PrintEmployeeDetails(dynamic person)
        {
            Console.WriteLine("{0} has {1} its email is {2}.", person.Name, person.Email);
            Console.ReadLine();
        }
    }
}
