using System;
using System.Collections.Generic;
using System.Text;

namespace Assign.MemoryManagment
{
    class MyClass : IDisposable
    {
        public int myInteger = 88;
        public void Dispose()
        {
            Console.WriteLine("Disposing");
        }
    }
}
