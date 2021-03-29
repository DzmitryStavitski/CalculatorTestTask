using CalculatorSpecFlowTests.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CalculatorSpecFlowTests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private CalculatorObject calculator;

        [Given("open the calculator in (.*) view")]
        public void OpenTheCalculator(string view)
        {
            calculator = new CalculatorObject();
            calculator.changeView(view);
        }

        [Given(@"enter the number (.*)")]
        public void GivenEnterNumber(int p0)
        {
            calculator.EnterNumber(p0);
        }
        
        [Given(@"click add button")]
        public void GivenClickAddButton()
        {
            calculator.ClickAddButton();
        }
        
        [Given(@"click equals button")]
        public void GivenClickEqualsButton()
        {
            calculator.ClickEqualsButton();
        }
        
        [Given(@"click memory add button")]
        public void GivenClickMemoryAddButton()
        {
            calculator.ClickMemoryAddButton();
        }
        
        [Given(@"click memory reccall button")]
        public void GivenClickMemoryReccallButton()
        {
            calculator.ClickMemoryRecallButton();
        }
        
        [Then(@"result should be (.*)")]
        public void ThenResultShouldBe(int p0)
        {
            Assert.AreEqual(p0.ToString(), calculator.getResult());
        }

        [Then(@"close the calculator")]
        public void ThenCloseTheCalculator()
        {
            calculator.Close();
        }
    }
}
