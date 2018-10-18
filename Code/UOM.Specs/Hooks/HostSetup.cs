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
        private static IISExpressHost host;
        [BeforeTestRun]
        public static void BeforeTestSuiteRun()
        {
            var serviceHostPath = @"C:\Courses\DDD-Tiger\Session13\WarCraft-Tiger\Code\ServiceHost";
            host = new IISExpressHost(serviceHostPath, 29210);
            host.Start();
        }

        [AfterTestRun]
        public static void AfterTestSuiteRun()
        {
            host.Stop();
        }
    }
}
