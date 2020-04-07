using System;
using System.Collections.Generic;
using System.Text;

namespace Assign.TaskOnExpressionBodiedMembers
{
  public  class ExpressionBodiedMemberForFinalizer
    {
        ~ExpressionBodiedMemberForFinalizer() => Console.WriteLine("Finalizer");
    }
}
