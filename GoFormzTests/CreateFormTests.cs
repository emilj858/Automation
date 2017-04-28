using GoFormzAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace GoFormzTests
{
    [TestClass]
    public class CreateFormTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestMethod]
        public void Can_Create_A_Form()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("prod.test@goformz.com").WithPassword("goformz2").Login();

            TemplatePage.GoTo();
            TemplatePage.CreateForm();

           


        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
