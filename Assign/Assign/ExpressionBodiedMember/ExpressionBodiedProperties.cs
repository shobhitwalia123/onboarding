using System;
using System.Collections.Generic;
using System.Text;

namespace Assign.TaskOnExpressionBodiedMembers
{
   
  public  class ExpressionBodiedProperties
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value ?? "";
        }
    }
}
