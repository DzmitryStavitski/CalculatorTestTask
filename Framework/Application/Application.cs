using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;

namespace Framework.Application
{
    class Application
    {
        private TestStack.White.Application application;
        private string applicationPath;

        public Application(string applicationPath)
        {
            this.applicationPath = applicationPath;
        }

        public bool Run()
        {
            application = TestStack.White.Application.Launch(applicationPath);
            return application == null;
        }
    }
}
