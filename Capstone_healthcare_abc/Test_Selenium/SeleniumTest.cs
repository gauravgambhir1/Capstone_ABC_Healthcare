using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class SeleniumTestTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void seleniumTest()
    {
        driver.Navigate().GoToUrl("https://localhost:44362/");
        driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
        driver.FindElement(By.LinkText("Register")).Click();
        driver.FindElement(By.LinkText("Log in")).Click();
        driver.FindElement(By.Id("EmailAddress")).Click();
        driver.FindElement(By.Id("EmailAddress")).SendKeys("admin@capstone.com");
        driver.FindElement(By.Id("Password")).Click();
        driver.FindElement(By.Id("Password")).SendKeys("!Admin1");
        driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
        driver.FindElement(By.LinkText("Add to cart | Price: $64.10")).Click();
        driver.FindElement(By.CssSelector(".bi-arrow-left-square-fill")).Click();
        driver.FindElement(By.LinkText("Add to cart | Price: $55.00")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(1) .alert-success > .bi")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(2) .alert-success > .bi")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(2) .alert-success > .bi")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(1) .alert-danger > .bi")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(1) .alert-danger > .bi")).Click();
        driver.FindElement(By.LinkText("Complete Order")).Click();
        driver.FindElement(By.Id("profile-btn")).Click();
        driver.FindElement(By.LinkText("All Orders")).Click();
        driver.FindElement(By.Id("profile-btn")).Click();
        driver.FindElement(By.LinkText("App Users")).Click();
        driver.FindElement(By.CssSelector(".btn-outline-danger")).Click();
        driver.FindElement(By.LinkText("Register")).Click();
        driver.FindElement(By.LinkText("Log in")).Click();
        driver.FindElement(By.Id("EmailAddress")).Click();
        driver.FindElement(By.Id("EmailAddress")).SendKeys("xuser@capstone.com");
        driver.FindElement(By.Id("Password")).Click();
        driver.FindElement(By.Id("Password")).SendKeys("!User1");
        driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
        driver.FindElement(By.CssSelector(".col-md-4:nth-child(10) .col-md-12 b")).Click();
        driver.FindElement(By.CssSelector(".bi-arrow-left-square-fill")).Click();
        driver.FindElement(By.LinkText("Add to cart | Price: $375.00")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(1) .alert-success")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(2) .alert-success > .bi")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(1) .alert-danger > .bi")).Click();
        driver.FindElement(By.Id("profile-btn")).Click();
        driver.FindElement(By.LinkText("My Orders")).Click();
        driver.FindElement(By.Id("profile-btn")).Click();
        driver.FindElement(By.CssSelector(".container-fluid:nth-child(1)")).Click();
        driver.FindElement(By.LinkText("Complete Order")).Click();
        driver.FindElement(By.CssSelector(".btn-outline-danger")).Click();
        driver.FindElement(By.CssSelector(".nav-item:nth-child(2) b")).Click();
        driver.FindElement(By.CssSelector(".bi-cart3")).Click();
        driver.FindElement(By.CssSelector(".nav-item:nth-child(1) b")).Click();
    }
}