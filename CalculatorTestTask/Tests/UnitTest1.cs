using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;
using Framework.Application;
using CalculatorTestTask.PageObjects;

namespace CalculatorTestTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.IsOpen());

            calculator.EnterNumber(12);
            calculator.ClickAddButton();
            calculator.EnterNumber(999);
            calculator.ClickEqualsButton();
            calculator.ClickMemoryAddButton();
            calculator.EnterNumber(19);
            calculator.ClickAddButton();
            calculator.ClickMemoryRecallButton();
            calculator.ClickEqualsButton();

            Assert.AreEqual("1030", calculator.getResult());
            calculator.Close();
        }
    }
}
