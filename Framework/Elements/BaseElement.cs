using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using System.Threading;

namespace Framework.Elements
{
    public class BaseElement
    {
        protected SearchCriteria criteria;
        protected static Application.Application application = Application.Application.GetApplication();
        protected static ILogger logger = LogManager.GetCurrentClassLogger();

        public BaseElement(SearchCriteria criteria)
        {
            this.criteria = criteria;
        }

        public virtual void Click()
        {
            logger.Debug($"Clicking on Elelement");
            application.getApplicationWindow().Get(criteria).Click();
        }

        public static void ClickOnMenu(params string[] path)
        {
            logger.Debug($"Returning menuItem (with path = {path})");

            var menu = application.getApplicationWindow().MenuBar.MenuItem(path);
            menu.Click();
        }

        public bool Exists()
        {
            return application.getApplicationWindow().Exists(criteria);
        }
    }
}
