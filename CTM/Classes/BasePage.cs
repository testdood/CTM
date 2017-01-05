using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using CTM.Classes;
using System.Threading.Tasks;

namespace CTM.Classes
{
    public class BasePage
    {
        private IWebDriver driver;
        private readonly string WebUrl;


        #region *** Xpaths ***

        #endregion

        #region *** Pulic methods ***

        #endregion

        #region *** Private Methods ***

        #endregion

        #region *** Protected Methods ***

        protected BasePage (IWebDriver driver, String loadUrl = "")
        {
            this.driver = WebBrowser.Current;
            WebUrl = loadUrl;
        }

        #endregion
    }
}
