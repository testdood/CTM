using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;

namespace CTM.Classes
{
    public class EnergyCommon : BasePage
    {
        private static readonly String Url = "";

        public EnergyCommon(IWebDriver driver) : base (driver, Url)
        {
        }

        public string yourSupplierPage = "https://energy.comparethemarket.com/energy/v2/?AFFCLIE=TST";
        public string yourEnergyPage = "https://energy.comparethemarket.com/energy/v2/yourEnergy?AFFCLIE=TST";
        public string yourDetailsPage = "https://energy.comparethemarket.com/energy/v2/yourDetails?AFFCLIE=TST";
        public string yourResultsPage = "https://energy.comparethemarket.com/energy/v2/yourResults?AFFCLIE=TST";

        #region *** XPaths ***
        public string XP_NEXT_BUTTON { get; set; } = ".//*[@id='goto-your-supplier-details']";
        #endregion

        #region *** Public Methods ***

        public bool NavigateToPage( string page)
        {
            switch (page)
            {
                case "Your Supplier":
                    WebBrowser.Current.Navigate().GoToUrl(yourSupplierPage);
                    WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    WebBrowser.Current.FindElement(By.XPath(XP_NEXT_BUTTON)).Displayed.Equals(true);
                    return true;

                case "Your Energy":
                    WebBrowser.Current.Navigate().GoToUrl(yourEnergyPage);
                    WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    WebBrowser.Current.FindElement(By.XPath(XP_NEXT_BUTTON)).Displayed.Equals(true);
                    return true;

                case "Your Details":
                    WebBrowser.Current.Navigate().GoToUrl(yourDetailsPage);
                    WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    WebBrowser.Current.FindElement(By.XPath(XP_NEXT_BUTTON)).Displayed.Equals(true);
                    return true;

                case "Your Results":
                    WebBrowser.Current.Navigate().GoToUrl(yourResultsPage);
                    WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    WebBrowser.Current.FindElement(By.XPath(XP_NEXT_BUTTON)).Displayed.Equals(true);
                    return true;
            }

            return false;
        }

        #endregion

        #region *** Private Methods ***

        #endregion

    }
}
