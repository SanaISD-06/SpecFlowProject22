using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SpecFlowProject22.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject22.Pages
{
    public class HomePage:DriverBase
    {
       // private readonly object PageFactory;

        // private readonly DriverBase driver;
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ContentPlaceholder1_T53129E6C012_Col00\"]/nav/div/div[2]/a[1] ")]

        public IWebElement demo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ContentPlaceholder1_T53129E6C012_Col00\"]/nav/div/div[2]/a[2]")]

        public IWebElement desktop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"js-tlrk-nav-drawer\"]/ul[1]/li[2]/a")]

        public IWebElement services { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"js-tlrk-nav-drawer\"]/ul[1]/li[3]/a")]
        public IWebElement blogs { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"js-tlrk-nav-drawer\"]/ul[1]/li[5]/a")]
        public IWebElement prices { get; set; }


        /*  public HomePage()
          {
              driver.FindElement(By.ClassName("TK-Aside-Menu-Button")).Click();
              driver.FindElement(By.Id("email")).SendKeys("unknown123@gmail.com");

          }
        */
    }
}
