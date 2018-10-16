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
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private static IISExpressHost host;
        [BeforeTestRun]
        public void BeforeTestSuiteRun()
        {
            var serviceHostPath = @"C:\Users\Mostafa\source\repos\WarCraft-Tiger2\Code\ServiceHost";
            host = new IISExpressHost(serviceHostPath, 29210);
            host.Start();
        }

        [AfterTestRun]
        public void AfterTestSuiteRun()
        {
            host.Stop();
        }
    }
}
