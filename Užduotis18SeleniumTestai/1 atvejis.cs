
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;

namespace Užduotis18SeleniumTestai
{
    public class Class1
    {
        [Test]
        public void DemoTest()
        {
            string expectedResultEmail = "Email:name@example.com";
            string expectedResultName = "Name:Iryna";
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            inputName.SendKeys("Iryna");

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            inputEmail.SendKeys("name@example.com");

            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            inputCurrentAddress.SendKeys("Vilnius");

            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            inputPermanentAddress.SendKeys("Kaunas");

            IWebElement submit = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
          
            submit.Click();
            var elementOutputEmail = driver.FindElement(By.XPath("//*[@id=\"email\"]"));
            var elementOutputName = driver.FindElement(By.XPath("//*[@id=\"name\"]"));
            string actualResultEmail = elementOutputEmail.Text;
            string actualResultName = elementOutputName.Text;
            driver.Quit();
            Assert.AreEqual(expectedResultEmail, actualResultEmail);
        }
    }
}
