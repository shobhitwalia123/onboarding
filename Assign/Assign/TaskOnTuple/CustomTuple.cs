using System;
using System.Collections.Generic;
using System.Text;

namespace Assign.TaskOnTuple
{
  public static class  CustomTuple
    {

        public static void Execute()
        {
            //Deconstruction of Value tuple
            var (FirstName, MiddleName, LastName) = GetUserDetails();

            //Printing of values
            Console.WriteLine("My Details:");

            Console.WriteLine("Name:{0}", FirstName);

            Console.WriteLine("Id:{0}", MiddleName);

            Console.WriteLine("LastName:{0}", LastName);

            Console.ReadLine();
        }
        public static (string, string, string) GetUserDetails()
        {
            return ("Shobhit", "Walia", "UK");
        }
    }

   
}
