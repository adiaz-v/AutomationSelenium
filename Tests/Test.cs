using AutomatizacionPrueba.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutomatizacionPrueba
{
    [TestClass]
    public class Test : BaseTest
    {
        [TestMethod]
        public void LoginSendbox()
        {
            Login login = new Login(driver);
            login.login("20255735439", "asdasd123");
        }
    }
}
