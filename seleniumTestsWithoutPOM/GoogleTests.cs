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
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";    
        }
    }
}
