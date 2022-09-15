using AutomatizacionPrueba.Setup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPrueba
{
    public class BaseTest
    {
        public IWebDriver driverChrome { get; private set; }

        [TestInitialize]
        public void Setup()
        {
            var drivers = new WebDriverFactory();
            driverChrome = drivers.Create();
            driverChrome.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDownAfterTestMethod()
        {
            close();
        }

        public void close()
        {
            driverChrome.Close();
            driverChrome.Quit();
        }
    }
}
