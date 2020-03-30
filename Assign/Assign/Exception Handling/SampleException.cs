using System;
using System.Collections.Generic;
using System.Text;

namespace Assign.Exception_Handling
{
    class SampleException
    {

        class MyCustomException : Exception
        {
            public MyCustomException(string name) : base(String.Format("{0}", name))
            {

            }
        }
        public void Exception()
        {
            string[] list = new string[5];
            list[0] = "Sunday";
            list[1] = "Monday";
            list[2] = "Tuesday";
            list[3] = "Wednesday";
            list[4] = "Thursday";

            for (int i = 0; i <= 5; i++)
            {
                if (i == 5) throw new MyCustomException("Out of range");
                Console.WriteLine(list[i].ToString());

                // Output System.IndexOutOfRangeException
            }
            Console.ReadLine();

        }
    }

}
