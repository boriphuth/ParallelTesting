using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;


namespace parallel
{
    [TestFixture]
    public class Class1
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("browserstack.user", "shayansadullah3");
            capability.SetCapability("browserstack.key", "tzFptNc5M6NqL7a7WXqm");
            capability.SetCapability("browserName", "Firefox");
            capability.SetCapability("browser_version", "11.0");
            capability.SetCapability("os", "Windows");
            capability.SetCapability("browserstack.debug", true);

            driver = new RemoteWebDriver(
              new Uri("http://hub.browserstack.com/wd/hub/"), capability);
        }


        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://www.net-evidence.com");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var caseStudies = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#nav > ul.nav.menu.menuRight.notMob > li.item-108 > a.menuResources")));
            caseStudies.Click();
            var h1Element = wait.Until(ExpectedConditions.ElementExists(By.TagName("h1")));
            Assert.That(h1Element.Text.Contains("Case Studies"));

        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

    }

    [TestFixture]
    public class Class2
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("browserstack.user", "shayansadullah3");
            capability.SetCapability("browserstack.key", "tzFptNc5M6NqL7a7WXqm");
            capability.SetCapability("browserName", "Chrome");
            capability.SetCapability("os", "Windows");
            capability.SetCapability("browserstack.debug", true);

            driver = new RemoteWebDriver(
              new Uri("http://hub.browserstack.com/wd/hub/"), capability);
        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("http://www.net-evidence.com");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var caseStudies = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#nav > ul.nav.menu.menuRight.notMob > li.item-108 > a.menuResources")));
            caseStudies.Click();
            var h1Element = wait.Until(ExpectedConditions.ElementExists(By.TagName("h1")));
            Assert.That(h1Element.Text.Contains("Case Studies"));

        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

    }
}

