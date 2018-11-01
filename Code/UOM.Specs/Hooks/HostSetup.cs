using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UOM.Specs.Hosting;

namespace UOM.Specs.Hooks
{
    [Binding]
    public sealed class HostSetup
    {
        private static IISExpressHost _host;

        [BeforeTestRun]
        public static void BeforeTestSuiteRun()
        {
            var serviceHostPath = @"C:\Courses\DDD-Tiger\Session13\WarCraft-Tiger\Code\ServiceHost";
            _host = new IISExpressHost(serviceHostPath, 29210);
            _host.Start();
        }

        [BeforeScenario]
        public static void AfterTestSuiteRun()
        {
            _host.Stop();
        }
    }
}
