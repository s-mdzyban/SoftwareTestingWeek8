using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class MortgageTest
{
    private static IWebDriver driver = new ChromeDriver();
    
    public string RunTest()
    {
		Test();
		return ChromeDriver.GetLog();
    }

    public void Test()
    {
        //Insert your code only here
            driver.Navigate().GoToUrl("https://www.moneyunder30.com/mortgage-calculator/");
            driver.FindElement(By.Id("fieldname23_1")).Click();
            driver.FindElement(By.Id("fieldname23_1")).Clear();
            driver.FindElement(By.Id("fieldname23_1")).SendKeys("$100,000.00");
            driver.FindElement(By.Id("fieldname24_1")).Click();
            driver.FindElement(By.Id("fieldname24_1")).Click();
            driver.FindElement(By.Id("fieldname24_1")).Clear();
            driver.FindElement(By.Id("fieldname24_1")).SendKeys("$0.00");
            driver.FindElement(By.Id("fieldname25_1")).Click();
            driver.FindElement(By.Id("fieldname25_1")).Clear();
            driver.FindElement(By.Id("fieldname25_1")).SendKeys("3.50%");
            driver.FindElement(By.Id("fieldname19_1")).Click();
            driver.FindElement(By.Id("fieldname19_1")).Click();
            driver.FindElement(By.Id("fieldname19_1")).Clear();
            driver.FindElement(By.Id("fieldname19_1")).SendKeys("30");
            driver.FindElement(By.Id("fieldname26_1")).Click();
            Assert.AreEqual("$449.04", driver.FindElement(By.Id("fieldname20_1")).GetAttribute("value"));

    }
}
