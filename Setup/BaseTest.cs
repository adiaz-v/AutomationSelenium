using AutomatizacionPrueba.Setup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPrueba
{
    public class BaseTest
    {
        protected IWebDriver driver = new ChromeDriver();

        [TestInitialize]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDownAfterTestMethod()
        {
            close();
        }

        public void close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
