using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject22.Drivers
{
    public class DriverBase
    {
        public IWebDriver driver;

        public void launchurl()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.telerik.com/support/demos");
            driver.Manage().Window.Maximize();
          //  Environment.Exit(0);

        }
    }
}
