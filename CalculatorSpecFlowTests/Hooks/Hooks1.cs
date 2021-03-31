using CalculatorSpecFlowTests.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorSpecFlowTests.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            CalculatorObject.application.Run();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CalculatorObject.application.Close();
        }
    }
}
