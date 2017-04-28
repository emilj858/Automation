using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFormzAutomation
{
    public class TemplatePage
    {
        public static void GoTo()
        {
            var menuTemplate = Driver.Instance.FindElement(By.CssSelector("#menuFORMS a"));
            menuTemplate.Click();

            var testTemplate = Driver.Instance.FindElement(By.LinkText("Test Templates"));
            testTemplate.Click();

            var formulaTest = Driver.Instance.FindElement(By.LinkText("Formula Test V1.3"));
            formulaTest.Click();
        }

        public static void CreateForm()
        {
            var createForm = Driver.Instance.FindElement(By.LinkText("More"));
            createForm.Click();

            var openForm = Driver.Instance.FindElement(By.LinkText("New Form"));
            openForm.Click();
        }
    }
}
