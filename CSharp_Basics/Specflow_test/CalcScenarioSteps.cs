using System;
using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Specflow_test
{
    [Binding]
    public class CalcScenarioSteps
    {
        private Calc calc;
        private int result;

        public CalcScenarioSteps()
        {
            calc = new Calc();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {

            calc.PutNumber(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calc.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0,result);
        }

        [Given(@"I have login with credentials")]
        public void GivenIHaveLoginWithCredentials(Table table)
        {
            //you can transform table to dictionray
//            var dictionary = new Dictionary<string, string>();
//            foreach (var row in table.Rows)
//            {
//                dictionary.Add(row[0], row[1]);
//            }

            var credentials = table.CreateInstance <Credentials>();

            calc.Login(credentials.Login, credentials.Pass);
        }

    }

    public class Credentials
    {
        public string Login { get; set; }
        public string Pass { get; set; }
    }
}
