using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject22.Drivers;
using SpecFlowProject22.Pages;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject22.StepDefinitions
{
    [Binding]
    public class StepDefinitions1:DriverBase
    {
        HomePage Demo;

        [Given(@"That I am on the telerik web site")]
        public void GivenThatIAmOnTheTelerikWebSite()
        {

            // driver.Navigate().GoToUrl("https://www.telerik.com/support/demos");
            launchurl();
        }

        [When(@"I click the web link")]
        public void WhenIClickTheLink()
        {
            // HomePage homePage = new HomePage();
            Demo = new HomePage(driver);
            Demo.demo.Click();
           // Demo.desktop.Click();

        }

        [Then(@"I see the other options")]
        public void ThenISeeTheOtherOptions()
        {
            Assert.That(driver.FindElement(By.Id("web")).Displayed);
         //   Assert.That(driver.FindElement(By.Id("desktop")).Displayed);
          //  Task.Delay(1000).Wait();
            driver.Quit();
        }

        [When(@"I click the services link")]
        public void WhenIClickTheServicesLink()
        {
            Demo = new HomePage(driver);
            Demo.services.Click();
        }

        [Then(@"services page should display")]
        public void ThenServicesPageShouldDisplay()
        {
            Assert.That(driver.FindElement(By.LinkText("Talk to a Consultant")).Displayed);
            // Task.Delay(1000).Wait();
            driver.Close();
        }

        [When(@"I click the blogs link")]
        public void WhenIClickTheBlogsLink()
        {
            Demo = new HomePage(driver);
            Demo.blogs.Click();
        }

        [Then(@"blogs page should display")]
        public void ThenBlogsPageShouldDisplay()
        {
            Assert.That(driver.FindElement(By.LinkText("WEB")).Displayed);
            driver.Close();
        }

        [When(@"I Click the prices link")]
        public void WhenIClickThePricesLink()
        {
            Demo = new HomePage(driver);
            Demo.prices.Click();    
        }

        [Then(@"prices page should display")]
        public void ThenPricesPageShouldDisplay()
        {
            Assert.That(driver.FindElement(By.LinkText("PRODUCT BUNDLES")).Displayed);
            driver.Close();

        }


    }
}
