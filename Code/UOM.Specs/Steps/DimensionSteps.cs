using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UOM.Specs.Model;
using UOM.Specs.Tasks;

namespace UOM.Specs.Steps
{
    [Binding]
    public sealed class DimensionSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("I have defined a new dimension as following")]
        public void GivenIHaveANewDimensionAsFollowing(Table table)
        {
            var model = table.CreateInstance<DimensionTestModel>();
            ScenarioContext.Current.Add("Dimension",model);
        }

        [When("I register the dimension")]
        public void WhenIRegisterTheDimension()
        {
            var model = ScenarioContext.Current.Get<DimensionTestModel>("Dimension");
            var task = new MeasurementDimensionTasks();
            task.DefineDimension(model);
        }

        [Then(@"the dimension should be appear in the list of dimensions")]
        public void ThenTheDimensionShouldBeAppearInTheListOfDimensions()
        {
            var expectedDimension = ScenarioContext.Current.Get<DimensionTestModel>("Dimension");
            var task = new MeasurementDimensionTasks();
            var actualDimension = task.GetDimension(expectedDimension.Symbol);
            actualDimension.Should().BeEquivalentTo(expectedDimension);
        }
    }
}
