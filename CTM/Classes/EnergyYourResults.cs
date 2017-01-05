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
    public class EnergyYourResults : BasePage
    {
        private static readonly String Url = "";

        public EnergyYourResults(IWebDriver driver) :base (driver, Url)
        {
        }

        #region *** XPaths ***
        public string XP_YOUR_SUPPLIER_TITLE { get; set; } = string.Empty;
        #endregion

        #region *** Public Methods ***

        #endregion

        #region *** Private Methods ***

        #endregion
    }
}
