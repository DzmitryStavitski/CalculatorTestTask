using Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorSpecFlowTests.Hooks
{
    [Binding]
    public sealed class BeforeAndAfterScenario
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Application.GetApplication().Run();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Application.GetApplication().Close();
        }
    }
}
