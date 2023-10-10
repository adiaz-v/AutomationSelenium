using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPrueba.Pages
{
    public class Login
    {


        private IWebDriver driver;
        private WebDriverWait wait;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        #region Componentes

        [FindsBy(How = How.Id, Using =
          "")]
        private IWebElement txtUsuario;

        [FindsBy(How = How.Id, Using =
          "")]
        private IWebElement txtContraseña;

        [FindsBy(How = How.XPath, Using =
            "")]
        private IWebElement btnIngresar;
        #endregion

        public void login(string usuario, string contraseña)
        {
            driver.Navigate().GoToUrl("https://www.google.com.ar/");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(txtUsuario));
            txtUsuario.SendKeys(usuario);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(txtContraseña));
            txtContraseña.SendKeys(contraseña);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(btnIngresar));
            btnIngresar.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible
                (By.XPath("")));
            string texto = driver.FindElement(By.XPath("//span[@class='md-headline ng-binding']")).Text;
            Assert.AreEqual("", texto);
        }
    }
}
