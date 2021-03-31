using CalculatorSpecFlowTests.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CalculatorSpecFlowTests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        public static Calculator calculator = new Calculator();

        //[Given("I open the calculator in (.*) view")]
        //public void OpenTheCalculator(string view)
        //{
        //    calculator.
        //    //calculator.changeView(view);
        //}

        [When(@"I enter the number (.*)")]
        public void GivenEnterNumber(int number)
        {
            calculator.EnterNumber(number);
        }
        
        [When(@"I click add button")]
        public void GivenClickAddButton()
        {
            calculator.ClickAddButton();
        }
        
        [When(@"I click equals button")]
        public void GivenClickEqualsButton()
        {
            calculator.ClickEqualsButton();
        }
        
        [When(@"I click memory add button")]
        public void GivenClickMemoryAddButton()
        {
            calculator.ClickMemoryAddButton();
        }
        
        [When(@"I click memory reccall button")]
        public void GivenClickMemoryReccallButton()
        {
            calculator.ClickMemoryRecallButton();
        }
        
        [Then(@"result should be (.*)")]
        public void ThenResultShouldBe(int number)
        {
            Assert.AreEqual(number.ToString(), calculator.GetResult(), "The result of addition is incorrect. ");
        }
    }
}
