using CalculatorSpecFlowTests.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CalculatorSpecFlowTests.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        CalculatorObject calculater = null;

        [Given("open the calculator")]
        public void OpenTheCalculator()
        {
            calculater = new CalculatorObject();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculater.EnterNumber(number);
            calculater.ClickAddButton();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculater.EnterNumber(number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            calculater.ClickEqualsButton();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result.ToString(), calculater.getResult());
            calculater.Close();
        }
    }
}
