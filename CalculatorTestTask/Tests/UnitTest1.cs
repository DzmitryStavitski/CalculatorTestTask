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
        [DataTestMethod]
        [DataRow(12, 999)]
        public void AddTwoNumbers(int firstNumber, int secondNumber)
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.IsOpen());

            calculator.EnterNumber(firstNumber);
            calculator.ClickAddButton();
            calculator.EnterNumber(secondNumber);
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
