using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using CTM.Classes;

namespace CTM.Classes
{
     public class EnergyYourSupplier : BasePage
    {
        private static readonly String Url = "";

        //Constructor
        public EnergyYourSupplier(IWebDriver driver) :base (driver, Url)
        {
        }

        #region *** XPaths ***
        public string XP_YOUR_SUPPLIER_TITLE { get; set; } = "html/body//*[@class='main-heading']";
        public string XP_YOUR_SUPPLIER_POSTCODE_FIELD { get; set; } = ".//*[@id='your-postcode']";
        public string XP_YOUR_SUPPLIER_POSTCODE_FIND { get; set; } = ".//*[@id='find-postcode']";
        public string XP_YOUR_SUPPLIER_CHANGE_POSTCODE { get; set; } = ".//*[@id='change-postcode']";
        public string XP_YOUR_SUPPLIER_HAVE_BILL_YES { get; set; } = ".//*[@id='have-bill-label']/span/span";
        public string XP_YOUR_SUPPLIER_HAVE_BILL_NO { get; set; } = ".//*[@id='no-bill-label']/span/span";
        public string XP_YOUR_SUPPLIER_COMPARE_GASELEC { get; set; } = ".//*[@id='compare-both-label']/span/span";
        public string XP_YOUR_SUPPLIER_COMPARE_ELEC { get; set; } = ".//*[@id='compare-electricity-label']/span/span";
        public string XP_YOUR_SUPPLIER_COMPARE_GAS { get; set; } = ".//*[@id='compare-gas-label']/span/span";
        public string XP_YOUR_SUPPLIER_SAME_SUPPLIER_YES { get; set; } = ".//*[@id='same-supplier-question']/div//*[@for='same-supplier-yes']/span";
        public string XP_YOUR_SUPPLIER_SAME_SUPPLIER_NO { get; set; } = ".//*[@id='same-supplier-question']/div//*[@for='same-supplier-no']/span";
        public string XP_YOUR_SUPPLIER_DUAL_SUPPLIER { get; set; } = ".//*[@id='dual-energy-suppliers-question']/div/div/label[@supplier-name='{0}']/span/span";
        public string XP_YOUR_SUPPLIER_ELEC_SUPPLIER { get; set; } = ".//*[@id='elec-energy-suppliers-question']//div/div/label[@supplier-name='{0}']/span";
        public string XP_YOUR_SUPPLIER_GAS_SUPPLIER { get; set; } = ".//*[@id='gas-energy-suppliers-question']//div/div/label[@supplier-name='{0}']/span";
        public string XP_NEXT_BUTTON { get; set; } = ".//*[@ng-click='ctrl.MoveToNextPage();']";
        #endregion

        #region *** Public Methods ***

        public string GetPageTitle(string page)
        {
           return WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_TITLE)).Text;
        }

        public bool CheckPostCodeFieldEmpty()
        {
            string postCode = WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_POSTCODE_FIELD)).Text;
            bool result = (string.IsNullOrEmpty(postCode)) ? true : false;
            return result;
        }

        public bool CheckNextButtonEnabled()
        {
            bool result = WebBrowser.Current.FindElement(By.XPath(XP_NEXT_BUTTON)).Enabled;
            return result;
        }

        public bool EnterYourSupplierData(string field, string value)
        {
            switch(field)
            {
                case "POSTCODE":
                    WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_POSTCODE_FIELD)).SendKeys(value);
                    if (WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_POSTCODE_FIND)).Enabled)
                    {
                        WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_POSTCODE_FIND)).Click();
                        return true;
                    }
                    else
                    {
                        throw new ArgumentException("Unable to find postcode");
                    }
                                                      
                case "BILL_HANDY":
                    if (value == "Yes")
                    {
                        WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_HAVE_BILL_YES)).Click();
                        WebDriverWait.Equals(true,WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_SAME_SUPPLIER_YES)).Displayed);
                    }
                    else if (value == "No")
                    {
                        WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_HAVE_BILL_NO)).Click();
                        WebDriverWait.Equals(true, WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_SAME_SUPPLIER_YES)).Displayed);
                    }
                    else
                    {
                        throw new System.ArgumentException("Invalid value passed to method: ", value);
                    }
                    return true;

                case "COMPARE_UTIL":
                    if(value == "Gas only")
                    {
                        WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_COMPARE_GAS)).Click();
                        var wait = new WebDriverWait(WebBrowser.Current, TimeSpan.FromSeconds(5));
                        Assert.AreEqual(true, wait.Until(ExpectedConditions.ElementExists(By.XPath(String.Format(XP_YOUR_SUPPLIER_ELEC_SUPPLIER, value)))));
                    }
                    else if(value == "Electricity only")
                    {
                        WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_COMPARE_ELEC)).Click();
                    }
                    else if(value == "Gas & Electricity")
                    {
                        WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_COMPARE_GASELEC)).Click();
                    }
                    else
                    {
                        throw new System.ArgumentException("Invalid value passed to method: ", value);
                    }
                    return true;

                case "SAME_SUPPLIER":
                    if (value == "Yes")
                    {
                        IWebElement elem = WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_SAME_SUPPLIER_YES));
                        String js = "arguments[0].style.height='auto'; arguments[0].style.visibility='visible';";
                        ((IJavaScriptExecutor)WebBrowser.Current).ExecuteScript(js, elem);
                        elem.Click();
                    }
                    else if (value == "No")
                    {
                        IWebElement elem = WebBrowser.Current.FindElement(By.XPath(XP_YOUR_SUPPLIER_SAME_SUPPLIER_NO));
                        String js = "arguments[0].style.height='auto'; arguments[0].style.visibility='visible';";
                        ((IJavaScriptExecutor)WebBrowser.Current).ExecuteScript(js, elem);
                        elem.Click();
                    }
                    else
                    {
                        throw new System.ArgumentException("Invalid value passed to method: ", value);
                    }
                    return true;

                case "SUPPLIER_ELEC":
                    try
                    {
                        ((IJavaScriptExecutor)WebBrowser.Current).ExecuteScript("scroll(0,600)");
                        WebBrowser.Current.FindElement(By.XPath(String.Format(XP_YOUR_SUPPLIER_ELEC_SUPPLIER, value))).Click();
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("Unable to find object with Xpath supplied");
                    }
                    return true;

                case "SUPPLIER_GAS":
                    try
                    {
                        ((IJavaScriptExecutor)WebBrowser.Current).ExecuteScript("scroll(0,600)");
                        WebBrowser.Current.FindElement(By.XPath(String.Format(XP_YOUR_SUPPLIER_GAS_SUPPLIER, value))).Click();
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("Unable to find object with Xpath supplied");
                    }
                    return true;

                case "DUAL_SUPPLIER":
                    if (value == "Ignore" || value == "")
                    {
                        return true;
                    }
                    else
                    {
                        try
                        {
                            ((IJavaScriptExecutor)WebBrowser.Current).ExecuteScript("scroll(0,600)");
                            WebBrowser.Current.FindElement(By.XPath(String.Format(XP_YOUR_SUPPLIER_DUAL_SUPPLIER, value))).Click();
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException("Unable to find object with Xpath supplied");
                        }
                    }
                    break;
            }
            throw new ArgumentException("Invalid argument passed to method");
            
        }
        
        public bool ClickNextButton()
        {
            try
            {
                CheckNextButtonEnabled();
                WebBrowser.Current.FindElement(By.XPath(XP_NEXT_BUTTON)).Click();
            }
            catch (Exception)
            {

                throw new ElementNotVisibleException("Next button is not enabled");
            }
            return true;
        }

        #endregion

        #region *** Private Methods ***

        #endregion
    }
}
