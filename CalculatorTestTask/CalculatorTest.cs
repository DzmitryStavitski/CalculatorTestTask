using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private static Application application;

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            application = Application.Launch(@"C:\Windows\System32\calc1.exe");
            Assert.IsNotNull(application);
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            GetButton("2").Click();
            GetButton("Сложение").Click();
            GetButton("3").Click();
        }

        [ClassCleanup]
        public static void TestFixtureTearDown()
        {
            application.Close();
            Assert.IsNull(application);
        }

        public static Button GetButton(string elementText)
        {
            for (var i = 0; i < 100; i++)
            {
                var button = GetWindow().Get<Button>(SearchCriteria.ByText(elementText));
                if (button != null) return button;
            }

            return null;
        }

        public static Window GetWindow()
        {
            return application.GetWindow("Калькулятор");
        }
    }
}
