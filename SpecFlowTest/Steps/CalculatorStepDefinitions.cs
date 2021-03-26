using CalculatorTestTask.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowTest.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        Calculator calculater;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculater = new Calculator();
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
