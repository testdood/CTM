using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;

namespace CTM.Classes
{
    public class EnergyYourEnergy : BasePage
    {
        private static readonly String Url = "";

        public EnergyYourEnergy(IWebDriver driver) :base (driver, Url)
        {
        }

        #region *** XPaths ***
        public string XP_YOUR_ENERGY_ENERGY_TYPE_TITLE { get; set; } = "html/body//main/section/h2";
        public string XP_CURRENT_ELEC_TARIFF_DROPDOWN { get; set; } = ".//*[@id='electricity_tariff_additional_info_chosen']/a/div/b";
        public string XP_CURRENT_ELEC_TARIFF { get; set; } = "//*[text() = '{0}']";
        public string XP_ECONOMY_7 { get; set; } = ".//*[@id='economy-7-question']/div/div/label/input[@id='economy-7-{0}']";
        public string XP_PAYMENT_TYPE_ELEC_DROPDOWN { get; set; } = ".//*[@id='electricity_payment_method_dropdown_link_chosen']/a/div/b";
        public string XP_PAYMENT_TYPE_ELEC { get; set; } = ".//*[@id='electricity_payment_method_dropdown_link_chosen']/div/ul/li[text()='{0}']";
        public string XP_MAIN_SOURCE_HEATING { get; set; } = ".//*[@id='electricity-main-heating-source-question']/div/div/label/input[@id='electricity-main-heating-{0}']";
        public string XP_USAGE_TYPE_ELEC { get; set; } = ".//*[@id='electricity-usage-question']//input[@id='{0}']";
        public string XP_USAGE_AMOUNT_ELEC { get; set; } = ".//*[@id='electricity-spend']";
        public string XP_USAGE_PERIOD_ELEC_DROPDOWN { get; set; } = ".//*[@id='electricity_spend_dropdown_chosen']/a/div/b";
        public string XP_USAGE_PERIOD_ELEC { get; set; } = ".//*[@id='electricity_spend_dropdown_chosen']/div/ul//li[text()='{0}']";
        public string XP_BILL_DATE_ELEC_DROPDOWN { get; set; } = ".//*[@id='electricity-bill-day']";
        public string XP_BILL_DATE_ELEC { get; set; } = ".//*[@id='electricity-bill-date-field']//*[@class='picker__box']/table/tbody/tr/td/div[@aria-label='{0}']";
        #endregion

        #region *** Public Methods ***

        public string GetEnergySectionTitle()
        {
            WebDriverWait wait = new WebDriverWait(WebBrowser.Current, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XP_YOUR_ENERGY_ENERGY_TYPE_TITLE)));
            return WebBrowser.Current.FindElement(By.XPath(XP_YOUR_ENERGY_ENERGY_TYPE_TITLE)).Text;
        }

        public bool EnterElectricityDetails(string field, string value)
        {
            switch(field)
            {
                case "TARIFF_ELEC":
                    WebBrowser.Current.FindElement(By.XPath(XP_BILL_DATE_ELEC_DROPDOWN)).Click();
                    WebBrowser.Current.FindElement(By.XPath(String.Format(XP_CURRENT_ELEC_TARIFF,value))).Click();
                    break;
                case "ECONOMY7":
                    WebBrowser.Current.FindElement(By.XPath(String.Format(XP_ECONOMY_7, value))).Click();
                    break;
                case "PAY_TYPE_ELEC":
                    WebBrowser.Current.FindElement(By.XPath(XP_PAYMENT_TYPE_ELEC_DROPDOWN)).Click();
                    WebBrowser.Current.FindElement(By.XPath(String.Format(XP_PAYMENT_TYPE_ELEC, value))).Click();
                    break;
                case "MAIN_SOURCE_ELEC":
                    WebBrowser.Current.FindElement(By.XPath(String.Format(XP_MAIN_SOURCE_HEATING, value))).Click();
                    break;
                case "USAGE_TYPE_ELEC":
                    WebBrowser.Current.FindElement(By.XPath(XP_USAGE_TYPE_ELEC)).Click();
                    break;
                case "USAGE_AMOUNT_ELEC":
                    WebBrowser.Current.FindElement(By.XPath(XP_USAGE_AMOUNT_ELEC)).SendKeys(value);
                    break;
                case "USAGE_PERIOD_ELEC":
                    WebBrowser.Current.FindElement(By.XPath(XP_USAGE_PERIOD_ELEC_DROPDOWN)).Click();
                    WebBrowser.Current.FindElement(By.XPath(String.Format(XP_USAGE_PERIOD_ELEC, value))).Click();
                    break;
                case "BILL_DATE_ELEC":
                    WebBrowser.Current.FindElement(By.XPath(XP_BILL_DATE_ELEC_DROPDOWN)).Click();
                    WebBrowser.Current.FindElement(By.XPath(String.Format(XP_BILL_DATE_ELEC, value))).Click();
                    break;
            }
            return false;
        }

        public bool EnterGasDetails(string field, string value)
        {
            return true;
        }

        #endregion

        #region *** Private Methods ***

        #endregion
    }
}
