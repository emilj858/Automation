using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFormzAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace GoFormzTests
{
    [TestClass]
    public class LoginTests
    {
        // [TestMethod]
        // public void Login_To_GoFormz()
        // {
            //Create the reference for our browser
            //IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            //driver.Navigate().GoToUrl("http://app.goformz.com");

            //Find the Search text box UI Element
            //IWebElement element = driver.FindElement(By.Id("username"));
            //IWebElement element2 = driver.FindElement(By.Id("password"));

            //Perform Ops
            //element.SendKeys("emil.prod@goformz.com");
           // element2.SendKeys("goformz2");

            //Click Login


            //Thread.Sleep(4000);

            //Close the browser
            //driver.Close();
        //}

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestMethod]
        public void User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("emil.prod@goformz.com").WithPassword("goformz2").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login");
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
