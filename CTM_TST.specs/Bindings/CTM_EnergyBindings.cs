using System;
using System.Threading;
using TechTalk.SpecFlow;
using System.Diagnostics;
using NUnit.Framework;
using CTM.Classes;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CTM_TST.specs.Bindings
{
    [Binding]
    public class CTM_EnergyBindings
    {

        public EnergyYourSupplier eys = new EnergyYourSupplier(WebBrowser.Current);
        public EnergyCommon ecomm = new EnergyCommon(WebBrowser.Current);
        public EnergyYourEnergy eye = new EnergyYourEnergy(WebBrowser.Current);

        [Given(@"the user is on the '(.*)' page")]
        public void GivenTheUserIsOnThePage(string pageName)
        {
            Assert.IsTrue(true, Convert.ToString(ecomm.NavigateToPage(pageName)));
            Assert.AreEqual(pageName, eys.GetPageTitle(pageName));
        }
        
        [Given(@"the postcode field is empty")]
        public void GivenThePostcodeFieldIsEmpty()
        {
            Assert.IsTrue(true, Convert.ToString(eys.CheckPostCodeFieldEmpty()));
        }
        
        [Given(@"the Next button is disabled")]
        public void GivenTheNextButtonIsDisabled()
        {
            Assert.AreEqual(false, eys.CheckNextButtonEnabled());
        }
        
        [When(@"the user has set the Your Supplier details to the following:")]
        public void WhenTheUserHasSetTheYourSupplierDetailsToTheFollowing(Table fields)
        {
            foreach (var row in fields.Rows)
            {
                Assert.AreEqual(true, eys.EnterYourSupplierData(row["Field"], row["Value"]));
                Console.WriteLine(string.Format("The {0} value has been set to {1} on the Your Supplier details page", row["Field"], row["Value"]));
                Thread.Sleep(3000);
            }
            Console.WriteLine(string.Format("All values have been set for the Your Supplier page"));
        }

        [When(@"the user sets the electricity details to the following:")]
        public void WhenTheUserSetsTheElectricityDetailsToTheFollowing(Table fields)
        {
            foreach (var row in fields.Rows)
            {
                Assert.AreEqual(true, eye.EnterElectricityDetails(row["Field"], row["Value"]));
                Console.WriteLine(string.Format("The {0} value has been set to {1} in the Electricity section on the Your Energy details page", row["Field"], row["Value"]));
                Thread.Sleep(3000);

            }
        }

        [When(@"the user sets the gas details to the following:")]
        public void WhenTheUserSetsTheGasDetailsToTheFollowing(Table fields)
        {
            foreach (var row in fields.Rows)
            {
                Assert.AreEqual(true, eye.EnterGasDetails(row["Field"], row["Value"]));
                Console.WriteLine(string.Format("The {0} value has been set to {1} in the Gas section on the Your Supplier details page", row["Field"], row["Value"]));
                Thread.Sleep(3000);
            }
        }

        [When(@"the user clicks on '(.*)'")]
        public void WhenTheUserClicksOn(string p0)
        {
            Assert.That(true, Convert.ToString(eys.ClickNextButton()));
        }
        
        [When(@"the user clicks on the Next button")]
        public void WhenTheUserClicksOnTheButton()
        {
            Assert.That(true, Convert.ToString(eys.ClickNextButton()));
        }
        
        [Then(@"the user is able to progress to the '(.*)' section of the Your Energy step")]
        public void ThenTheUserIsAbleToProgressToTheSectionOfTheYourEnergyStep(string section)
        {
            Assert.AreEqual(section, eye.GetEnergySectionTitle());
        }
        
        [Then(@"the user is able to progress to the '(.*)' step")]
        public void ThenTheUserIsAbleToProgressToTheStep(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the '(.*)' page is displayed")]
        public void ThenThePageIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the '(.*)'  panel matches the details given by the user:")]
        public void ThenThePanelMatchesTheDetailsGivenByTheUser(string p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the '(.*)' page contains prices")]
        public void ThenThePageContainsPrices(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the filter values match the values set in the Your Preferences step:")]
        public void ThenTheFilterValuesMatchTheValuesSetInTheYourPreferencesStep(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
