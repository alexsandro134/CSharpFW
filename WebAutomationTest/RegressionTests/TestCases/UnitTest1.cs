using System;
using NUnit.Framework;
using System.Collections.Generic;
using Automation_Framework.Core.Common;
using Automation_Framework.Core.WebDriver;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;
using System.Configuration;
using OpenQA.Selenium;

namespace WebAutomationTest.RegressionTests.TestCases
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            HtmlReporter.CreateExtentReport();
            HtmlReporter.CreateTest("test");
            WebDriverMethod driver = new WebDriverMethod();
            driver.Init("firefox");

            driver.OpenUrl("http://demo.automationtesting.in/Index.html");
            //driver.CompareScreenshot("entry page");
            driver.CompareScreenshot("Signin btn", By.Id("btn1"));
            driver.DestroyDriver();
        }

    }
}
