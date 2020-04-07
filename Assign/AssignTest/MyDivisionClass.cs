using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssignTest
{
    public class MyDivisionClass
    {
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }

    public class MyService
    {
        public string ReturnAorB(int? input)
        {
            if (input == null) throw new System.ArgumentNullException("Null Exception");
            if (input > 51) return "A";
            if (input < 1) throw new System.ArgumentException("Invalid");
            else
                return "B";
        }
    }

    public class MyClass
    {
        MyService _service;
        public MyClass(MyService service)
        {
            _service = service;
        }

        public string WhatItReturns(int? input)
        {
            return _service.ReturnAorB(input);
        }
    }
        [TestClass]
    public class MathCustomClassTest
    {
        [TestMethod]
        public void ValidInput_Sucess()
        {
            MyDivisionClass customClass = new MyDivisionClass();
            var result = customClass.Divide(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void InvalidInput_DivideByZeroExcpetion()
        {
            MyDivisionClass customClass = new MyDivisionClass();
            var result = customClass.Divide(4, 0);
        }

        [TestMethod]
        public void ValidInput_DivideByNegativeValue()
        {
            MyDivisionClass customClass = new MyDivisionClass();
            var result = customClass.Divide(4, -2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void ValidInput_ReturnAorB()
        {
            MyService myService = new MyService();
            var result = myService.ReturnAorB(52);
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullInput_ReturnAorB()
        {
            MyService myService = new MyService();
            var result = myService.ReturnAorB(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InputLessThan1_ReturnAorB()
        {
            MyService myService = new MyService();
            var result = myService.ReturnAorB(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidInput_ReturnAorB_ReturnB()
        {
            MyService myService = new MyService();
            var result = myService.ReturnAorB(-2);
            Assert.AreEqual("B", result);
        }

        [TestMethod]
        public void ValidInput_WhatItReturns()
        {
            MyClass myService = new MyClass(new MyService());
            var result = myService.WhatItReturns(5);
            Assert.AreEqual("B", result);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullServiceInput_WhatItReturns()
        {
            MyClass myService = new MyClass(null);
            var result = myService.WhatItReturns(5);
            
        }

    }
}
