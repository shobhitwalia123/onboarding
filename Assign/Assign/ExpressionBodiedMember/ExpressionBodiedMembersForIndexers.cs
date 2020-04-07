using System;
using System.Collections.Generic;
using System.Text;

namespace Assign.TaskOnExpressionBodiedMembers
{
   public class ExpressionBodiedMembersForIndexers
    {
        public int Num1 = 101;
        public int Num2 = 33;

        public string[] Names = new string[5];
        public string this[int i]
        {
            get => Names[i];
            set => Names[i] = value;

        }
    }
}
