﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFormzAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}
