using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumTestsWithoutPOM
{
    public class GoogleTests
    {
        [Test]
        public void DemoTest() 
        {
            string expectedResult = "Hello World - Google Search";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";

            IWebElement buttonDeclineCookies = driver.FindElement(By.XPath("//*[@id=\"W0wltc\"]"));
            buttonDeclineCookies.Click();

            IWebElement inputSearch = driver.FindElement(By.XPath("//*[@id=\"APjFqb\"]"));
            inputSearch.SendKeys("Hello World");

            IWebElement buttonSearch = driver.FindElement(By.XPath("(//*[@name=\"btnK\"])[2]"));
            buttonSearch.Click();

            string actualResult = driver.Title;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
