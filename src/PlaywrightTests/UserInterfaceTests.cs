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
            driver.Navigate().GoToUrl("https://www.letsusedata.com/");
            driver.FindElement(By.Id("txtUser")).Click();
            driver.FindElement(By.Id("txtUser")).Clear();
            driver.FindElement(By.Id("txtUser")).SendKeys("Test2");
            driver.FindElement(By.Id("txtPassword")).Click();
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("iF3sBF7c");
            driver.FindElement(By.Id("javascriptLogin")).Click();

    }
}
